using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier des motifs d'absence
    /// </summary>
    public class Motif
    {
        int idmotif { get; }
        string libelle { get;}
        /// <summary>
        /// Constructeur de la classe Motif
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }
    }
}
