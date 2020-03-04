using System;
using System.Collections.Generic;
using System.Text;
using System.Device.Location;

namespace IacobEduard
{
    public abstract class Imobiliar
    {
        public int m_P;
        public int camere;
        public int etaj;
        public int basicPret = 0;

        private string[] locatie;
        public string[] GetLocatie() { return locatie; }
        public void SetLocatie(string[] value) { locatie = value; }

        
        public double getDistance(GeoCoordinate sCoord, GeoCoordinate eCoord) {
            return sCoord.GetDistanceTo(eCoord);
        }

        public double Calc_comision()
        {
            double comision = basicPret * 0.05;
            return comision;
        }

        public Imobiliar() { }
        public Imobiliar(int m_P, int camere, int etaj)
        {
            this.m_P = m_P;
            this.camere = camere;
            this.etaj = etaj;
        }
    }
}
