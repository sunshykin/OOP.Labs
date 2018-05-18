using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using OOP.Labs.Lab6.Figures;
using Rectangle = OOP.Labs.Lab6.Figures.Rectangle;

namespace OOP.Labs.Lab6
{
	public partial class MainForm : Form
	{
		#region NestedType

		class Params
		{
			public double AreaWidth;

			public double AreaHeight;

			public int FiguresCount;

			public bool IsRandomScan;

			public bool IsRegularScan;

			public int RandomCount;

			public int RegularCountWidth;

			public int RegularCountHeight;
		}

		#endregion

		#region Fields

		private Params _params;

		private IList<Figure> _figures;

		#endregion

		public MainForm()
		{
			InitializeComponent();
		}

		private Params GetParams()
		{
			return new Params
			{
				AreaWidth = (double)widthSpinEdit.Value,
				AreaHeight = (double)heightSpinEdit.Value,
				FiguresCount = (int)countSpinEdit.Value,
				IsRandomScan = randomScanCheckEdit.Checked,
				IsRegularScan = regularScanCheckEdit.Checked,
				RandomCount = (int)randomScanSpinEdit.Value,
				RegularCountWidth = (int)regularWidthSpinEdit.Value,
				RegularCountHeight = (int)regularHeightSpinEdit.Value
			};
		}

		public void CreateFigures()
		{
			_figures = new List<Figure>();
			var rnd = new Random(DateTime.Now.Millisecond);
			for (int i = 0; i < _params.FiguresCount; i++)
			{
				var point = new Point(rnd.Next((int)_params.AreaWidth), rnd.Next((int)_params.AreaHeight));
				switch (rnd.Next(4))
				{
					case 0:
						_figures.Add(new Circle(_params.AreaWidth, _params.AreaHeight, point));
						break;
					case 1:
						_figures.Add(new Ellipse(_params.AreaWidth, _params.AreaHeight, point));
						break;
					case 2:
						_figures.Add(new Square(_params.AreaWidth, _params.AreaHeight, point));
						break;
					case 3:
						_figures.Add(new Rectangle(_params.AreaWidth, _params.AreaHeight, point));
						break;
				}
			}
		}

		private Tuple<double, double> Calculate()
		{
			double randomPercent = Double.NaN;
			if (_params.IsRandomScan)
			{
				var rnd = new Random(DateTime.Now.Millisecond);
				int free = 0;
				for (int i = 0; i < _params.RandomCount; i++)
				{
					var point = new Point(rnd.Next((int)_params.AreaWidth), rnd.Next((int)_params.AreaHeight));
					if (_figures.All(f => !f.IsPointInArea(point)))
						free++;
				}

				randomPercent = free == 0 ? Double.NaN : (double)free / _params.RandomCount;
			}

			double regularPercent = Double.NaN;
			if (_params.IsRegularScan)
			{
				double cellW = _params.AreaWidth / _params.RegularCountWidth,
					cellH = _params.AreaHeight / _params.RegularCountHeight,
					free = 0;
				for (int i = 0; i < _params.RegularCountHeight; i++)
				{
					for (int j = 0; j < _params.RegularCountWidth; j++)
					{
						var point = new Point((int)Math.Round(cellW * j + cellW / 2, 0), (int)Math.Round(cellH * 0 + cellH / 2, 0));
						if (_figures.All(f => !f.IsPointInArea(point)))
							free++;
					}
				}

				regularPercent = free == 0 ? Double.NaN :
					(double)free / (_params.RegularCountWidth * _params.RegularCountHeight);
			}

			return Tuple.Create(randomPercent, regularPercent);
		}

		private void UpdateResults(double random, double regular)
		{
			areaTextEdit.Text = $"{_params.AreaHeight * _params.AreaWidth}";
			countTextEdit.Text = $"{_params.FiguresCount}";

			if (!Double.IsNaN(random))
				randomFreeAreaTextEdit.Text = $"{random:F3}";
			else
				randomFreeAreaTextEdit.Text = String.Empty;

			if (!Double.IsNaN(regular))
				regularFreeAreaTextEdit.Text = $"{regular:F3}";
			else
				regularFreeAreaTextEdit.Text = String.Empty;
		}

		private void FillCalculate_Click(object sender, EventArgs e)
		{
			_params = GetParams();
			CreateFigures();
			var free = Calculate();
			UpdateResults(free.Item1, free.Item2);
		}

		private void Recalculate_Click(object sender, EventArgs e)
		{
			if (_params == null || _figures == null || _figures.Count < 1)
				return;

			var free = Calculate();
			UpdateResults(free.Item1, free.Item2);
		}
	}
}
