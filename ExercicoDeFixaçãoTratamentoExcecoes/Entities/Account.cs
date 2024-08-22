using ExercicoDeFixaçãoTratamentoExcecoes.Entities.Exceptions;

namespace ExercicoDeFixaçãoTratamentoExcecoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawnLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawnLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawnLimit = withdrawnLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdrawn(double amount)
        {
            if (amount > WithdrawnLimit)
            {
                throw new DomainException("Withdraw Error: The amout exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            return "Account "
                + Number
                + ", Holder: "
                + Holder.ToString()
                + ", Balance: "
                + Balance.ToString()
                + ", Withdraw Limit: "
                + WithdrawnLimit.ToString();
        }
    }
}
        