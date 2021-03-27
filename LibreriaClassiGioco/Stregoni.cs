using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiGioco
{
    public class Stregoni : Razza
    {
        public Schieramento schieramento;
        public Stregoni(Schieramento s)
        {
            schieramento = s;
        }
        public override Schieramento GetSchieramento()
        {
            return Schieramento.Male;
        }
        public override uint GetAtk()
        {
            return 90;
        }
        public override uint GetDef()
        {
            return 30;
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
