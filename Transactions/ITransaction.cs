using Accounts;

namespace Transactions;
interface ITransaction{
    void Transfer(Account ac1, Account ac2, decimal amount);
}