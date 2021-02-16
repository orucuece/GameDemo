using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    //mikro servis bambaşka bir servis kullanılacak.
    class GamerManager : IGamerService
    {
        // if you use another manager class in your class, you shouldn't do "new" Instead of you can use ctor.
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)== true)
            {
                Console.WriteLine("Gamer is registered");
            }
            else
            {
                Console.WriteLine("Invalid adding");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }
    }
 }

