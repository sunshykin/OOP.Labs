using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OOP.Labs.Common.Controls;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab3
{
	public partial class MainForm : Form
	{
		private SecondDegreePolynom<DiagonalMatrix> _polynom;

		public MainForm()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			int dimension = Int32.Parse(dimensionSpinEdit.EditValue.ToString());

			_polynom = new SecondDegreePolynom<DiagonalMatrix>(
				new DiagonalMatrix(dimension), 
				new DiagonalMatrix(dimension), 
				new DiagonalMatrix(dimension)
			);

			// Matrix
			aCoefMatrixControl.MatrixValueChanged += CoefValueChanged;
			bCoefMatrixControl.MatrixValueChanged += CoefValueChanged;
			cCoefMatrixControl.MatrixValueChanged += CoefValueChanged;
			xValueMatrixControl.MatrixValueChanged += ValueChanged;
		}

		private void CoefValueChanged(object sender, EventArgs e)
		{
			var matrixControl = sender as MatrixControl;
			if (matrixControl == null /*|| !ComplexNumber.IsSuitable(textEdit.Text)*/)
				return;
			
			switch (matrixControl.Name)
			{
				case "aCoefMatrixControl":
					_polynom.A = aCoefMatrixControl.GetMatrix();
					break;
				case "bCoefMatrixControl":
					_polynom.B = bCoefMatrixControl.GetMatrix();
					break;
				case "cCoefMatrixControl":
					_polynom.C = cCoefMatrixControl.GetMatrix();
					break;
			}

			RefreshRoots();
			RefreshPolynomValue();
		}

		private void ValueChanged(object sender, EventArgs e)
		{
			RefreshPolynomValue();
		}

		private void RefreshRoots()
		{
			var roots = _polynom.GetRoots();

			firstRootMatrixControl.Fill(roots[0]);
			secondRootMatrixControl.Fill(roots[1]);
		}

		private void RefreshPolynomValue()
		{
			var x = xValueMatrixControl.GetMatrix();

			var value = _polynom.GetValue(new DiagonalMatrix(x.Value));
			polynomValueMatrixControl.Fill(value);
		}

		private void DimensionChanged(object sender, EventArgs e)
		{
			int value = Int32.Parse(dimensionSpinEdit.EditValue.ToString());
			
			aCoefMatrixControl.RecreateMatrix(value);
			_polynom.A = aCoefMatrixControl.GetMatrix();
			bCoefMatrixControl.RecreateMatrix(value);
			_polynom.B = bCoefMatrixControl.GetMatrix();
			cCoefMatrixControl.RecreateMatrix(value);
			_polynom.C = cCoefMatrixControl.GetMatrix();

			xValueMatrixControl.RecreateMatrix(value);
			firstRootMatrixControl.RecreateMatrix(value);
			secondRootMatrixControl.RecreateMatrix(value);
			polynomValueMatrixControl.RecreateMatrix(value);
		}
	}
}
