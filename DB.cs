using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntityManagement
{
    public class DB : Storage
    {
        public override void Save()
        {
            Console.WriteLine("Save to DB");
        }
    }
}
