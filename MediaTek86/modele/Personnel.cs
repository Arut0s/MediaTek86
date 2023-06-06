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
        public int idpersonnel { get; }
        public int idservice { get; }
        public string nom{get;}
        public string prenom { get; }
        public string tel { get; }
        public string mail { get; }

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

        public override string ToString()
        {
            return nom+" "+prenom+" ("+tel+") "+mail;
        }

    }
}
