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
            int house1 = houseCost.MakeSale(405000);
            int house2 = houseCost.MakeSale(500600);
            int house3 = houseCost.MakeSale(407000);

            RealEstateSalesperson sP1 = new RealEstateSalesperson(4650000, .005, house1, 
                                                                 "John", "Doh"
                                                                 );
            sP1.SalesSpeech();
            sP1.SalesPersonInfo();


            RealEstateSalesperson sP2 = new RealEstateSalesperson(5000000+house1, .025, house2, 
                                                                  "John", "Doh"
                                                                  );
            
            sP2.SalesPersonInfo();


            RealEstateSalesperson sP3 = new RealEstateSalesperson(5000000+house2+house3, 
                                                                  .05, house1, "John", "Doh"
                                                                  );
            
            sP3.SalesPersonInfo();
            #endregion

            #region GirlScout
            GirlScout girlScout = new GirlScout(0, 0, "", "");
            int box1 = girlScout.MakeSale(43);
            int box2 = girlScout.MakeSale(76);
            int box3 = girlScout.MakeSale(24);

            GirlScout b1 = new GirlScout(50, box1,
                                         "Jane", "Doe"
                                         );
            b1.SalesSpeech();
            b1.SalesPersonInfo();

            GirlScout b2 = new GirlScout(50 + box1, box2,
                                         "Jane", "Doe"
                                         );
            b2.SalesPersonInfo();

            GirlScout b3 = new GirlScout(50 + box1 + box2, box3,
                                         "Jane", "Doe"
                                         );
            b3.SalesPersonInfo();
            #endregion

            ReadLine();
        }
    }
}