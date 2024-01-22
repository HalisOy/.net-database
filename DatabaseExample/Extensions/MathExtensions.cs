using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Extensions;
public static class MathExtensions
{
    public static int RandomNumber(int minValue,int maxValue)
    {
        Random rand = new Random();
        return rand.Next(minValue, maxValue);
    }
}
