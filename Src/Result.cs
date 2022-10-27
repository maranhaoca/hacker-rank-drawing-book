using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

        public static int pageCount(int n, int p)
        {
            return (p / 2) < ((n / 2) - (p / 2)) ? (p / 2) : (n / 2) - (p / 2);
        }
    }
}