using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager needs a validation service as parameter.
            GamerManager gamerManager = new GamerManager(new AnotherValidationManager());
            gamerManager.Add(new Gamer 
            { Id = 1, YearOfBirth = 1994, Name = "ECE", 
                Surname = "ÖRÜCÜ", IdentityNumber= 00000 });

            Console.WriteLine("/////////////Order Test//////////");

            OrderManager orderManager = new OrderManager(new CampaignManager());
            Order order = new Order {OrderPrice= 50};

            orderManager.GetOrder(order);
        }
    }
}
