using Starcounter;
using System;

namespace Usama
{
    partial class CorporationVM : Json
    {

        protected override void OnData()
        {
            base.OnData();
            franchiseNametoAdd = "";
            var franchiseList = Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.corporation=?", Data);

            foreach (var franc in  franchiseList )
            {
                this.franchise.Add(new FranchiseVM() {Data = franc  });
            }

        }

        void Handle(Input.Save action)
        {
            Random r = new Random();
            var franchiseName = ((Corporation)Data).franchiseNametoAdd;
            var frachise =  new Franchise()
            {
                Name = franchiseName,
                corporation = (Corporation)Data,
                noOfHomes=r.Next(20),
                totalCommission=r.Next(20),
                averageCommission=r.Next(5),
                trend=r.Next(20)
            };
            Transaction.Commit();
            AddFranchise(frachise);
            franchiseNametoAdd = "";
        }

        void Handle(Input.noOfHomes action)
        {
            franchise.Clear();
            var franchiseList=Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.Corporation = ? ORDER BY f.noOfHomes ", Data);
            foreach (var franc in franchiseList)
            {
                this.franchise.Add(new FranchiseVM() { Data = franc });
            }
        }

        void Handle(Input.totalCommission action)
        {
            franchise.Clear();
            var franchiseList = Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.Corporation = ? ORDER BY f.totalCommission ", Data);
            foreach (var franc in franchiseList)
            {
                this.franchise.Add(new FranchiseVM() { Data = franc });
            }
        }

        void Handle(Input.averageCommission action)
        {
            franchise.Clear();
            var franchiseList = Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.Corporation = ? ORDER BY f.averageCommission ", Data);
            foreach (var franc in franchiseList)
            {
                this.franchise.Add(new FranchiseVM() { Data = franc });
            }
        }

        void Handle(Input.Trend action)
        {
            franchise.Clear();
            var franchiseList = Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.Corporation = ? ORDER BY f.trend ", Data);
            foreach (var franc in franchiseList)
            {
                this.franchise.Add(new FranchiseVM() { Data = franc });
            }
        }
        public void AddFranchise(Franchise fran)
        {
            //var franchiseJson = Self.GET("/Usama/partial/franchise" + fran.GetObjectID());
            franchise.Add(new FranchiseVM() { Data = fran} );
        }

    }
}
