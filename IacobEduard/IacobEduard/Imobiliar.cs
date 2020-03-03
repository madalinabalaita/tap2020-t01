using System;
using System.Collections.Generic;
using System.Text;

namespace IacobEduard
{
    public class Imobiliar
    {
        public int m_P;
        public int camere;
        public int etaj;
        public int basicPret = 0;

        private string[] locatie;
        public string[] GetLocatie() { return locatie; }
        public void SetLocatie(string[] value) { locatie = value; }

        public Imobiliar() { }
        public Imobiliar(int m_P, int camere, int etaj)
        {
            this.m_P = m_P;
            this.camere = camere;
            this.etaj = etaj;
        }
    }
}
