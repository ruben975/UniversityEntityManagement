using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntityManagement
{
   public class ProfessorRepository : BaseRepository
    {
        public override void Save()
        {
            entity.Save();
        }
    }
}
