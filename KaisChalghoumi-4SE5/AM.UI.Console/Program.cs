//// See https://aka.ms/new-console-template for more information
////declaration variable
//string ch;
////type: string, int, char, double, float, bool, DateTime, long, ...

//for(int i = 0; i < 1 ; i++)
//{
//    Console.WriteLine(" votre nom ? ");
//    ch = Console.ReadLine();
//    Console.WriteLine("Bonjour " + ch);

//    int chiffreValue = 0;
//    while (chiffreValue == 0)
//    {
//        try
//        {
//            Console.WriteLine(" donner un chiffre ");
//            string chiffre = Console.ReadLine();
//            chiffreValue = int.Parse(chiffre);
//            if (chiffreValue > 15 && chiffreValue <= 18)
//            {
//                Console.WriteLine("Ados");
//            }else if(chiffreValue > 18)
//            {
//                Console.WriteLine("Adultes");
//            }
//        }
//        catch
//        {
//            Console.WriteLine("erreur conversion");
//        }
//    }
//    Console.WriteLine(" nv nombre est " + (chiffreValue + 1));
//}

using AM.ApplicationCore.Domain;
using System.Numerics;
using Plane = AM.ApplicationCore.Domain.Plane;

Personne p = new Personne() ;

p.Id = 11 ;
p.Prenom = "kais";
p.Nom = "chalghoumi";
p.DateNaissance = new DateTime(2000, 12, 25);
p.Mail = "kais.chalghoumi@esprit.tn";
p.Password = "0000";
p.ConfirmPassword = "0000";

Console.WriteLine(p);

Personne p1 = new Personne("prenom", "nom", DateTime.Now, "mail", "password", "confirmPassword");

Console.WriteLine(p1);

Personne p2 = new Personne() //initialisateur d objet mayhemech l'ordre
{
    Mail = "mail",
    Nom = "nom",
    DateNaissance = new DateTime(),
    Prenom = "prenom",
    Password = "password",
    ConfirmPassword = "password"
};

Conducteur c = new Conducteur();
p.GetMyType();
c.GetMyType();


//////// ** Partie 1: Les principes de l’orienté objet ** ///////////////////////

Plane plane1 = new Plane();

plane1.Capacity = 100;
plane1.ManufactureDate = new DateTime();
plane1.PlaneId = 1;
plane1.PlaneType = PlaneType.Boing;


Plane plane2 = new Plane(PlaneType.Airbus,100, new DateTime(2023 - 02 - 05));

Plane plane3 = new Plane
{
    Capacity = 100,
    PlaneType = PlaneType.Airbus,
    ManufactureDate = new DateTime()
};



