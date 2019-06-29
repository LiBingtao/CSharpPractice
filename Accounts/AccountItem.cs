using System;

namespace Account
{

    public class AccountItem
    {
        public string name;
        public Category category;
        public string content;
        public string note;
        public Money amount;
        public DateTime occuredTime;

        public AccountItem(string name, Category category, double amount):this(name, category, "None", "None", amount, DateTime.Now){}

        public AccountItem(string name, Category category, double amount, Currency currency):this(name, category, "None", "None", amount, currency, DateTime.Now){}
        
        public AccountItem(string name, Category category, double amount, DateTime occuredTime):this(name, category, "None", "None", amount, occuredTime){}

        public AccountItem(string name, Category category, double amount, Currency currency, DateTime occuredTime):this(name, category, "None", "None", amount, currency, occuredTime){}
        
        public AccountItem(string name, Category category, string content, double amount):this(name, category, content, "None", amount, DateTime.Now){}

        public AccountItem(string name, Category category, string content, double amount, Currency currency):this(name, category, content, "None", amount, currency, DateTime.Now){}
        
        public AccountItem(string name, Category category, string content, double amount, DateTime occuredTime):this(name, category, content, "None", amount, occuredTime){}

        public AccountItem(string name, Category category, string content, double amount, Currency currency, DateTime occuredTime):this(name, category, content, "None", amount, currency, occuredTime){}
        
        public AccountItem(string name, Category category, string content, string note, double amount, DateTime occuredTime){
            this.name = name;
            this.category = category;
            this.content = content;
            this.note = note;
            this.amount = new Money(amount);
            this.occuredTime = occuredTime;
        }

        public AccountItem(string name, Category category, string content, string note, double amount, Currency currency, DateTime occuredTime){
            this.name = name;
            this.category = category;
            this.content = content;
            this.note = note;
            this.amount = new Money(amount, currency);
            this.occuredTime = occuredTime;
        }

        public override string ToString(){
            return $"{name} Category:{category} Amount:{amount.value}{amount.currency.ToString()} Content:{content} Note:{note} Time:{occuredTime.ToString("MMMM dd,yy")}";
        }

        public static bool IsSpending(AccountItem account)
        {
            return account.category == Category.Spending;
        }

        public static bool IsIncome(AccountItem account)
        {
            return account.category == Category.Income;
        }

        public bool IsSameMonthOfSameYear(DateTime time)
        {
            return occuredTime.Month == time.Month && occuredTime.Year == time.Year;
        }
    }
}
