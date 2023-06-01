using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe pour se connecter en tant que responsable
    /// </summary>
    public class Responsable
    {
        string login { get; }
        string pwd { get; }
        /// <summary>
        /// Constructeur pour Responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
