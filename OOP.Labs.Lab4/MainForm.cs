using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab4
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Матрица смежности
		/// </summary>
		private CommonMatrix _adjacencyMatrix;

		/// <summary>
		/// Матрица вершин графа
		/// </summary>
		private CommonMatrix _vertexMatrix;

		public MainForm()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{

		}

		private void Adjacency_LoadClick(object sender, EventArgs e)
		{
			fileLoadDialog.Filter = "Файл матрицы смежности (*.mgr)|*.mgr";
			fileLoadDialog.RestoreDirectory = true;

			if (fileLoadDialog.ShowDialog(this) == DialogResult.OK)
			{
				adjacencyTextEdit.Text = fileLoadDialog.FileName;

				var matr = new CommonMatrix(fileLoadDialog.FileName);
				_adjacencyMatrix = matr;

				DrawGraph();
			}
		}

		private void Vertex_LoadClick(object sender, EventArgs e)
		{
			fileLoadDialog.Filter = "Файл матрицы вершин графа (*.mpl)|*.mpl";
			fileLoadDialog.RestoreDirectory = true;

			if (fileLoadDialog.ShowDialog(this) == DialogResult.OK)
			{
				vertexTextEdit.Text = fileLoadDialog.FileName;

				var matr = new CommonMatrix(fileLoadDialog.FileName);
				_vertexMatrix = matr;

				DrawGraph();
			}
		}

		private void DrawGraph()
		{
			var g = drawPanel.CreateGraphics();
			g.Clear(drawPanel.BackColor);

			if (_vertexMatrix == null || _adjacencyMatrix == null)
				return;

			var vertex = new List<Vertex>();

			// Находим вершины
			for (int i = 0; i < _vertexMatrix.Rows; i++)
			{
				for (int j = 0; j < _vertexMatrix.Columns; j++)
				{
					var num = _vertexMatrix.Value[i, j].Value;
					if (num > -1)
						vertex.Add(new Vertex((int)num, GetRectForPoint(i, j)));
				}
			}
			vertex = vertex.OrderBy(v => v.Number).ToList();
			// Рисуем связи
			for (int i = 0; i < _adjacencyMatrix.Rows; i++)
			{
				for (int j = 0; j < _adjacencyMatrix.Columns; j++)
				{
					var num = _adjacencyMatrix.Value[i, j].Value;
					if (num > 0)
					{
						Vertex fromVert = vertex[i], toVert = vertex[j];

						float size = (float)fromVert.Rectangle.Width / 12;
						Pen pen = new Pen(Color.Black, size)
						{
							StartCap = LineCap.RoundAnchor,
							CustomEndCap = new AdjustableArrowCap(size * 0.8f, size * 2f)
						};
						g.DrawLine(pen, fromVert.Center, toVert.Center);
					}
				}
			}
			// Отрисовываем вершины
			for (int i = 0; i < vertex.Count; i++)
			{
				var vert = vertex[i];
				g.FillEllipse(new SolidBrush(Color.White), vert.Rectangle);
				g.DrawEllipse(new Pen(Color.Blue, 1.5f), vert.Rectangle);

				// Шрифт текста
				var font = new Font(DefaultFont.FontFamily, vert.Rectangle.Width / 1.5f);
				g.DrawString(vert.Number.ToString(), font, new SolidBrush(Color.Black), 
					new RectangleF(vert.Rectangle.X + vert.Rectangle.Width / 8, 
						vert.Rectangle.Y, vert.Rectangle.Width, vert.Rectangle.Height));
			}
		}

		private Rectangle GetRectForPoint(int row, int col)
		{
			// Размеры одной клетки
			int cellWidth = drawPanel.Width / _vertexMatrix.Columns,
				cellHeight = drawPanel.Height / _vertexMatrix.Rows;

			if (cellWidth > cellHeight)
			{
				var diff = (cellWidth - cellHeight) / 2;
				return new Rectangle(cellWidth * col + diff, cellHeight * row, cellHeight, cellHeight);
			}
			else
			{
				var diff = (cellHeight - cellWidth) / 2;
				return new Rectangle(cellWidth * col, cellHeight * row + diff, cellWidth, cellWidth);
			}
		}

		private void ResizeEnded(object sender, EventArgs e)
		{
			DrawGraph();
		}
	}
}