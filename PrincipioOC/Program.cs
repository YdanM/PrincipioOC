using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var onlineCourse = new OnlineCourse { CourseId = 1, Title = "Curso de C# en Línea" };
            var onsiteCourse = new OnsiteCourse { CourseId = 2, Title = "Curso de C# Presencial" };
            var hybridCourse = new HybridCourse { CourseId = 3, Title = "Curso de C# Híbrido" };

            var student = new Student { Id = 1, Nombre = "Ydan Monegro" };

            onlineCourse.Subscribe(student);
            onsiteCourse.Subscribe(student);
            hybridCourse.Subscribe(student);
            Console.ReadKey();
        }
    }
    
}
