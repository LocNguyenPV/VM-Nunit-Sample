using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    public class Services
    {
        public bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //public bool IsPrimeV2(int n)
        //{
        //    var check = true;
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        { check = false; break; }
        //    }
        //    if(n != 1 && check)
        //    {
        //        return true;
        //    }
        //    return false;

        //}


    }
}
