using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataSource.Meter
{
    public interface IFactory_Meter
    {
        IMeter GetMeter();
    }
}
