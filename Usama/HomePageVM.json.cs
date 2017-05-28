using Starcounter;

namespace Usama
{
    partial class HomePageVM : Json
    {

        void Handle (Input.AddCorporation action)
        {
          
          var corporation=  new Corporation()
            {
                Name = Name
            };
            Transaction.Commit();
            addCorporation(corporation);
            Name = "";
        }
         
        void addCorporation(Corporation obj)
        {
            this.CorporationsList.Add(new CorporationVM() { Data = obj });
        }

        public void setMainView()
        {
            var corList = Db.SQL<Corporation>("SELECT c FROM Corporation c ");
            foreach (var item in corList)
            {
                CorporationsList.Add(new CorporationVM() { Data=item});
            }
        }
    }
}
