using nsp1;
using Xyz = nsp1.xyz;

using student = StringDemo_july_310724.Student;
using System.Collections.Specialized;
namespace StringDemo_july_310724
{
    class Student
    {
        public static void display() // static method
        { 
        }
        public void show() //non static method
        { 
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            String s1 = "Pune";
            
            string s2 = "warje";

            // Console.WriteLine(string.Compare(s1,s2));
            //Console.WriteLine(string.Compare("bce", "Bce"));

            //show();//invalid
            //student ss = new student();
            //ss.show();//valid

            //student.display();



            //Console.WriteLine(s1.CompareTo(s2) );
            //1 "" ==>string
            //2''   ==>char
            //string temp=string.Concat(s1," ",s2," ","maharashtra"," ","india");              
            string temp = string.Concat();
              //temp = string.Concat( temp,s2 );
            Console.WriteLine(temp);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
