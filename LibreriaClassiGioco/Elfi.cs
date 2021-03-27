using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiGioco
{
    public class Elfi :Razza 
    {
        public Schieramento schieramento;
        public Elfi(Schieramento s)
        {
            schieramento = s;
        }
        public override Schieramento GetSchieramento()
        {
            return Schieramento.Bene;
        }
        public override uint GetAtk()
        {
            return 40;
        }
        public override uint GetDef()
        {
            return 80;
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
