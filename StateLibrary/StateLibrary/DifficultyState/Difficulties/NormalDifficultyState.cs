using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.DifficultyState.Difficulties
{
    public class NormalDifficultyState : AbsDifficulty
    {
        public NormalDifficultyState() {
            this.Scaling = 1.0;
        }  
        public override string getDifficulty()
        {
            return "normal";
        }
    }
}
