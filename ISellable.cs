using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    public interface ISellable
    {
        void SalesSpeech();
        int MakeSale(int value);

    }
}