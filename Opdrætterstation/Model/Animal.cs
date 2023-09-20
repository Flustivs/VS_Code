using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model
{
    internal abstract class Animal : IAnimal
    {
        protected bool mammal;
        protected bool gender;
        protected bool hair;
        protected byte legs;

        public abstract void Print();
    }
}
