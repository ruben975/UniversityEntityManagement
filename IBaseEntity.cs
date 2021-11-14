using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntityManagement
{
    public abstract class BaseEntity
    {

        public abstract void Name();

        internal void Save()
        {
            Console.WriteLine("Student");
        }
    }
}
