using System.Drawing;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Error Types
            #region Syntax Errors -Compilation Error
            //Error in Syntax such as missing Semicolon
            //Console.WriteLine("Hello")
            #endregion

            #region RunTime Errors
            //int X = 5;
            //int Y = 0;
            //Console.WriteLine(X / Y);
            //Error Exception Error happen in Run Time such as dividing by zero
            #endregion

            #region Logical Errors
            //int A = 10;
            //int B = 20;
            //Console.WriteLine(Sum(A, B));
            //Error Expected Output not the exactly output
            #endregion

            #region Warning
            //int X;
            //You Must initialize Variable
            //When You not Use this Variable
            #endregion

            #endregion
            #region Variable
            //Data Type + Name + Value + Address
            //int Number = 5;
            #endregion
            #region CLS
            //Common Language Specification
            //Value Type, Reference Type
            //Value Type => Stored In Stack 
            //Reference Tpe
            //Stored In Heap and Reference Stored address 
            #endregion
            #region CTS - CLS
            //int Z = 4; //4 Byte
            //string Name = "test"; 
            //Name = "Ali"; 

            #endregion
            #region Value Type 
            //int L; 
            //L = 5;
            //int K = 10; 
            //K = L;
            //L++;
            //Console.WriteLine(K);
            //Console.WriteLine(L);
            #endregion
            #region Reference Type
            //Stack used to store address from heap used
            //reference from this type stored in heap
            //Point P1; 
            //P1 = new Point();
            //Point P2 = new Point();
            //P2 = P1;
            //P1.X = 5;
            //Console.WriteLine(P1.X);
            //Console.WriteLine(P2.X);
            #endregion
            #region Object
            //Object => Parent to all Data Type (Value Type Or Reference Type)
            //This Data Type inheritance from Object
            //Point P3 = new Point();
            //P3.ToString();
            //object obj1 = new object();
            //obj1 = 1;
            //obj1 = "Hello";
            //obj1 = 'A';
            //obj1 = true;

            //object obj2 = new object();
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());

            //obj2 = obj1;
            //Console.WriteLine("");
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());
            #endregion
            #region Fractions and Discard
            //int Number1 = 2222222222222; 
            //long Number2 = 2222222222222;

            //double Num3 = 22.2;
            //float Num4 = 22.4f;
            //decimal Num5 = 22.2m;

            //int Num6 = 1_000_000;
            //Console.WriteLine(Num6);
            #endregion
            #endregion
            #region Assignment
            #region Problem1
            //Console.WriteLine("Please Enter Any Number");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            #endregion
            #region Problem 2
            //int X = 100;
            //int Y = X;
            //Console.WriteLine($"Initial value of firstNumber: "+X);
            //Console.WriteLine($"Initial value of secondNumber:"+Y);
            //X = 20;
            //Console.WriteLine("\nAfter modifying");
            //Console.WriteLine($"Value of firstNumber:"+X);
            //Console.WriteLine($"Value of secondNumber:"+Y);
            //Changing one variable does not affect the other because they are stored in separate memory locations
            #endregion
            #region Problem 3
            //Point p01 ;
            //p01 = new Point();
            //Point p02 ;
            //p02 = new Point();
            //p02 = p01;
            //p01.X = 100;
            //Console.WriteLine("Before Modifying : " +p01.X);
            //Console.WriteLine("Before Modifying : " +p02.X);
            //p01.X = 300;
            //Console.WriteLine("After Modifying : " + p01.X);
            //Console.WriteLine("After Modifying : " + p02.X);
            //both variables point to the same object in memory
            #endregion
            #endregion
            #region Notes
            // Point => addresss not value
            #endregion
        }
    }
}
