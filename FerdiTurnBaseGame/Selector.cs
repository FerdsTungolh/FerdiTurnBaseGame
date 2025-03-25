using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerdiTurnBaseGame
{
    public abstract class Selector
    {
        public abstract void AddPlayer(Selected select);
        public abstract List<Selected> GetPlayer();
    }
}
