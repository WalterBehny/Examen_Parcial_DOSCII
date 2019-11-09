using System;
using UpgFisi.Common.Domain;

namespace Accounts.Domain
{
    public class Account
    {
        public virtual string AccountId { get; protected set; }
        public virtual AccountNumber AccountNumber { get; protected set; }
        public virtual Money Balance { get; protected set; }
        public virtual Money Sobregiro_max { get; protected set; }
        public virtual Money Sobregiro_disponible { get; protected set; }
        public virtual AccountState AccountState { get; protected set; }
        public virtual CustomerId CustomerId { get; protected set; }
        public virtual DateTime OpenedAtUtc { get; protected set; }
        public virtual DateTime UpdatedAtUtc { get; protected set; }

        public virtual void WithdrawMoney(decimal amount)
        {
            if (CanWithdrawMoney(amount))
            {
                var money = new Money(amount, Currency.USD);
                if (Balance.Amount >= amount) {
                    Balance = Balance.Subtract(money);
                }
                else
                {
                    var money_sobregiro = new Money(amount-Balance.Amount, Currency.USD);
                    Balance = Balance.Subtract(Balance);
                    Sobregiro_disponible = Sobregiro_disponible.Subtract(money_sobregiro);
                }
                
            }
        }

        public virtual bool CanWithdrawMoney(decimal amount)
        {
            return Balance.Amount+ Sobregiro_disponible.Amount >= amount;
        }

        public virtual void DepositMoney(decimal amount)
        {
            var money = new Money(amount, Currency.USD);
            Balance = Balance.Add(money);
        }

        public virtual void ReturnMoney(decimal amount)
        {
            DepositMoney(amount);
        }

        public virtual void ChangeUpdateAtUtc()
        {
            UpdatedAtUtc = DateTime.UtcNow;
        }
    }
}