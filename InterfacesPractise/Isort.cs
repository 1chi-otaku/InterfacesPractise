using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractise
{
    internal interface Isort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
