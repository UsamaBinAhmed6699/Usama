using Starcounter;

namespace Usama
{
    partial class FranchiseVM : Json
    {
        public string Id { get; set; }
        protected override void OnData()
        {
            base.OnData();
            var franchise = ((Franchise)Data);
            Id = franchise.GetObjectID();
            
        }
        
    }
}
