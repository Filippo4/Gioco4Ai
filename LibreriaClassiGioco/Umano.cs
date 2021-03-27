using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiGioco
{
    public class Umano : Razza
    {
        public Schieramento schieramento;
        public Umano(Schieramento s)
        {
            schieramento = s;
        }
        public override Schieramento GetSchieramento()
        {
           return Schieramento.Bene;
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
