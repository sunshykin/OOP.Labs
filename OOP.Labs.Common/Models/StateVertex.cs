using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Labs.Common.Models
{
	public class StateVertex : Vertex
	{
		public List<StateVertex> Transitions;

		public StateVertex(int number, Rectangle rect) : base(number, rect)
		{
			Transitions = new List<StateVertex>();
		}

		public static void FillTransitions(List<StateVertex> list, CommonMatrix state)
		{
			for (int i = 0; i < state.Rows; i++)
			{
				var trans = list[i].Transitions;
				for (int j = 0; j < state.Columns; j++)
				{
					trans.Add(list[(int)state.Value[i,j].Value]);
				}
			}
		}

		public static List<StateVertex> GetVertexes(CommonMatrix vert, Func<int, int, Rectangle> rectAction)
		{
			var list = new List<StateVertex>();
			for (int i = 0; i < vert.Rows; i++)
			{
				for (int j = 0; j < vert.Columns; j++)
				{
					var num = vert.Value[i, j].Value;
					if (num > -1)
						list.Add(new StateVertex((int)num, rectAction(i, j)));
				}
			}

			return list.OrderBy(v => v.Number).ToList();
		}
	}
}
