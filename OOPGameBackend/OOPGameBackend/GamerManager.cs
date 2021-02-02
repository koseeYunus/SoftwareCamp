using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGameBackend
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        List<Gamer> gamers=new List<Gamer>();
        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                foreach (var item in gamers)
                {
                    if (item.UserName==gamer.UserName && item.Password==item.Password)
                    {
                        gamers.Remove(item);
                        Console.WriteLine("Kullanıcı silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Kulanıcı adı veya şifre yanlış girildi.");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Silinemedi user validation service hatalı.");
            }
            
        }

        public void Save(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kullanıcı kaydedildi.");
            }
            else
            {
                Console.WriteLine("Kaydedilemedi user validation service hatalı.");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kullanıcı güncellendi.");
            }
            else
            {
                Console.WriteLine("Güncellenemedi user validation service hatalı.");
            }
        }
    }
}
