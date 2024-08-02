using nsp1;
using Xyz = nsp1.xyz;

using student = StringDemo_july_310724.Student;
using System.Collections.Specialized;
using System.Text;
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
            #region 310724 data
            //1
            //String s1 = "Pune";

            //string s2 = "warje";

            // Console.WriteLine(string.Compare(s1,s2));
            //Console.WriteLine(string.Compare("bce", "Bce"));

            //show();//invalid
            //student ss = new student();
            //ss.show();//valid

            //student.display();



            //Console.WriteLine(s1.CompareTo(s2) );
            //1 "" ==>string
            //2''   ==>char
            ////string temp=string.Concat(s1," ",s2," ","maharashtra"," ","india");              
            //string temp = string.Concat();
            //  //temp = string.Concat( temp,s2 );
            //Console.WriteLine(temp);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            #endregion

            //   String str = "1,rajesh.MCA,596";

            //string[] strArray=   str.Split(".");
            //   //strArray[0]==> rajesh  string
            //   //strArray[1]==> sharad  string
            //   //strArray[2]==> waghmare string

            //   for (int i = 0; i < strArray.Length; i++)
            //   {
            //       Console.WriteLine(strArray[i]);
            //   }

            //string str = "nitin";
            ////str[0] = 'x';//invalid
            ////Console.WriteLine(str[0]);
            //char[] sArray=str.ToCharArray();
            //sArray[0] = 'x';//valid

            //string city = "pune ";//5
            //Console.WriteLine("length of city name="+city.Length);
            //string city3 = city.Trim();//4 char
            //string city2 = "pune";
            //Console.WriteLine(string.Compare(city3,city2));//0
            //Console.ReadKey();


            StringBuilder sb1 = new StringBuilder();//"" empty
            sb1.Append("pune");
            Console.WriteLine("address of sb1= "+sb1.GetHashCode()+" "+sb1.ToString());
            sb1.Append(" warje");
            
            Console.WriteLine("address of sb1= " + sb1.GetHashCode() + " " + sb1.ToString());

            string s1 = "pune";
            Console.WriteLine("address of s1= " + s1.GetHashCode() + " " + s1);
            s1 = s1 + " warje";
            Console.WriteLine("address of s1= " + s1.GetHashCode() + " " + s1);
        }
    }
}
