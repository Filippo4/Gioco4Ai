using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiGioco
{
    class Orchi : Razza
    {
        public Schieramento schieramento;
        public Orchi(Schieramento s)
        {
            schieramento = s;
        }
        public override Schieramento GetSchieramento()
        {
            return Schieramento.Male;
        }
        public override uint GetAtk()
        {
            return 20;
        }
        public override uint GetDef()
        {
            return 100;
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
