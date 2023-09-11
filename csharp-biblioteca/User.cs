using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    /*
    Gli utenti si possono registrare al sistema, fornendo:
    cognome
    nome
    email
    password
    recapito telefonico
     */
    public class User
    {
        // private fields
        private string _surname;
        private string _name;
        private string _email;
        private string _password;
        private string _phoneNumber;

        // Properties
        public string Surname { get => this._surname; set => this._surname = value; }
        public string Name { get => this._name; set => this._name = value; } 
        public string Email { get => this._email; set => this._email = value; }
        public string Password { get => this._password; set => this._password = value; }
        public string PhoneNumber { get => this._phoneNumber; set => this._phoneNumber = value; }

        // constructor
        public User(string surname, string name, string email, string password, string phoneNumber)
        {
            this._surname = surname;
            this._name = name;
            this._email = email;
            this._password = password;
            this._phoneNumber = phoneNumber;          

        }








    }
}
