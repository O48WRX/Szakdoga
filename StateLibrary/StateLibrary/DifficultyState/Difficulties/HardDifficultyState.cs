using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.DifficultyState.Difficulties
{
    public class HardDifficultyState : AbsDifficulty
    {
        public HardDifficultyState() {
            this.Scaling = 1.5;
        }
        public override string getDifficulty()
        {
            return "hard";
        }
    }
}
