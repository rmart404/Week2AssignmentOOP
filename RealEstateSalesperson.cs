using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    public class RealEstateSalesperson : Salesperson, ISellable
    {
        private int totalValueSold = 0;//in dollars
        private double totalComm = 0;//in dollar
        private double commRate = 0;//commission rate(percent)
        private int houseCost = 0;
       
        #region properties 
        public int TotalHouseCost
        {
            get {return houseCost;}
            set {houseCost = value;}
        }
        
        public int TotalValueSold
        {
            get {return totalValueSold;}
            set {totalValueSold = value;}

        }

        public double TotalComm
        {
            get {return totalComm;}
            set {totalComm = value;}

        }

        public double CommRate
        {
            get {return commRate;}
            set {commRate = value;}

        }
        #endregion end properties
        public RealEstateSalesperson(int TotalValueSold, double commRate, int TotalHouseCost,
                                     string firstName, string lastName
                                     ) : base(firstName, lastName)
            
        {
            houseCost = TotalHouseCost;
            totalValueSold = TotalValueSold;
            CommRate = commRate;

        }

        public void SalesSpeech() 
        {
            WriteLine("---------------Sales Person Details-----------------");
            WriteLine("These cars are so fast and up to date you'll need Doc\n" +
                      "Brown to bring you back to the future to own one!");

        }

        public int MakeSale(int house)
        {
            houseCost = house;
            return houseCost;
            
        }

        

        public override void SalesPersonInfo()
        {
            int totalHouseValue = houseCost + totalValueSold;
            totalComm = totalHouseValue * commRate; 


            WriteLine($"\nSalepersons first name: {fName} {lName}\n" +
                        $"Market Prize of home sold: ${houseCost}\n" +
                        $"The total value of all homes sold this quater: ${totalHouseValue}\n" +
                        $"Total commission for all homes sold this quater is: ${totalComm}\n"
                
                );
        }


    }
}