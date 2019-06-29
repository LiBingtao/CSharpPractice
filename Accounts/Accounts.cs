using System;
using System.Collections.Generic;

namespace Account
{
    public class Accounts
    {
        public List<AccountItem> accounts = new List<AccountItem>();

        public void Add(AccountItem item) {
            accounts.Add(item);
        }

        public Money TotalRevenue(DateTime time) {
            Money revenue = new Money(0);
            revenue += TotalIncome(time);
            revenue -= TotalExpenditure(time);
            return revenue;
        }

        public void DisplayTotalRevenue(DateTime time) {
            var revenue = TotalRevenue(time);
            Console.WriteLine($"TotalRevenue:{revenue.value}{revenue.currency}");
        }

        public Money TotalExpenditure(DateTime time) {
            return Calculator(time, AccountItem.IsSpending);
        }

        public void DisplayTotalExpenditure(DateTime time) {
            var expenditure = TotalExpenditure(time);
            Console.WriteLine($"TotalExpenditure:{expenditure.value}{expenditure.currency}");
        }

        public Money TotalIncome(DateTime time) {
            return Calculator(time, AccountItem.IsIncome);
        }

        public void DisplayTotalIncome(DateTime time) {
            var income = TotalIncome(time);
            Console.WriteLine($"TotalIncome:{income.value}{income.currency}");
        }

        public IEnumerable<AccountItem> Display(DateTime time) {
            foreach (var account in accounts) {
                if (account.occuredTime.Month == time.Month) {
                    yield return account;
                }
            }
        }
        
        private Money Calculator(DateTime time, Predicate<AccountItem> predicate)
        {
            Money money = new Money(0);
            foreach (var account in accounts)
            {
                if (account.IsSameMonthOfSameYear(time) && predicate(account)) money += account.amount;
            }
            return money;
        }

    }
}