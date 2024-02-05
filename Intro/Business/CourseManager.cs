using Intro.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ctor yazıp tab tab yaparak constructor oluşturabiliriz.


namespace Intro.Business;

public class CourseManager
{

    Course[] courses = new Course[3]; 
    /// constroctur
    public CourseManager()
    {
        Course course1 = new Course(); // MECBUR
        course1.Id = 1;
        course1.Name = "c#";
        course1.Description = "sürüm1";
        course1.Price = 0;


        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "python";
        course2.Description = "sürüm2";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "java";
        course3.Description = "sürüm3";
        course3.Price = 0;
       // Course[] courses1 = new Course[] { course1, course2, course3 };
        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    
    }
    //public void GetAll()
    public Course[] GetAll()
    {
        return courses;
        //Console.WriteLine("kurslar listelendi");


    }
}
