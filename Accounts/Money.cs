using System;

namespace Account
{

    public static class ExchangeRate
    {
        public static double USD2RMB = 6.9035;
        public static double EUR2RMB = 7.7271;
        public static double RMB2USD = 1/6.9035;
        public static double RMB2EUR = 1/7.7271;
    }

    public class Money
    {
        public double value;
        public Currency currency;

        public double Value{
            get{
                switch(this.currency){
                    case Currency.USD:
                        return this.value*ExchangeRate.RMB2USD;
                    case Currency.EUR:
                        return this.value*ExchangeRate.RMB2EUR;
                    default:
                        return this.value;
                }
            }
            set{
                switch(this.currency){
                    case Currency.USD:
                        this.value = value*ExchangeRate.USD2RMB;
                        break;
                    case Currency.EUR:
                        this.value = value*ExchangeRate.EUR2RMB;
                        break;
                    default:
                        this.value = value;
                        break;
                }
            }
        }

        public Money(double value):this(value,Currency.RMB){}

        public Money(double value, Currency currency){
            this.currency = currency;
            this.Value = value;
        }

        public static Money operator + (Money x, Money y){
            return new Money(x.value+y.value);
        }

        public static Money operator - (Money x, Money y){
            return new Money(x.value-y.value);
        }
    }
}