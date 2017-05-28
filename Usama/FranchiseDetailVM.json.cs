using Starcounter;

namespace Usama
{
    partial class FranchiseDetailVM : Json
    {
        public Franchise franchise { get; set; }
        public Accounts Accounts { get; set; }
        void onData()
        {
            base.OnData();
            var accountlist = Db.SQL<Franchise>("SELECT a FROM Accounts a WHERE a.franchise=?", Data);
            foreach (var franc in accountlist)
            {
                this.AccountsList.Add(new FranchiseVM() { Data = franc });
            }

        }
        void Handle (Input.Save action)
        {
            Transaction.Commit();
        }

        //To Store HomeData
        void Handle(Input.Registor action)
        {
            Transaction.Commit();
            addAccountList((Accounts)this.Accounts);
         }

        void addAccountList(Accounts obj)
        {
           
            AccountsList.Add(new AccountsDetailVM() { Data=obj });
        }

      
    }
}

