using System;
using Starcounter;


namespace Usama
{
    [Database]
    public class Corporation
    {
        public string franchiseNametoAdd { get; set; }
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public QueryResultRows<Franchise> franchise => Db.SQL<Franchise>("SELECT f FROM FRANCHISE f WHERE f.corporation=?", this);
    }

    [Database]
    public class Franchise
    {
        public Corporation corporation { get; set; }
        public string Name { get; set; }
        public int noOfHomes { get; set; }
        public int totalCommission { get; set; }
        public Double averageCommission { get; set; }
        public int trend { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public QueryResultRows<Accounts> account => Db.SQL<Accounts>("SELECT a FROM ACCOUNTS a WHERE a.franchise=?", this);
    }
    [Database]
    public class Accounts
    {
        public Franchise franchise { get; set; }
       
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Date { get; set; }
        public int Salesprice { get; set; }
        public int Commission { get; set; }
    }


    class Program
    {
        static void Main()
        {

           //MainPage
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/Usama/HomePage", () =>
            {
                return Db.Scope(() =>
                {
                    var corporationList = Db.SQL<Corporation>("SELECT c from Corporation c");

                    var ViewModel = new HomePageVM();
                    ViewModel.setMainView();

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);

                    };
                    ViewModel.Session = Session.Current;
                    return ViewModel;


                });


            });
            //Franchise Detail
            Handle.GET("/Usama/FranchiseBussines/{?}", (string id) =>
            {
                return Db.Scope(() =>
                {
                    var franchise = (Franchise)DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                    var json = new FranchiseDetailVM();
                    
                    json.franchise = franchise;

                    json.Accounts = new Accounts()
                    {
                        franchise = franchise
                    };
                    
                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);

                    };
                    json.Session = Session.Current;
                    return json;


                });
            });
        }
    }
}
