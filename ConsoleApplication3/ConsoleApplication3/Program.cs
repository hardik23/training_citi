using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*****Basic ConsoleI/O*****");
            GetUserData();
            FormatNumericalData();
            Console.WriteLine();

            FunWithString();
            Console.WriteLine();

            StringConcatenation();
            Console.WriteLine("");

            EscaprChars();
            Console.WriteLine("");

            immutableString();
            Console.WriteLine("");

            FunWithStringBuilder();
            Console.WriteLine("");

            DataTypeFunctionality();
            Console.WriteLine();

            CharFunctionality();
            Console.WriteLine();

            NewingDataTypes();
            Console.WriteLine();

            StringInterpolation();
            Console.WriteLine();

            Console.ReadLine();
        }

        #region Get User Data

        private static void GetUserData()
        {
            Console.Write("Please Enter Your Name: ");
            string userName = Console.ReadLine();
            Console.Write("Please Write Your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello {0} You Are {1} years old ", userName, userAge);

            Console.ForegroundColor = prevColor;
        }
        #endregion

        #region Different Numerical formats
        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}",99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
        #endregion

        #region Basic String Function
        static void FunWithString()
        {
            Console.WriteLine("Basic String Functionality");
            string FirstName = "Freddy";
            Console.WriteLine("First name has {0} characters",FirstName.Length);
            Console.WriteLine("Value of firstname: {0}",FirstName);
            Console.WriteLine("firstname in uppercase: {0}",FirstName.ToUpper());
            Console.WriteLine("firstname contains letter y? : {0}", FirstName.Contains("y"));
            Console.WriteLine("firstname in lowercase: {0}", FirstName.ToLower());
            Console.WriteLine("new firstname: {0}", FirstName.Replace("dy",""));
            Console.WriteLine();
        }
        #endregion

        #region String Concatenation
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation ");
            string s1 = "Programming The ";
            string s2 = "Psychodrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        #endregion

        #region Escape Chars
        static void EscaprChars()
        {
            Console.WriteLine("=> Escapr Characters:\a");
            string strWithTabs = "Mode1\tcolor\tSpeed\tPetname\a";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a");
            Console.WriteLine("c:\\MyApp\\bin\\Debug\a");
            Console.WriteLine("All Finished\n\n\n\a");
            Console.WriteLine();

            //The following string is printed verbatim without giving space characters
            Console.WriteLine(@"C:\Myapp\bin\Debug");

            string myLongString = @"This is a very 
                            Very 
                                        Very 
                                                long String";
            Console.WriteLine(myLongString);
            Console.WriteLine();
            Console.WriteLine(@"Cerebrus said ""Darrr! Pret-ty sun-sets""");
        }
        #endregion

        #region immutable test
        static void immutableString()
        {
            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
        }
        #endregion

        #region StringBuilder
        static void FunWithStringBuilder()
        {
            Console.WriteLine("+> Using the StringBuilder");

            StringBuilder sb = new StringBuilder("*****Fantastic Games****",256);

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Beyond Good And Evil");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2","Invisible War");
            Console.WriteLine(sb.ToString());
        }
        #endregion
        #region Data Type Functionality
        static void DataTypeFunctionality()
        {

            Console.WriteLine("=>DataType Funcionality");
            Console.WriteLine("Max of Int: {0}",int.MaxValue);

            Console.WriteLine("Min of int: {0}",int.MinValue);

            Console.WriteLine("Max of Double: {0}",double.MaxValue);

            Console.WriteLine("Min of Double: {0}",double.MinValue);

            Console.WriteLine("Double.epsilon: {0}",double.Epsilon);

            Console.WriteLine("bool.FalseStrimg: {0}",bool.FalseString);

            Console.WriteLine("bool.TrueStrimg: {0}",bool.TrueString);

            Console.WriteLine("double positiveinfinity: {0}",double.PositiveInfinity);

            Console.WriteLine("double negativeinfinity: {0}", double.NegativeInfinity);
            
        }
        #endregion

        #region test char functionality
        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}",char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('0'): {0}", char.IsLetter('0'));
            Console.WriteLine("char.IsWhiteSpace('Hello There',5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There',6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'):{0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
        #endregion

        #region Creating datatypes using new
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using New to create variables");
            bool b = new bool();        //set to false
            int i = new int();          //set to 0
            double d = new double();    //set to 0
            DateTime dt = new DateTime();   //set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0},{1},{2},{3}", b, i, d, dt);
            Console.WriteLine();
        }
        #endregion

        #region String Interpolation
        static void StringInterpolation()
        {
            int age = 4;
            string name = "Soren";

            string greeting = string.Format("\tHello {0}, You are {1} years old", name, age);
            string greeting2 = string.Format($"\tHello {name.ToUpper()} you are {age} years old");

            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            Console.WriteLine();
        }
        #endregion
    }
}
