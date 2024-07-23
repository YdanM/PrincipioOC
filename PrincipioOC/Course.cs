using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioOC
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student student);

    }
}
