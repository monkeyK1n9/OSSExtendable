using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Contract
{
    public interface IContract
    {
        void Initialize(StackPanel stackPanel);

        void RunMe();
    }
}
