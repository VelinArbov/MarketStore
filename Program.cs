using System;

namespace MarketStore
{
    class Program
    {
        public static void Main(string[] args)
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



            //Exceptions:
            //var wrongName = new Owner("", "Georgiev");
            //var goldWrongNameCard = new Card(wrongName, 300, 1300, "Gold");


            //var ownerNegative = new Owner("Vasil", "Georgiev");
            //var goldNegativeNumber = new Card(ownerNegative, -1, 1300, "Gold");

            //var owner4 = new Owner("Ivan", "Georgiev");
            //var invalidCard = new Card(owner4, 300, 1300, "Card");



        }
    }
}
