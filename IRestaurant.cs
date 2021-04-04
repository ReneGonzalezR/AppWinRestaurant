using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinRestaurant
{
    interface IRestaurant
    {
        double Total { get; set; }
        int Contador { get; set; }
    }
}
