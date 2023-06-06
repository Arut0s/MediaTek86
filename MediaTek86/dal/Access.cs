using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.bddmanager;
using System.Windows.Forms;
using System.Configuration;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'acces a la BDD
    /// </summary>
    public class Access
    {
        /// <summary>
        /// nom de connexion à la bdd
        /// </summary>
        private static readonly string connectionString = "server=localhost;user id = responsable; password=P@$$word1;database=mediatek86;SslMode=none";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// Arrête le programme si l'accès à la BDD a échoué
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception e)
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

        
    }
}
