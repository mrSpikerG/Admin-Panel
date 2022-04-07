using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel
{
    class Admin : Account
    {


        public Admin() : base()
        {
            
        }
        public Admin(string login, string password, DateTime birthday) : base(login, password, birthday) {
           
        }


        //Add manager to database. Entries: manager
        public void addManager(Manager newMember)
        {
            File.AppendAllText(Login + ".txt", String.Format("{0} {1} {2} {3} \n", newMember.Login, newMember.Password, newMember.DataTime.ToShortDateString(), newMember.Salary));
        }

        //Get massive of all managers
        public Manager[] getDataBase()
        {
            string text = File.ReadAllText(Login + ".txt");
            string[] textArr = text.Split("\n");

            Manager[] mas = new Manager[textArr.Length - 1];
            for (int i = 0; i < textArr.Length - 1; i++)
            {
                string[] userInfo = textArr[i].Split();
                /*  Console.WriteLine(userInfo[0]);
                  Console.WriteLine(userInfo[1]);
                  Console.WriteLine(userInfo[2]);
                  Console.WriteLine(userInfo[3]);*/
                string[] date = userInfo[2].Split(".");
                DateTime time = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                mas[i] = new Manager(userInfo[0], userInfo[1], time, float.Parse(userInfo[3]));

            }
            return mas;
        }


        //Can change Manager's login. Entries: old login, new login
        public void changeLogin(string oldLogin, string newLogin)
        {
            Manager[] mas = getDataBase();
            int id;
            for (int i = 0; i < mas.Length; i++) {
                if (mas[i].Login == oldLogin)
                {
                    mas[i].Login = newLogin;
                    break;
                }
            }

            //Clear file 
            File.WriteAllText(Login + ".txt", "");

            //Add managers to database (bad realisation for big company :( )
            for (int i = 0; i < mas.Length; i++)
            {
                File.AppendAllText(Login + ".txt", String.Format("{0} {1} {2} {3} \n", mas[i].Login, mas[i].Password, mas[i].DataTime.ToShortDateString(), mas[i].Salary));
            }
        }

        //Can change Manager's password. Entries: login, new password
        public void changePassword(string login, string password)
        {

            Manager[] mas = getDataBase();
            int id;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Login == login)
                {
                    mas[i].Password = password;
                    break;
                }
            }
            //Clear file 
            File.WriteAllText(Login + ".txt", "");

            //Add managers to database (bad realisation for big company :( )
            for (int i = 0; i < mas.Length; i++)
            {
                File.AppendAllText(Login + ".txt", String.Format("{0} {1} {2} {3} \n", mas[i].Login, mas[i].Password, mas[i].DataTime.ToShortDateString(), mas[i].Salary));
            }
        }
    }
}
