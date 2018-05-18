using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab2
{
	public partial class MainForm : Form
	{
		private SecondDegreePolynom<ComplexNumber> _polynom;

		public MainForm()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			_polynom = new SecondDegreePolynom<ComplexNumber>(
				new ComplexNumber(aCoefTextEdit.Text), 
				new ComplexNumber(bCoefTextEdit.Text), 
				new ComplexNumber(cCoefTextEdit.Text)
			);
		}

		private void CoefValueChanged(object sender, EventArgs e)
		{
			var textEdit = sender as TextEdit;
			if (textEdit == null || !ComplexNumber.IsSuitable(textEdit.Text))
				return;
			
			switch (textEdit.Name)
			{
				case "aCoefTextEdit":
					_polynom.A = new ComplexNumber(textEdit.Text);
					break;
				case "bCoefTextEdit":
					_polynom.B = new ComplexNumber(textEdit.Text);
					break;
				case "cCoefTextEdit":
					_polynom.C = new ComplexNumber(textEdit.Text);
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

			firstRootTextEdit.EditValue = roots[0].ToString();
			secondRootTextEdit.EditValue = roots[1].ToString();
		}

		private void RefreshPolynomValue()
		{
			var x = xValueTextEdit.Text;
			if (!ComplexNumber.IsSuitable(x))
				return;

			var value = _polynom.GetValue(new ComplexNumber(x));
			polynomValueTextEdit.Text = value.ToString();
		}
	}
}
