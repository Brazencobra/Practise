using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practise.Models
{
    internal class User
    {
        private string _userName;
        private string _password;
        private bool _isSignedIn = false;
        private Product[] Products = new Product[0];

        public string UserName 
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Trim().Length >= 6 && value.Trim().Length <= 25 ) 
                {
                    _userName = value;
                }
            } 
        }
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Trim().Length >= 8 && value.Trim().Length <= 25 && CheckPassword(value) == true)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("nagaysan ay qaa"); 
                }
            } 
        }
        public bool IsSignedIn 
        {
            get
            {
                return _isSignedIn;
            }
            set
            {
                _isSignedIn = value;
            }
        }

        public User(string username,string password)
        {
            UserName = username;
            Password = password;
        }

        public bool CheckPassword(string text)
        {
            if (HasDigit(ref text) == true && HasUpper(text) == true && HasLower(text) == true) 
            {
                return true;
            }
            return false;
        }
        public bool HasDigit(ref string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void Login(string username,string password)
        {
            if (username == UserName && password == Password)
            {
                IsSignedIn = true;
                return;
            }
            IsSignedIn = false;
        }
        public void Add(Product product)
        {
            startLabel:
            if (IsSignedIn == true)
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = product;
                Console.WriteLine("Mehsul elave edildi");
                return;
            }
            else
            {
                bool condition = true;
                while (condition == true) 
                {
                    Console.WriteLine("Siz hesabiniza daxil olmamisiniz zehmet olmasa teleb olunan parametrleri daxil edin");
                    Console.Write("Adi daxil edin : ");
                    string username1 = Console.ReadLine();
                    Console.Write("Parolu daxil edin : ");
                    string password1 = Console.ReadLine();
                    if (username1 == UserName && password1 == Password)
                    {
                        Login(username1, password1);
                        Console.WriteLine("Hesaba ugurla daxil olundu");
                        goto startLabel;
                    }
                }
            }
        }

    }
}
