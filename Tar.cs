using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xEntry
{
    class Tar
    {
        private string _id_tar;

        public string Id_tar
        {
            get { return _id_tar; }
            set {
                if (value.ToString().Equals(""))
                {
                    throw new Exception("Le Id n'accepte pas des valeurs nulles.");
                }
                if (value.Length>25)
                {
                    throw new Exception("Le Id ne peut avoir une longueur excedant 25 caracteres.");
                }

                _id_tar = value; 
            }
        }
        private string _id_season;

        public string Id_season
        {
            get { return _id_season; }
            set {
                if (value.ToString().Equals(""))
                {
                    throw new Exception("Le Id n'accepte pas des valeurs nulles.");
                }
                if (value.Length > 6)
                {
                    throw new Exception("Le Id ne peut avoir une longueur excedant 25 caracteres.");
                }

                _id_season = value; 
                }
        }
        private string _id_asso;

        public string Id_asso
        {
            get { return _id_asso; }
            set
            {
                if (value.ToString().Equals(""))
                {
                    throw new Exception("Le Id n'accepte pas des valeurs nulles.");
                }
                if (value.Length > 25)
                {
                    throw new Exception("Le Id ne peut avoir une longueur excedant 25 caracteres.");
                }

                _id_asso = value;
            }
        }
        private string _numerocontrat;

        public string Numerocontrat
        {
            get { return _numerocontrat; }
            set {
                if (value.ToString().Equals(""))
                {
                    throw new Exception("Le numero de contrat n'accepte pas des valeurs nulles.");
                }
                if (value.Length > 25)
                {
                    throw new Exception("Le numero de contrat ne peut avoir une longueur excedant 25 caracteres.");
                }

                _numerocontrat = value; }
        }
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        private string _lieu_plant;

        public string Lieu_plant
        {
            get { return _lieu_plant; }
            set { _lieu_plant = value; }
        }
        private string _village;

        public string Village
        {
            get { return _village; }
            set { _village = value; }
        }
        private string _localite;

        public string Localite
        {
            get { return _localite; }
            set { _localite = value; }
        }
        private string _groupement;

        public string Groupement
        {
            get { return _groupement; }
            set { _groupement = value; }
        }
        private string _chefferie;

        public string Chefferie
        {
            get { return _chefferie; }
            set { _chefferie = value; }
        }
        private string _territoire;

        public string Territoire
        {
            get { return _territoire; }
            set { _territoire = value; }
        }
        private int _wpttar;

        public int Wpttar
        {
            get { return _wpttar; }
            set { _wpttar = value; }
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
        private int _epetar;

        public int Epetar
        {
            get { return _epetar; }
            set { _epetar = value; }
        }
        private int _nphoto;

        public int Nphoto
        {
            get { return _nphoto; }
            set { _nphoto = value; }
        }
        private string _azimut;

        public string Azimut
        {
            get { return _azimut; }
            set { _azimut = value; }
        }
        private string _latitude_ph;

        public string Latitude_ph
        {
            get { return _latitude_ph; }
            set { _latitude_ph = value; }
        }
        private string _longitude_ph;

        public string Longitude_ph
        {
            get { return _longitude_ph; }
            set { _longitude_ph = value; }
        }
        private string _id_agent;

        public string Id_agent
        {
            get { return _id_agent; }
            set {

                if (value.ToString().Equals(""))
                {
                    throw new Exception("Le Id n'accepte pas des valeurs nulles.");
                }
                if (value.Length > 6)
                {
                    throw new Exception("Le Id ne peut avoir une longueur excedant 6 caracteres.");
                }

                _id_agent = value; 
                }
        }
        private double _superficie;

        public double Superficie
        {
            get { return _superficie; }
            set { _superficie = value; }
        }
        private string _objectifs;

        public string Objectifs
        {
            get { return _objectifs; }
            set { _objectifs = value; }
        }
        private bool _chefdelocalite;

        public bool Chefdelocalite
        {
            get { return _chefdelocalite; }
            set { _chefdelocalite = value; }
        }
        private string _nomchefdelocalite;

        public string Nomchefdelocalite
        {
            get { return _nomchefdelocalite; }
            set { _nomchefdelocalite = value; }
        }
        private string _fonction;

        public string Fonction
        {
            get { return _fonction; }
            set { _fonction = value; }
        }
        private bool _documentdepropriete;

        public bool Documentdepropriete
        {
            get { return _documentdepropriete; }
            set { _documentdepropriete = value; }
        }
        private string _typedocument;

        public string Typedocument
        {
            get { return _typedocument; }
            set { _typedocument = value; }
        }
        private string _utilisationprecedente;

        public string Utilisationprecedente
        {
            get { return _utilisationprecedente; }
            set { _utilisationprecedente = value; }
        }
        private bool _arbreexistant;

        public bool Arbreexistant
        {
            get { return _arbreexistant; }
            set { _arbreexistant = value; }
        }
        private int _nombrearbre;

        public int Nombrearbre
        {
            get { return _nombrearbre; }
            set {_nombrearbre = value; }
        }
        private string _situation;

        public string Situation
        {
            get { return _situation; }
            set { _situation = value; }
        }
        private string _pente;

        public string Pente
        {
            get { return _pente; }
            set { _pente = value; }
        }
        private string _sol;

        public string Sol
        {
            get { return _sol; }
            set { _sol = value; }
        }
        private double _superficiebloc1;

        public double Superficiebloc1
        {
            get { return _superficiebloc1; }
            set { _superficiebloc1 = value; }
        }
        private double _superficiebloc2;

        public double Superficiebloc2
        {
            get { return _superficiebloc2; }
            set { _superficiebloc2 = value; }
        }
        private double _superficiebloc3;

        public double Superficiebloc3
        {
            get { return _superficiebloc3; }
            set { _superficiebloc3 = value; }
        }
        private string _essencebloc1;

        public string Essencebloc1
        {
            get { return _essencebloc1; }
            set { _essencebloc1 = value; }
        }
        private string _essencebloc2;

        public string Essencebloc2
        {
            get { return _essencebloc2; }
            set { _essencebloc2 = value; }
        }
        private string _essencebloc3;

        public string Essencebloc3
        {
            get { return _essencebloc3; }
            set { _essencebloc3 = value; }
        }
        private string _ecartement1;

        public string Ecartement1
        {
            get { return _ecartement1; }
            set { _ecartement1 = value; }
        }
        private string _ecartement2;

        public string Ecartement2
        {
            get { return _ecartement2; }
            set { _ecartement2 = value; }
        }
        private string _ecartement3;

        public string Ecartement3
        {
            get { return _ecartement3; }
            set { _ecartement3 = value; }
        }

        private int _Idt;
        public int Idt
        {
            get { return _Idt; }
            set
            {
                if (value.ToString().Equals("") || value.ToString().Equals(0))
                {
                    throw new Exception("La valeur ne peut etre null ou egal a Zero");
                }
                _Idt = value;
            }
        }

        private string _idSaisonAsso;
        public string idSaisonAsso
        {
            get { return _idSaisonAsso; }
            set
            {
                if (value.ToString().Equals(""))
                {
                    throw new Exception("Could not have empty value");
                }
                _idSaisonAsso = value;
            }
        }

        #region Verifie_Le_Status_des_checkbox
        public Boolean _CheckboxStatus (CheckBox z)
        {
            if (z.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        #endregion

        public String NumeroContratTAR(string Assoc, string lasaison, int chiffre)
        {
            string nc = Assoc + "/" + lasaison + "/" + chiffre.ToString(); 
            return nc;

        }
        public String NumeroIdTAR(string Assoc, string lasaison, int chiffre)
        {
            string ni = "TAR/" + Assoc + "/" + lasaison + "/" + chiffre.ToString();
            return ni;

        }

    }
}
