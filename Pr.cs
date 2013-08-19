using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xEntry
{
    class Pr
    {
        private int _idpr;
        public int idpr
        {
            get{return _idpr;}
            set{
                if(value.ToString().Equals(""))
                {
                    throw new Exception("Valeur non null autorisees !");
                }
                _idpr = value;
            }
        }

        private string _id_pr;

        public string Id_pr
        {
            get { return _id_pr; }
            set {
                if (value.ToString().Equals(""))
                {
                    throw new Exception("Le Id n'accepte pas des valeurs nulles.");
                }
                if (value.Length > 25)
                {
                    throw new Exception("Le Id ne peut avoir une longueur excedant 25 caracteres.");
                }
                _id_pr = value; 
                }
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
        private string _id_tar;

        public string Id_tar
        {
            get { return _id_tar; }
            set {
                if (value.ToString().Equals(""))
                {
                    throw new Exception("Le Id TAR n'accepte pas des valeurs nulles.");
                }
                if (value.Length > 25)
                {
                    throw new Exception("Le Id TAR ne peut avoir une longueur excedant 25 caracteres.");
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
                    throw new Exception("Le Id ne peut avoir une longueur excedant 6 caracteres.");
                }
                _id_season = value; 
                }
        }
        private string _id_asso;

        public string Id_asso
        {
            get { return _id_asso; }
            set {
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
        private string _essenceprincipale;

        public string Essenceprincipale
        {
            get { return _essenceprincipale; }
            set { _essenceprincipale = value; }
        }
        private string _melanges;

        public string Melanges
        {
            get { return _melanges; }
            set { _melanges = value; }
        }
        private string _essence1;

        public string Essence1
        {
            get { return _essence1; }
            set { _essence1 = value; }
        }
        private int _pieds1;

        public int Pieds1
        {
            get { return _pieds1; }
            set { _pieds1 = value; }
        }
        private string _essence2;

        public string Essence2
        {
            get { return _essence2; }
            set { _essence2 = value; }
        }
        private int _pieds2;

        public int Pieds2
        {
            get { return _pieds2; }
            set { _pieds2 = value; }
        }
        private double _pente1;

        public double Pente1
        {
            get { return _pente1; }
            set { _pente1 = value; }
        }
        private double _pente2;

        public double Pente2
        {
            get { return _pente2; }
            set { _pente2 = value; }
        }
        private double _pente3;

        public double Pente3
        {
            get { return _pente3; }
            set { _pente3 = value; }
        }
        private double _pente4;

        public double Pente4
        {
            get { return _pente4; }
            set { _pente4 = value; }
        }
        private double _superficieRealise;

        public double SuperficieRealise
        {
            get { return _superficieRealise; }
            set { _superficieRealise = value; }
        }
        private double _superficieNonPlante;

        public double SuperficieNonPlante
        {
            get { return _superficieNonPlante; }
            set { _superficieNonPlante = value; }
        }
        private string _ecartementtype;

        public string Ecartementtype
        {
            get { return _ecartementtype; }
            set { _ecartementtype = value; }
        }
        private string _ecartement;

        public string Ecartement
        {
            get { return _ecartement; }
            set { _ecartement = value; }
        }
        private string _alignement;

        public string Alignement
        {
            get { return _alignement; }
            set { _alignement = value; }
        }
        private string _causes;

        public string Causes
        {
            get { return _causes; }
            set { _causes = value; }
        }
        private string _piquets;

        public string Piquets
        {
            get { return _piquets; }
            set { _piquets = value; }
        }
        private double _pourcentagepiquet;

        public double Pourcentagepiquet
        {
            get { return _pourcentagepiquet; }
            set { _pourcentagepiquet = value; }
        }
        private string _eucalyptuscoursdeau;

        public string Eucalyptuscoursdeau
        {
            get { return _eucalyptuscoursdeau; }
            set { _eucalyptuscoursdeau = value; }
        }
        private string _regarnissage;

        public string Regarnissage
        {
            get { return _regarnissage; }
            set { _regarnissage = value; }
        }
        private double _pourcentageregarni;

        public double Pourcentageregarni
        {
            get { return _pourcentageregarni; }
            set { _pourcentageregarni = value; }
        }
        private double _haut1;

        public double Haut1
        {
            get { return _haut1; }
            set { _haut1 = value; }
        }
        private double _haut2;

        public double Haut2
        {
            get { return _haut2; }
            set { _haut2 = value; }
        }
        private double _haut3;

        public double Haut3
        {
            get { return _haut3; }
            set { _haut3 = value; }
        }
        private double _haut4;

        public double Haut4
        {
            get { return _haut4; }
            set { _haut4 = value; }
        }
        private string _canopees;

        public string Canopees
        {
            get { return _canopees; }
            set { _canopees = value; }
        }
        private double _canopeespourcent;

        public double Canopeespourcent
        {
            get { return _canopeespourcent; }
            set { _canopeespourcent = value; }
        }
        private string _presenceplanteur;

        public string Presenceplanteur
        {
            get { return _presenceplanteur; }
            set { _presenceplanteur = value; }
        }
        private string _entretien;

        public string Entretien
        {
            get { return _entretien; }
            set { _entretien = value; }
        }
        private string _etatplantation;

        public string Etatplantation
        {
            get { return _etatplantation; }
            set { _etatplantation = value; }
        }
        private string _presenceculture;

        public string Presenceculture
        {
            get { return _presenceculture; }
            set { _presenceculture = value; }
        }
        private string _typeculture;

        public string Typeculture
        {
            get { return _typeculture; }
            set { _typeculture = value; }
        }
        private double _degats;

        public double Degats
        {
            get { return _degats; }
            set { _degats = value; }
        }

        private string _TypeDegats;
        public string TypeDegats
        {
            get { return _TypeDegats; }
            set { _TypeDegats = value; }
        }

        private string _croissancearbre;

        public string Croissancearbre
        {
            get { return _croissancearbre; }
            set { _croissancearbre = value; }
        }
        private int _numerophoto;

        public int Numerophoto
        {
            get { return _numerophoto; }
            set { _numerophoto = value; }
        }
        private string _azimut;

        public string Azimut
        {
            get { return _azimut; }
            set { _azimut = value; }
        }
        private string _latitudepr;

        public string Latitudepr
        {
            get { return _latitudepr; }
            set { _latitudepr = value; }
        }
        private string _longitude;

        public string Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        private bool _planteurcopie;

        public bool Planteurcopie
        {
            get { return _planteurcopie; }
            set { _planteurcopie = value; }
        }
        private string _commentairewwf;

        public string Commentairewwf
        {
            get { return _commentairewwf; }
            set { _commentairewwf = value; }
        }
        private string _commentaireplanteur;

        public string Commentaireplanteur
        {
            get { return _commentaireplanteur; }
            set { _commentaireplanteur = value; }
        }
        private string _commentaireasso;

        public string Commentaireasso
        {
            get { return _commentaireasso; }
            set { _commentaireasso = value; }
        }

        #region Verifie_Le_Status_des_checkbox
        public Boolean _Checkboxpr(CheckBox z)
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

        #region Numero_de_la_PR
        public String NumeroDeLaPR(string Assoc, string lasaison, int chiffre)
        {
            string nc = "PR/" + Assoc + "/" + lasaison + "/" + chiffre.ToString();
            return nc;
        }
        #endregion

        public string ValueOnSelectedCheckbox(TextBox t, CheckBox c)
        {
            string y="";

            if (t.Text.Equals(""))
            {
                y =(string) c.Text;    
            }
            if (!t.Text.Equals(""))
            {
                 y =(string) t.Text + "," + c.Text;
            }

            return y;
        }
    }
}
