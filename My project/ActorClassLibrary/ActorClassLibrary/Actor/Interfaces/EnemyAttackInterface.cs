using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBaseClassLibrary.Actor.Interfaces
{
    public interface EnemyAttackInterface : AttackInterface
    {
        void OnDrawGizmosSelected();
    }
}
