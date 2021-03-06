﻿using System;
using System.Text;

namespace MarketStore
{
    public class Card
    {
      
        private  decimal _turnover;
        private  decimal _purchase;
        private  string _cardType;

        public Card(Owner owner, decimal turnover, decimal purchase, string cardType)
        {
            this.Owner = owner;
            this.Turnover = turnover;
            this.CardType = cardType;
            this.Purchase = purchase;

        }

        public Owner Owner { get; set; }

        public decimal Turnover
        {
            get => _turnover;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number cannot be less then 0");
                }

                _turnover = value;
            }
        }

        public decimal Purchase
        {
            get => _purchase;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number cannot be less then 0");
                }

                _purchase = value;
            }
        }

        public decimal InitialDiscount { get; set; }

        public string CardType
        {
            get => _cardType;
            set
            {
                if( value != "Gold" && value !="Silver" && value !="Bronze")
                {
                    throw new ArgumentException("Invalid card type");
                }
                _cardType = value;
            }
        }

        public string PrintPurchase()
        {
            var discountInMoney = 0m;
            var currentDiscountPercent = GetDiscount();
            if (currentDiscountPercent != 0)
            {
                discountInMoney = (this.Purchase * currentDiscountPercent) / 100;
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
               
                if (this.Turnover > 300)
                {
                    return 3.5m;
                }
                return 2;

            }

            else if (this.CardType == "Silver")
            {
             
                if (this.Turnover > 300)
                {
                    return 3.5m;
                }
                return 2;

            }
            else if (this.CardType == "Gold")
            {
               

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
