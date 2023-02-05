using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.DifficultyState
{
    public abstract class AbsDifficulty : Difficulty
    {
		private double scaling;

		public double Scaling
		{
			get { return scaling; }
			set { scaling = value; }
		}

		public abstract string getDifficulty();
    }
}
