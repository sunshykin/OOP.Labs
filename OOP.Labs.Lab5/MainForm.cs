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

namespace OOP.Labs.Lab5
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Матрица состояний
		/// </summary>
		private CommonMatrix _stateMatrix;

		/// <summary>
		/// Матрица вершин графа
		/// </summary>
		private CommonMatrix _vertexMatrix;

		/// <summary>
		/// График
		/// </summary>
		private StateGraphForm _stateGraph;

		private const string _startGeneratorText = "Запустить генератор событий";

		private const string _stopGeneratorText = "Остановить генератор событий";

		public MainForm()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{

		}

		#region Handlers

		private void State_LoadClick(object sender, EventArgs e)
		{
			fileLoadDialog.Filter = "Файл матрицы смежности (*.mgr)|*.mgr";
			fileLoadDialog.RestoreDirectory = true;

			if (fileLoadDialog.ShowDialog(this) == DialogResult.OK)
			{
				adjacencyTextEdit.Text = fileLoadDialog.FileName;

				var matr = new CommonMatrix(fileLoadDialog.FileName);
				_stateMatrix = matr;
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
			}
		}

		private void ShowGraph_Click(object sender, EventArgs e)
		{
			if (_stateGraph == null || _stateGraph.IsDisposed)
			{
				_stateGraph = new StateGraphForm(_vertexMatrix, _stateMatrix, this);
				_stateGraph.Show();
			}
			else
			{
				_stateGraph.Activate();
			}
		}

		#endregion

		#region Methods

		public void UpdateGraphInfo(StateVertex cur, StateVertex prev)
		{
			this.BeginInvoke(new MethodInvoker(delegate
			{
				this.curStateTextEdit.Text = cur == null ? "" : $"S{cur.Number}";
				this.prevStateTextEdit.Text = prev == null ? "" : $"S{prev.Number}";

				this.lastEventTextEdit.Text = cur != null && prev != null ? $"{prev.Number}->{cur.Number}" : "";
			}));
		}

		#endregion

		private void OneTimeEvent_Click(object sender, EventArgs e)
		{
			_stateGraph.NextStateRandom();
		}

		private void StartGenerator_Click(object sender, EventArgs e)
		{
			if (randomGeneratorSimpleButton.Text == _startGeneratorText)
			{
				_stateGraph.StartRandomMoving();
				randomGeneratorSimpleButton.Text = _stopGeneratorText;
			}
			else
			{
				_stateGraph.StopRandomMoving();
				randomGeneratorSimpleButton.Text = _startGeneratorText;
			}
		}
	}
}