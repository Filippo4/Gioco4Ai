using System;

namespace LibreriaClassiGioco
{
    public class Personaggio
    {
        public string nome { get; private set; }
        public ushort vita { get; private set; }
        public ushort exp { get; private set; }
        private Razza razza { get; set; }
        public Personaggio(string n,Razza r)
        {
            vita = 100;
            nome = n;
            razza = r;
        }
        public ushort GetVita()
        {
            return vita;
        }
        public ushort Getexp()
        {
            return exp;
        }
        public Razza GetRazza()
        {
            return razza;
        }
        public string GetNome()
        {
            return nome;
        }
        public uint GetAtk()
        {
            return razza.GetAtk() * Getexp();
        }
        public uint GetDef()
        {
            return razza.GetDef() * Getexp();
        }
        public bool Attacca(Personaggio p1)
        {
            if (p1 == this)
            {
                throw new Exception("Non puoi auto attaccarti!");
            }
            if (razza.PuoiAttaccare(p1.GetRazza())==false)
            {
                throw new Exception("Che fai uccidi i compagni!");
            }
            uint attacco = GetAtk();
            uint difesa = p1.GetDef();
            if (attacco > difesa)
            {
                p1.vita--;
                if (exp < 10)
                    exp++;
                return true;
            }
            else
            {
                if (p1.exp < 10)
                    p1.exp++;
                return false;
            }
        }
    }
}
