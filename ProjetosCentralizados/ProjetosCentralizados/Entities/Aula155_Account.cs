using System.Globalization;
using System.Text;
using ProjetosCentralizados.Entities.Exceptions;

namespace ProjetosCentralizados.Entities
{
    internal class Aula155_Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; set; }

        public Aula155_Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Deposit(balance);
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new Aula155_DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new Aula155_DomainException("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}