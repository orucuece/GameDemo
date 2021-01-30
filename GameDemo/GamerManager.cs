using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    //mikro servis bambaşka bir servis kullanılacak.
    class GamerManager : IGamerService
    {
        // new'lemek yerine ctor kullanılır.
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)== true)
            {
                Console.WriteLine("Registered");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
 }

