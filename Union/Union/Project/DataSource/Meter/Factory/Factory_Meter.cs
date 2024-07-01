using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataSource.Meter
{
    public class Factory_Meter : IFactory_Meter
    {
        private Random random;

        public Factory_Meter()
        {
            this.random = new Random();
        }

        public IMeter GetMeter()
        {
            return new Meter_Mock(this.random.Next(0,9000));
        }
    }
}
