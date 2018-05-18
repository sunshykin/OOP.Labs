using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
//using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab1
{
	public partial class MainForm : Form
	{
		private SecondDegreePolynom<RealNumber> _polynom;

		public MainForm()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			_polynom = new SecondDegreePolynom<RealNumber>(
				new RealNumber(aCoefTextEdit.EditValue), 
				new RealNumber(bCoefTextEdit.EditValue), 
				new RealNumber(cCoefTextEdit.EditValue)
			);
		}

		private void CoefValueChanged(object sender, EventArgs e)
		{
			var textEdit = sender as TextEdit;
			if (textEdit == null || !RealNumber.IsSuitable(textEdit.Text))
				return;
			
			switch (textEdit.Name)
			{
				case "aCoefTextEdit":
					_polynom.A = new RealNumber(textEdit.EditValue);
					break;
				case "bCoefTextEdit":
					_polynom.B = new RealNumber(textEdit.EditValue);
					break;
				case "cCoefTextEdit":
					_polynom.C = new RealNumber(textEdit.EditValue);
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

			firstRootTextEdit.EditValue = double.IsNaN(roots[0].Value) ? "" : roots[0].Value.ToString();
			secondRootTextEdit.EditValue = double.IsNaN(roots[1].Value) ? "" : roots[1].Value.ToString();
		}

		private void RefreshPolynomValue()
		{
			var x = xValueTextEdit.Text;
			if (!RealNumber.IsSuitable(x))
				return;

			var value = _polynom.GetValue(new RealNumber(x));
			polynomValueTextEdit.Text = double.IsNaN(value.Value) ? "" : value.Value.ToString();
		}
	}
}
