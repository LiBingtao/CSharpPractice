using System;
using Account;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Accounts();
            var accountsItem1 = new AccountItem("买菜",Category.Spending,10);
            var accountsItem2 = new AccountItem("买鸡胸",Category.Spending,20, new DateTime(2019,6,1));
            var accountsItem3 = new AccountItem("美国买菜",Category.Spending,10, Currency.USD);
            var accountsItem4 = new AccountItem("美国买鸡胸",Category.Spending,20, Currency.USD, new DateTime(2019,6,2));
            var accountsItem5 = new AccountItem("欧洲买菜",Category.Spending, "我也不知道为啥去欧洲买菜", 10, Currency.EUR);
            var accountsItem6 = new AccountItem("欧洲买鸡胸",Category.Spending, "我更不知道为啥去欧洲买菜", 20, Currency.EUR, new DateTime(2019,6,2));
            var accountsItem7 = new AccountItem("工资", Category.Income, "发工资啦，好开心", "但是好像还不起花呗", 300, Currency.RMB, new DateTime(2019,6,18));
            accounts.Add(accountsItem1);
            accounts.Add(accountsItem2);
            accounts.Add(accountsItem3);
            accounts.Add(accountsItem4);
            accounts.Add(accountsItem5);
            accounts.Add(accountsItem6);
            accounts.Add(accountsItem7);
            accounts.DisplayTotalExpenditure(new DateTime(2019,6,30));
            accounts.DisplayTotalIncome(new DateTime(2019,6,30));
            accounts.DisplayTotalRevenue(new DateTime(2019,6,30));
            foreach(var info in accounts.Display(new DateTime(2019,6,30))){
                Console.WriteLine(info.ToString());
            }
        }
    }
}
