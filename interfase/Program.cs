using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfase
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() {Name= "vasya", Age= 20 };
            Student student2 = new Student() { Name = "anna", Age = 18 };

            Student[] students = new Student[] { student1, student2 };

            Array.Sort(students);
        }
    }

    public interface IShip
    {
        string Move(int distance);

        string Fight();
    }

    public interface IDestroyble
    {
        string Destroy();
    }

    public struct Student : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            if (this.Age > student.Age) return 1;
            if (this.Age < student.Age) return -1;

            return 0;
        }
    }


    public class TransportShip : IShip, IDestroyble
    {
        public string Destroy()
        {
            return "КОРАБЛЬ КИЛЛ";
        }

        public string Fight()
        {
            return "Транспортный корабль не может вступить в бой";


        }

    public string Move(int distance)
        {
            double time = (double)distance / 1000;

            return string.Format("Пройдено км {0} за время {1}", distance, time);

        }
    }
}
