using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab5
{
	public partial class StateGraphForm : Form
	{
		private int _layoutColumns, _layoutRows;

		private List<StateVertex> _vertexList;

		private StateVertex _selectedVertex;

		private StateVertex _prevSelectedVertex;
		
		private bool _isStarted;

		private MainForm _parent;

		public StateGraphForm(CommonMatrix vert, CommonMatrix state, MainForm form)
		{
			InitializeComponent();
			_layoutRows = vert.Rows;
			_layoutColumns = vert.Columns;
			_parent = form;
			InitGraph(vert, state);
		}

		private void InitGraph(CommonMatrix vert, CommonMatrix state)
		{
			// Инициализация вершин и переходов
			_vertexList = StateVertex.GetVertexes(vert, GetRectForPoint);
			StateVertex.FillTransitions(_vertexList, state);
		}

		public void NextStateRandom()
		{
			_prevSelectedVertex = _selectedVertex;

			if (_selectedVertex == null)
			{
				_selectedVertex = _vertexList[new Random(DateTime.Now.Millisecond).Next(_vertexList.Count)];
			}
			else
			{
				int nextStateIndex = new Random(DateTime.Now.Millisecond).Next(_selectedVertex.Transitions.Count);
				_selectedVertex = _selectedVertex.Transitions[nextStateIndex];
			}

			DrawGraph();

			_parent.UpdateGraphInfo(_selectedVertex, _prevSelectedVertex);
		}

		public void StartRandomMoving()
		{
			_isStarted = true;
			
			Thread th = new Thread(() =>
			{
				while (_isStarted)
				{
					NextStateRandom();
					Thread.Sleep(500);
				}
			});
			th.Start();
		}

		public void StopRandomMoving()
		{
			_isStarted = false;
		}

		#region Drawing

		private void DrawGraph()
		{
			SuspendLayout();

			var g = drawPanel.CreateGraphics();
			g.Clear(drawPanel.BackColor);

			// Рисуем связи
			foreach (var fromVert in _vertexList)
			{
				foreach (var toVert in fromVert.Transitions)
				{
					float size = (float)fromVert.Rectangle.Width / 12;
					Pen pen = new Pen(Color.Black, size)
					{
						StartCap = LineCap.RoundAnchor,
						CustomEndCap = new AdjustableArrowCap(size * 0.8f, size * 2f)
					};
					g.DrawLine(pen, fromVert.Center, toVert.Center);
				}
			}

			// Отрисовываем вершины
			foreach (var vert in _vertexList)
			{
				g.FillEllipse(new SolidBrush(vert.Number == _selectedVertex?.Number ? Color.Yellow : Color.White), vert.Rectangle);
				g.DrawEllipse(new Pen(Color.Blue, 1.5f), vert.Rectangle);

				// Шрифт текста
				var font = new Font(DefaultFont.FontFamily, vert.Rectangle.Width / 1.5f);
				g.DrawString(vert.Number.ToString(), font, new SolidBrush(Color.Black),
					new RectangleF(vert.Rectangle.X + vert.Rectangle.Width / 8,
						vert.Rectangle.Y, vert.Rectangle.Width, vert.Rectangle.Height));
			}

			ResumeLayout();
		}

		private Rectangle GetRectForPoint(int row, int col)
		{
			// Размеры одной клетки
			int cellWidth = drawPanel.Width / _layoutColumns,
				cellHeight = drawPanel.Height / _layoutRows;

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

		#endregion

		#region Handlers

		private void OnResizeEnd(object sender, EventArgs e)
		{
			DrawGraph();
		}

		private void DrawPanelOnMouseEnter(object sender, EventArgs e)
		{
			DrawGraph();
		}

		private void DrawPanelMouseDown(object sender, MouseEventArgs e)
		{
			_prevSelectedVertex = _selectedVertex = null;
			if (e.Button == MouseButtons.Left)
			{
				foreach (var vert in _vertexList)
				{
					var rect = vert.Rectangle;
					if (e.X >= rect.X && e.X <= rect.X + rect.Width &&
					    e.Y >= rect.Y && e.Y <= rect.Y + rect.Height)
					{
						_selectedVertex = vert;
						break;
					}
				}
				DrawGraph();

				_parent.UpdateGraphInfo(_selectedVertex, _prevSelectedVertex);
			}
		}

		#endregion
	}
}
