using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState
{
    public interface ActorState
    {
        string getState();
        double getDamageTaken();
        double getDamageGiven();
    }
}
