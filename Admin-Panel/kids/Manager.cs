using Admin_Panel.kids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel
{
    class Manager : Account
    {
        private Client _Client;
        public float Salary { get; set; }
        public Manager() : base()
        {
            Salary = 9999.5f;
        }
        public Manager(string login, string password, DateTime birthday, float salary) : base(login, password, birthday)
        {
            Salary = salary;
        }


        public string getHistory()
        {
            if (_Client != null)
            {
                return _Client.History;
            }
            else
            {
                Console.WriteLine("ClientNotFindedException");
            }
            return null;
        }
        public void addClient(Client client)
        {
            _Client = client;
        }
        public void sellProdut(Product product)
        {
            if (_Client != null)
            {
                _Client.buy(product);
            }
            else
            {
                Console.WriteLine("ClientNotFindedException");
            }
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Login, Password, DataTime.ToShortDateString(), Salary);
        }

    }
}
