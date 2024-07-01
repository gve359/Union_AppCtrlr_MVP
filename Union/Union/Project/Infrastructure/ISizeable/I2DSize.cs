using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public struct Scopes
    {
        public readonly double a;
        public readonly double b;

        public Scopes(double a, double b) : this()
        {
            this.a = a;
            this.b = b;
        }
    }

    public interface I2DSizeable
    {
        Scopes ScopeX { get; set; }
        Scopes ScopeY { get; set; }
    }
}
