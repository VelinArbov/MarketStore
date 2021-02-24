using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Card
    {


        public Card(Owner owner, decimal turnover, decimal purchase, string cardType)
        {
            this.Owner = owner;
            this.Turnover = turnover;
            this.CardType = cardType;
            this.Purchase = purchase;

        }

        public Owner Owner { get; set; }

        public decimal Turnover { get; set; }

        public decimal Purchase { get; set; }

        public decimal InitialDiscount { get; set; }

        public string CardType { get; set; }

        public string PrintPurchase()
        {
            var discountInMoney = 0m;
            var currentDiscountPercent = GetDiscount();
            if (currentDiscountPercent != 0)
            {
               discountInMoney = (this.Purchase * currentDiscountPercent)/100;
            }
            var total = this.Purchase - discountInMoney;


            var sb = new StringBuilder();
            sb.AppendLine($"{this.CardType}");
            sb.AppendLine($"Purchase value: ${this.Purchase:f2}");
            sb.AppendLine($"Discount rate: {GetDiscount():f1}%");
            sb.AppendLine($"Discount: ${discountInMoney:f2}");
            sb.AppendLine($"Total: ${total:f2} ");
            return sb.ToString();
        }



        private decimal GetDiscount()
        {
            if (this.CardType == "Bronze")
            {
                if (this.Turnover < 100)
                {
                    return 0;
                }
                else if (this.Turnover >= 100 && this.Turnover <= 300)
                {
                    return 1;
                }
                else if (this.Turnover > 300)
                {
                    return 2.5m;
                }

            }
            else if (this.CardType == "Silver")
            {
                //The silver card comes with an initial discount rate of 2%. In case, the turnover is above $300, the rate is 3.5%.
                if (this.Turnover > 300)
                {
                    return 3.5m;
                }
                return 2;

            }

            else if (this.CardType == "Silver")
            {
                //The silver card comes with an initial discount rate of 2%. In case, the turnover is above $300, the rate is 3.5%.
                if (this.Turnover > 300)
                {
                    return 3.5m;
                }
                return 2;

            }
            else if (this.CardType == "Gold")
            {
                //he gold card comes with an initial discount rate of 2%. The discount rate grows 1% for each $100 from the turnover, capping at 10%.

                var rate = this.Turnover / 100;
                if (rate < 2)
                {
                    return 2;
                }
                if (rate >= 10)
                {
                    return 10;
                }
                return rate + 2;
            }

            return 0;

        }





    }
}
