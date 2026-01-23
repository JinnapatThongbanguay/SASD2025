using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101
{
    // Do Refactoring the following code:
    public class QuestionsAndAnswers
    {
        // 1. Mysterious Name
        // เปลี่ยนชื่อ method ให้สื่อความหมาย
        public double GetMax(double a, double b)
        {
            return a > b ? a : b;
        }

        // 2. Duplicate Code
        // แยก logic ที่ซ้ำออกมาเป็น method เดียว
        public void Print()
        {
            PrintPerson("Mr. Harry Potter");
            PrintPerson("Ms. Mary Poppin");
            PrintPerson("Mr. Johny Black");
        }

        private void PrintPerson(string name)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"   {name}");
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        // 3. Shotgun Surgery
        // รวมค่าที่เปลี่ยนบ่อยไว้ที่เดียว
        public static class StudentRepository
        {
            public static int TotalStudents => 48;
        }

        public class StudentDisplay
        {
            public void DisplayStudents()
            {
                Console.WriteLine("Student Count = " + StudentRepository.TotalStudents);
            }

            public void PrintTotal()
            {
                Console.WriteLine("Total Students : " + StudentRepository.TotalStudents);
            }
        }

        // 4. Data Clump
        public void PrintDate(Date date)
        {
            Console.WriteLine(date.Format());
        }
    }

    // สร้างคลาส Date เพื่อจัดกลุ่มข้อมูลที่เกี่ยวข้องกัน
    public class Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        // 5. Feature Envy
        //     จากข้อที่แล้ว น่าจะได้สร้างคลาส Date ขึ้นมา
        //     ในคลาส Date นั้นให้สร้าง method: public string Format()
        //      ปรับให้ PrintDate(...) ของเดิม ไปเรียก date.Format() ดังกล่าว

        // 5. Feature Envy
        // ให้ object จัดการ formatting ของตัวเอง
        public string Format()
        {
            return $"{Day:00}/{Month:00}/{Year:0000}";
        }
    }
}
