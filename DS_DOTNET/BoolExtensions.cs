using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDOTNET;

public static class BoolExtensions
{
    public static int ToInt(this bool value)
    {
        return value ? 1 : 0;
    }
}
