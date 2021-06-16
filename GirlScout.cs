using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    public class GirlScout : Salesperson
    {
        public int totalBoxesSold = 0;
        public int saleBS = 0;

        #region properties
        public int TotalBoxesSold
        {
            get {return totalBoxesSold;}
            set {totalBoxesSold = value;}

        }

        public int SaleBS
        {
            get {return saleBS;}
            set {saleBS = value;}
        }
        #endregion

        public GirlScout(int boxSold, int sBS, string firstName, string lastName)
            : base(firstName, lastName)
        {
            saleBS = sBS;
            totalBoxesSold = boxSold;
        }

        public void SalesSpeech()
        {
            WriteLine("\n\n\n---------------Girl Scout Cookie Details-----------------");
            WriteLine("These cookies are the best in town and you'd be a fool not to\n" +
             "buy any from Jane Doe!");
        }

        public int MakeSale(int sale)
        {
            saleBS = sale;
            return saleBS;
        }

        public override void SalesPersonInfo()
        {
            int combinedTotalBoxesSold = saleBS + totalBoxesSold;

            WriteLine($"\nSalepersons name is: {fName} {lName}\n" +
                        $"Number of boxes sold today: {saleBS}\n" +
                        $"Total number of all boxes sold: {combinedTotalBoxesSold}" 
                        

                );

        }

    }
}