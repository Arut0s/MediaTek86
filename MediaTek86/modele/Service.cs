using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier Service
    /// </summary>
    public class Service
    {
        int idservice { get; }
        string nom { get; }
        /// <summary>
        /// Constructeur de la classe Service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
    }
}
