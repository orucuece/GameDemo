using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { Id = 1, YearOfBirth = 1985, Name = "Engin", 
                Surname = "Demiroğ", IdentityNumber= 12345 });

        }
    }
}
