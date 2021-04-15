using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
    abstract class Name
    {
        protected string name;

        //public Name(string aName)
        //{
        //    name = aName;
        //}

        public abstract void Spell();

        public abstract void SpellEven();
    }
}
