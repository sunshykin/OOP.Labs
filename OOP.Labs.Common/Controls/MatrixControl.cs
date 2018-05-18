using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Common.Controls
{
	public partial class MatrixControl : UserControl
	{
		/// <summary>
		/// Размерность матрицы
		/// </summary>
		private int _dimension;

		/// <summary>
		/// Диагональность матрицы
		/// </summary>
		private bool _isDiagonal;

		/// <summary>
		/// Матрица TextEdit-ов
		/// </summary>
		private TextEdit[,] _matrix;

		/// <summary>
		/// Измнеение значений матрицы
		/// </summary>
		public EventHandler MatrixValueChanged;

		public MatrixControl()
		{
			_dimension = 2;
			_isDiagonal = true;
			_matrix = new TextEdit[_dimension, _dimension];

			InitializeComponent();
			Create();
		}

		/// <summary>
		/// Конструктор контролла
		/// </summary>
		/// <param name="n">Размерность матрицы</param>
		/// <param name="diag">Диагональность матрицы</param>
		public MatrixControl(int n, bool diag = true)
		{
			_dimension = n;
			_isDiagonal = diag;
			_matrix = new TextEdit[_dimension, _dimension];

			InitializeComponent();
			Create();
		}

		/// <summary>
		/// Создание полей матрицы
		/// </summary>
		private void Create()
		{
			LayoutControlGroup prevGroup = null;

			for (int i = 0; i < _dimension; i++)
			{
				// Prev LayoutItem
				LayoutControlItem prevItem = null;
				// Group-Row
				var group = new LayoutControlGroup
				{
					TextVisible = false,
					Padding = new DevExpress.XtraLayout.Utils.Padding(3)
				};

				for (int j = 0; j < _dimension; j++)
				{
					var textEdit = new TextEdit
					{
						Enabled = !_isDiagonal || i == j
					};
					textEdit.EditValueChanged += ValueChanged;
					textEdit.Properties.Appearance.Options.UseTextOptions = true;
					textEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

					var item = new LayoutControlItem(group)
					{
						Control = textEdit,
						TextVisible = false
					};

					if (prevItem == null)
						group.AddItem(item);
					else
						group.AddItem(item, prevItem, InsertType.Right);

					prevItem = item;
					_matrix[i, j] = textEdit;
				}

				if (prevGroup == null)
					mainLayoutControl.AddGroup(group);
				else
					mainLayoutControl.AddGroup(group, prevGroup, InsertType.Bottom);

				prevGroup = group;
			}

			mainLayoutControl.AddItem(new EmptySpaceItem(), prevGroup, InsertType.Bottom);
		}

		/// <summary>
		/// Перестроение матрицы с новой размерностью
		/// </summary>
		/// <param name="n">Размерность матрицы</param>
		public void RecreateMatrix(int n)
		{
			if (_dimension == n)
				return;
			
			mainLayoutControl.Clear();
			_dimension = n;
			_matrix = new TextEdit[_dimension, _dimension];
			Create();
		}

		public void Fill(DiagonalMatrix matr)
		{
			var values = matr.Value;

			for (int i = 0; i < _dimension; i++)
			{
				for (int j = 0; j < _dimension; j++)
				{
					_matrix[i, j].Text = values[i, j]?.ToString();
				}
			}
		}

		public DiagonalMatrix GetMatrix()
		{
			var matrix = new ComplexNumber[_dimension, _dimension];
			for (int i = 0; i < _dimension; i++)
				for (int j = 0; j < _dimension; j++)
					matrix[i, j] = new ComplexNumber(_matrix[i, j].Text);

			return new DiagonalMatrix(matrix);
		}

		#region Handlers

		private void ValueChanged(object sender, EventArgs e)
		{
			MatrixValueChanged?.Invoke(this, e);
		}

		#endregion
	}
}
