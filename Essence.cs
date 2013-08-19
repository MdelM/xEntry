using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xEntry
{
    public class Essence
    {
        private string _id_essence;
        private string _libessence;

        public string Id_essence
        {
            get { return _id_essence; }
            set {
                if (value.ToString().Equals("") || value.ToCharArray().Length > 10)
                    throw new Exception("Pas des valeurs nulles ou valeur supérieures /n a 10 dans la zone Id essence !");
                _id_essence = value; }
        }
       
        public string Libessence
        {
            get { return _libessence; }
            set {
                if (value.ToString().Equals("")) throw new Exception("Pas des valeurs nulles autorisées dans la zone /n libellé essence");
                _libessence = value; }
        }
    }
}
