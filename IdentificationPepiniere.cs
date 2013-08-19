using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xEntry
{
    class IdentificationPepiniere
    {

        private String _idPepiniere;

        public String IdPepiniere
        {
            get { return _idPepiniere; }
            set { _idPepiniere = value; }
        }
        private String _idagent;

        public String Idagent
        {
            get { return _idagent; }
            set { _idagent = value; }
        }
        private String _idasso;

        public String Idasso
        {
            get { return _idasso; }
            set { _idasso = value; }
        }
        private String _nomsite;

        public String Nomsite
        {
            get { return _nomsite; }
            set { _nomsite = value; }
        }
        private int _idv;

        public int Idv
        {
            get { return _idv; }
            set { _idv = value; }
        }
        private int _idl;

        public int Idl
        {
            get { return _idl; }
            set { _idl = value; }
        }
        private int _idg;

        public int Idg
        {
            get { return _idg; }
            set { _idg = value; }
        }
        private int _idc;

        public int Idc
        {
            get { return _idc; }
            set { _idc = value; }
        }
        private int _idt;

        public int Idt
        {
            get { return _idt; }
            set { _idt = value; }
        }
        private double _latitude;

        public double Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        private double _longitude;

        public double Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        private double _altitude;

        public double Altitude
        {
            get { return _altitude; }
            set { _altitude = value; }
        }
        private int _mEpe;

        public int MEpe
        {
            get { return _mEpe; }
            set { _mEpe = value; }
        }
        private String dimensions_planches;

        public String Dimensions_planches
        {
            get { return dimensions_planches; }
            set { dimensions_planches = value; }
        }
        private int nbre_planches_total;

        public int Nbre_planches_total
        {
            get { return nbre_planches_total; }
            set { nbre_planches_total = value; }
        }
        private double capacite_totale_planches;

        public double Capacite_totale_planches
        {
            get { return capacite_totale_planches; }
            set { capacite_totale_planches = value; }
        }
        private double production_pepi;

        public double Production_pepi
        {
            get { return production_pepi; }
            set { production_pepi = value; }
        }
        private double surface_total_pepi;

        public double Surface_total_pepi
        {
            get { return surface_total_pepi; }
            set { surface_total_pepi = value; }
        }
        private DateTime date_installation;

        public DateTime Date_installation
        {
            get { return date_installation; }
            set { date_installation = value; }
        }
        private int nume_photo;

        public int Nume_photo
        {
            get { return nume_photo; }
            set { nume_photo = value; }
        }
        private String azimut;

        public String Azimut
        {
            get { return azimut; }
            set { azimut = value; }
        }
        private String lat_photo;

        public String Lat_photo
        {
            get { return lat_photo; }
            set { lat_photo = value; }
        }
        private double long_photo;

        public double Long_photo
        {
            get { return long_photo; }
            set { long_photo = value; }
        }
        private int nbre_Pepinieriste;

        public int Nbre_Pepinieriste
        {
            get { return nbre_Pepinieriste; }
            set { nbre_Pepinieriste = value; }
        }
        private int nbre_formes_wwf;

        public int Nbre_formes_wwf
        {
            get { return nbre_formes_wwf; }
            set { nbre_formes_wwf = value; }
        }
        private bool paye;

        public bool Paye
        {
            get { return paye; }
            set { paye = value; }
        }
        private bool contrat;

        public bool Contrat
        {
            get { return contrat; }
            set { contrat = value; }
        }


    }
}
