using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManagement
{


    public class Cardholder
    {
        string cardnum;
        int pin;
        string firstname;
        string lastname;
        int balance;

        public Cardholder(string cardnum, int pin, string firstname, string lastname, int balance)
        {
            this.cardnum = cardnum;
            this.pin = pin;
            this.firstname = firstname;
            this.lastname = lastname;
            this.balance = balance;
        }


        public string Cardnum
        {
            get => cardnum;
            set => cardnum = value;
        }

        public int Pin
        {
            get => pin;
            set => pin = value;
        }
        public string Firsname
        {
            get { return firstname; }
            set => firstname = value;
        }
        public string Lastname { get => lastname; set => lastname = value; }

        public int Balance { get => balance; set => balance = value; }


    }

    
}
