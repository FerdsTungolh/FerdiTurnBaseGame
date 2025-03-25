using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerdiTurnBaseGame
{
    public class Selected : Selector
    {
        public string Name { get; set; }
        public int choosedplayer { get; set; }

        public List<Selected> Selecta = new List<Selected>();

        public Selected(string name, int choosedplayer)
        {
            Name = name;
            this.choosedplayer = choosedplayer;
        }
        public Selected()
        {
        }   
        public override void AddPlayer(Selected select)
        {
             Selecta.Add(select);
        }

        public override List<Selected> GetPlayer()
        {
            return Selecta;
        }
    }
}
