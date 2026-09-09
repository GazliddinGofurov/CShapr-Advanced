using System;
using System.Reflection.Metadata;

namespace _BankTransAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Card sender =  new Card();
            sender.Balance = 100;
            sender.type = CardType.UZCARD;

            Card receiver = new Card();
            receiver.Balance = 50;
            receiver.type = CardType.UNIONPAY;

            try
            {
                Transfer(sender,receiver,20);
                Console.WriteLine($"Sender Balance - {sender.Balance}");
                Console.WriteLine($"Receiver Balance - {receiver.Balance}");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            




            
        }

        static void Transfer(Card Sender, Card Receiver, decimal Amount)
        {
            bool isSenderSom = Sender.type == CardType.UZCARD || Sender.type == CardType.HUMO;
            bool isReceiverSom = Receiver.type == CardType.UZCARD || Receiver.type == CardType.HUMO;

            if(isSenderSom!= isReceiverSom)
            {
                throw new CardTypeNotMatchException("Sizning tanglgan karta qabul qiluchi bilan mutanosib emas!");
            }
            else
            {
                Sender.Balance-=Amount;
                Receiver.Balance+=Amount;
                Console.WriteLine($"from Sender: -{Amount}so'm");
                Console.WriteLine($"To receiver: +{Amount}so'm");

            }
            
        }
    }
}