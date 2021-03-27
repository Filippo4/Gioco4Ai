using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiGioco
{
    public abstract class Razza
    {
        
        public abstract Schieramento GetSchieramento();
        public abstract uint GetAtk();
        public abstract uint GetDef();
        public abstract bool PuoiAttaccare(Razza r);
    }
}
