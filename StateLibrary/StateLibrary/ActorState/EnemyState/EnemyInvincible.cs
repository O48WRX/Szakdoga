using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.EnemyState
{
    public class EnemyInvincible : AbsActorState
    {
        public EnemyInvincible() {
            this.DamageGivenMult = 1.0;
            this.DamageTakenMult = 0.0;
        }
        public override string getState()
        {
            return "Invincible";
        }
    }
}
