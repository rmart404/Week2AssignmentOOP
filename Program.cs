using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RealEstateSalesperson
            RealEstateSalesperson houseCost = new RealEstateSalesperson(0,0,0,"","");
            int house1 = houseCost.MakeSale(435000);
            int house2 = houseCost.MakeSale(596010);
            int house3 = houseCost.MakeSale(387300);

            RealEstateSalesperson sP1 = new RealEstateSalesperson(4650000, .005, house1, 
                                                                 "Doc", "Holiday"
                                                                 );
            sP1.SalesSpeech();
            sP1.SalesPersonInfo();


            RealEstateSalesperson sP2 = new RealEstateSalesperson(5000000+house1, .025, house2, 
                                                                  "Doc", "Holiday"
                                                                  );
            
            sP2.SalesPersonInfo();


            RealEstateSalesperson sP3 = new RealEstateSalesperson(5000000+house2+house3, 
                                                                  .05, house1, "Doc", "Holiday"
                                                                  );
            
            sP3.SalesPersonInfo();
            #endregion

            #region GirlScout
            GirlScout girlScout = new GirlScout(0, 0, "", "");
            int box1 = girlScout.MakeSale(34);
            int box2 = girlScout.MakeSale(65);
            int box3 = girlScout.MakeSale(14);

            GirlScout b1 = new GirlScout(50, box1,
                                         "Matilda", "Wormwood"
                                         );
            b1.SalesSpeech();
            b1.SalesPersonInfo();

            GirlScout b2 = new GirlScout(50 + box1, box2,
                                         "Matilda", "Wormwood"
                                         );
            b2.SalesPersonInfo();

            GirlScout b3 = new GirlScout(50 + box1 + box2, box3,
                                         "Matilda", "Wormwood"
                                         );
            b3.SalesPersonInfo();
            #endregion

            ReadLine();
        }
    }
}