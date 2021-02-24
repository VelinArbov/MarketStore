using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {

            var owner2 = new Owner("Georgi", "Georgiev");
            var bronzeCard = new Card(owner2, 301, 100, "Bronze");

            var owner1 = new Owner("Velin", "Arbov");
            var silverCard = new Card(owner1, 301, 850, "Silver");

            var owner3 = new Owner("Ivan", "Georgiev");
            var goldCard = new Card(owner3, 300, 1300, "Gold");

            Console.WriteLine(bronzeCard.PrintPurchase());
            Console.WriteLine(silverCard.PrintPurchase());
            Console.WriteLine(goldCard.PrintPurchase());

        }
    }
}
