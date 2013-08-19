using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xEntry
{
    class coordonneespr
    {
        private string _idpr;

        public string Idpr
        {
            get { return _idpr; }
            set {
                if (value.Equals(""))
                {
                    throw new Exception("Le ID PR ne peut etre null");
                }
                if (value.Length > 25)
                {
                    throw new Exception("Le ID PR ne peut pas depasser 25 caracteres");
                }
                else
                {
                    _idpr = value;
                }
            }
        }

        private int _wptpr;

        public int Wptpr
        {
            get { return _wptpr; }
            set { _wptpr = value; }
        }

        private string _latitude;

        public string Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        private string _longitude;

        public string Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }

        private int _altitude;

        public int Altitude
        {
            get { return _altitude; }
            set { _altitude = value; }
        }

        private int _epepr;

        public int Epepr
        {
            get { return _epepr; }
            set { _epepr = value; }
        }

    }
}
