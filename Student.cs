using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    /// <summary>
    /// All person data class
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PersonHeight { get; set; }
        public List<string> DisciplineName { get; set; }
        public List<float> DisciplineGrades { get; set; } = new List<float>();

        public Student()
        {
            DisciplineName = new List<string> {
                "история", "математика", "русский язык"
                };
        }

        /// <summary>
        /// Организация вывода информации о работнике
        /// </summary>
        /// <returns>Строковое представление информации</returns>
        public override string ToString()
        {
            float avg = DisciplineGrades.Sum() / DisciplineGrades.Count;
            return $"{Id,4} {FirstName,20} {LastName,20} {Age,10} {PersonHeight,10} {avg,10:##.##}";
        }
    }
}
