using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel.kids
{
    class Client : Account
    {
        public string History { get; private set; }
        public float Money { get; set; }
        public Client() : base()
        {
            Money = 10000f;
        }
        public Client(string login, string password, DateTime birthday, float money) : base(login, password, birthday)
        {
            Money = money;
        }

        //Buy product from shop. Entries: product
        public void buy(Product product)
        {
            Console.WriteLine($"Вы уверены что хотите купить {product.Name.ToLower()}?");
            Console.WriteLine("Для подтверждения напишите \"Confirm\"");
            string chose = Console.ReadLine();

            if (chose == "Confirm")
            {
                if (Money >= product.Cost)
                {
                    Console.WriteLine($"Покупка {product.Name.ToLower()} совершена успешно\n");
                    History += $"Покупка {product.Name.ToLower()} совершена успешно\n";
                }
                else
                {
                    Console.WriteLine($"Покупка {product.Name.ToLower()} не удалась");
                    Console.WriteLine(String.Format("Пополните баланс для покупки данного продукта {0}/{1} \n", Money, product.Cost));

                    History += $"Покупка {product.Name.ToLower()} не удалась (Недостаточно средств)\n";
                }
            }
            else
            {
                Console.WriteLine($"Покупка {product.Name.ToLower()} успешно отменена\n");
                //нет смысла это логировать но если нам нужный полный контроль нужно раскоментить нижнюю строку
                //History += $"Покупка {product.Name.ToLower()} не удалась (Отказ от покупки)\n";
            }
        }


        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Login, Password, DataTime.ToShortDateString(), Money);
        }

    }
}
