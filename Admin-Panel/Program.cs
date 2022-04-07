using Admin_Panel.kids;
using Admin_Panel.products;
using System;

namespace Admin_Panel
{
    class Program
    {
        static void Main(string[] args)
        {

//                      Debug using
//          0 - Nothing
//          1 - Admin add user to .txt
//          2 - Admin get users from .txt
//          3 - Admin Change login or password
//          4 - Manager add client ant sell him product (Entries: Bairaktar, Bed, Notebook, Sugar) + History


            int Debug = 0;




            Admin Vasya = new Admin("TopAdmin", "VeryHardPassword", new DateTime(2016, 10, 10));
            Manager user1 = new Manager("login1", "password1", new DateTime(1990, 3, 3), 100);
            Manager user2 = new Manager("login2", "password2", new DateTime(2010, 2, 5), 1080);
            Manager user3 = new Manager("login3", "password3", new DateTime(2015, 2, 3), 1000);
            Manager user4 = new Manager("login4", "password4", new DateTime(1980, 4, 3), 10350);
            Manager user5 = new Manager("login5", "password5", new DateTime(2000, 2, 3), 1005);
            Manager user6 = new Manager();

            switch (Debug)
            {
                case 1:
                    Vasya.addManager(user1);
                    Vasya.addManager(user2);
                    Vasya.addManager(user3);
                    Vasya.addManager(user4);
                    Vasya.addManager(user5);
                    Vasya.addManager(user6); 
                    break;
                case 2:
                    Manager[] mas1 = Vasya.getDataBase();
                    Console.WriteLine(mas1[0]);
                    Console.WriteLine(mas1[2]);
                    Console.WriteLine(mas1[4]);
                    break;
                case 3:
                    Vasya.changeLogin("login1", "login999");
                    Vasya.changePassword("login2", "f2=o)kp,^23dd;");
                    Manager[] mas2 = Vasya.getDataBase();
                    Console.WriteLine(mas2[0]);
                    Console.WriteLine(mas2[1]);
                    break;
                case 4:
                    Manager[] mas3 = Vasya.getDataBase();

                    Client noname = new Client("Krasavchik", "NeKrasavchik", new DateTime(2000, 10, 10, 10, 10, 10), 50000);
                    mas3[0].addClient(noname);

                    mas3[0].sellProdut(new Notebook());
                    mas3[0].sellProdut(new Bairaktar());
                    mas3[0].sellProdut(new Sugar());

                    Console.WriteLine();
                    Console.WriteLine(mas3[0].getHistory());
                    break;;
            }
            
            
                     

            
          
        }
    }
}
