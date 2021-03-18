using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqPractice.Models
{
    public class TwoModel
    {
        public List<Student> StudentList { get; set; }
        public Student FilterInput { get; set; }
    }

  public class Student
  {
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
  }
  public static class StudentData
  {
    public static List<Student> GetStudents()
    {
      return new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 },
         new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 },
         new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 },
         new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 },
         new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 },
         new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 },
         new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 },
         new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 6, StudentName = "Karan", Age = 30} ,
        new Student() { StudentID = 7, StudentName = "Priyanka",  Age = 21 } ,
        new Student() { StudentID = 8, StudentName = "Kiran",  Age = 29 } ,
        new Student() { StudentID = 9, StudentName = "Ramesh" , Age = 50} ,
        new Student() { StudentID = 10, StudentName = "Ronnie" , Age = 40 },
        new Student() { StudentID = 11, StudentName = "Jerry", Age = 21} ,
        new Student() { StudentID = 12, StudentName = "Mohan",  Age = 28 } ,
        new Student() { StudentID = 13, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 14, StudentName = "Vikas" , Age = 21} ,
        new Student() { StudentID = 15, StudentName = "Tarun" , Age = 16 }
    };
    }
  }
}
