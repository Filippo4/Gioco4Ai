using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiGioco
{
    class Troll : Razza
    {
        public Schieramento schieramento;
        public Troll(Schieramento s)
        {
            schieramento = s;
        }
        public override Schieramento GetSchieramento()
        {
            return Schieramento.Male;
        }
        public override uint GetAtk()
        {
            return 50;
        }
        public override uint GetDef()
        {
            return 40;
        }
        public override bool PuoiAttaccare(Razza r)
        {
            if (schieramento != r.GetSchieramento())
            {
                return true;
            }
            else
                return false;
        }
    }
}
