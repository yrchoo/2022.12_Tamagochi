using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CharacterData
    {


        public string Name { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public double Hunger { get; set; }
        public double Happiness { get; set; }
        public int Gold { get; set; }

        public CharacterData(string name, int exp, int level, double hunger, double happiness, int gold)
        {
            Name= name;
            Exp = exp;
            Level = level;
            Hunger = hunger;
            Happiness = happiness;
            Gold = gold;
        }
    }
}
