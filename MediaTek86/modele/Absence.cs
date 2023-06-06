using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier des abscences
    /// </summary>
    public class Absence
    {
        int idpersonnel { get; }
        DateTime datedebut { get; }
        int idmotif { get; }
        DateTime datefin { get; }
        /// <summary>
        /// Constructeur de la classe Absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="idmotif"></param>
        /// <param name="datefin"></param>
        public Absence(int idpersonnel, DateTime datedebut, int idmotif, DateTime datefin)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.idmotif = idmotif;
            this.datefin = datefin;
        }
    }
}
