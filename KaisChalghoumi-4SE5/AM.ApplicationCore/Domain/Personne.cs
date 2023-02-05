using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {

        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Id { get; set; }


        public Personne() { 

        }

        public Personne(string prenom, string nom, DateTime dateNaissance, string mail, string password, string confirmPassword)
        {
            Prenom = prenom;
            Nom = nom;
            DateNaissance = dateNaissance;
            Mail = mail;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        //surcharge des methodes
        public bool Login(string nom, string password)
        {
            //var result = nom == Nom && password == Password ? true : false;

            //if(nom == Nom && password == Password)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;   
            //}

            return nom == Nom && password == Password;
        }
        public bool Login(string nom, string password, string mail)
        {
            return nom == Nom && password == Password && mail == Mail;
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("je suis personne");
        }

        public override string ToString()
        {
            return Id+ " " + Prenom + " " + Nom + " " + Mail;
        }
    }
}
