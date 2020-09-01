using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestOil.Entities;

namespace BestOil.Repositories
{
    class SubjectRepository
    {
        private List<SubjectInfo> subjects;
        public SubjectRepository()
        {
            subjects = new List<SubjectInfo>()
            {
                new SubjectInfo(){Name = "АИ-92", Price = 1.43},
                new SubjectInfo(){Name = "АИ-95", Price = 1.54},
                new SubjectInfo(){Name = "АИ-98", Price = 1.65},
                new SubjectInfo(){Name = "ДТ", Price = 1.54},
            };
        }
        public IReadOnlyCollection<SubjectInfo> Get()
        {
            return subjects;
        }



    }
}
