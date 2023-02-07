using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState
{
    public abstract class AbsActorState : ActorState
    {
		private double damagetakenmult;

		public double DamageTakenMult
		{
			get { return damagetakenmult; }
			set { damagetakenmult = value; }
		}

		private double damagegivenmult;

		public double DamageGivenMult
		{
			get { return damagegivenmult; }
			set { damagegivenmult = value; }
		}




		public abstract string getState();

        public double getDamageTaken()
        {
			return DamageTakenMult;
        }

        public double getDamageGiven()
        {
			return DamageGivenMult;
        }
    }
}
