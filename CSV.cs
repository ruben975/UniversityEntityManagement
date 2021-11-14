using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntityManagement
{
   public class CSV : Storage
    {
        public override void Save()
        {
            Console.WriteLine("Save to CSV");
        }
    }
}
