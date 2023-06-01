using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    ///<summary>
    ///classe métier pour du personnel
    ///</summary>
    public class Personnel
    {
        int idpersonnel { get; }
        int idservice { get; }
        string nom{get;}
        string prenom { get; }
        string tel { get; }
        string mail { get; }

        /// <summary>
        /// Constructeur de la classe Personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idpersonnel, int idservice, string nom, string prenom, string tel, string mail)
        {
            this.idpersonnel = idpersonnel;
            this.idservice = idservice;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }

    }
}
