using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace app_xEntry
{
    public class Factory
    {
        private SqlConnection dbConnexion;
        //Creation du constructeur pour la factory
        private Factory()
        {
            //Rien
        }
        //Creation de l'instance de la Factory
        private static Factory _fact;
        public static Factory Instance
        {
            get
            {
                if (_fact == null) _fact = new Factory();
                return _fact;
            }
        }

        //Initialisation de la chaine de connexion
        public void Initialise(string chaineDeConnexion)
        {
            dbConnexion = new SqlConnection(chaineDeConnexion);
        }
        /*
         cette methode setParameter renvoie a faire ceci :
         sqlcmd.parameter.add("champ de reference",Type des donnes sql.Taille,"valeur du parametre" etc... _
         
          */
        private void setParameter(string nomParametre, DbType typeParametre,
            object valeurParametre, int tailleParametre, SqlCommand sqlcmd)
        {

            SqlParameter p = new SqlParameter();
            if (valeurParametre == null)
                p.Value = DBNull.Value;
            else
                p.Value = valeurParametre;

                p.ParameterName = nomParametre;
                p.Size = tailleParametre;
                p.DbType = typeParametre;

                sqlcmd.Parameters.Add(p);
        }



    }
}
