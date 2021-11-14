using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntityManagement
{
    public class BaseRepository 
    {
        protected BaseEntity entity;
        public BaseEntity Entity
        {
            set { entity = value; }
        }
        public virtual void Save()
        {
            entity.Save();
        }
    }
}
