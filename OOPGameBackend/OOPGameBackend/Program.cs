using System;

namespace OOPGameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id=1,IdentityNumber=12345678912,FirstName="Yunus",LastName="Köse",BirthYear=1997};
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            gamerManager1.Save(gamer1);

            GamerManager gamerManager2 = new GamerManager(new UserEDevletValidationManager());
            gamerManager2.Save(new Gamer {Id=2,IdentityNumber=12312312312,FirstName="Engin",LastName="Demiroğ",BirthYear=1989 });
        }
    }
}
