using System.Diagnostics.CodeAnalysis;

namespace demo5
{
    internal class Program
    {
        #region exception handling
        // static void dosum()
        // {
        //try
        //    {
        //        int x, y, z;
        //        Console.WriteLine("please enter number x");
        //        x = int.Parse(Console.ReadLine());
        //        Console.WriteLine("please enter number y");
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y;
        //        int[] arr = { 1, 2, 3 };
        //        arr[100] = 22;

        //static void dosumenumber()
        //{
        //    int x, y, z;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine(  "please enter number x");
        //        flag = int.TryParse(Console.ReadLine(), out x);
        //    }
        //    while (!flag);
        //    {
        //        Console.WriteLine("please enter number x");
        //        x = int.Parse(Console.ReadLine());
        //        Console.WriteLine("please enter number y");
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y;
        //        int[] arr = { 1, 2, 3 };
        //        arr[100] = 22;

        //    }


        //Console.WriteLine("please enter number x");
        //x = int.Parse(Console.ReadLine());
        //Console.WriteLine("please enter number y");
        //y = int.Parse(Console.ReadLine());
        //z = x / y;
        //int[] arr = { 1, 2, 3 };
        //arr[100] = 22;





        //catch (Exception ex)

        //{
        //    Console.WriteLine(  ex.Message);
        //}
        //catch(FormatException ex)
        //{
        //    Console.WriteLine( ex.Message );
        //}
        //catch(DivideByZeroException ex)
        //{

        //    Console.WriteLine( ex.Message );    
        //}
        //catch(IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine( ex.Message );
        //}


        //int x, y, z;
        //Console.WriteLine(      "please enter number x"    );
        //x=int.Parse( Console.ReadLine() );
        //Console.WriteLine("please enter number y");
        //y =int.Parse( Console.ReadLine() ) ;
        //z = x / y;
        //int[] arr = { 1, 2, 3 };
        //arr[100] = 22;

        // }


        #endregion
        #region passing by out

        //static void srs(int x, int y,out int sum,out int mull)
        //{
        //     sum = x + y;
        //     mull = x * y;

        //}
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region excption handling
            //--------------------------//
            /// dosum();
            /// dosumenumber();
            #endregion
            #region array method
            //int[]number = { 1, 2, 3 };
            //int[]number2 = { 1,2,3,4 };
            //int[]number3 = { 1,3,4,5,6,7 };
            //Array.Sort(number); //sort array
            //Array.Copy(number, number2, 3);
            //foreach (int i in number)
            //{
            //    Console.WriteLine( i );

            //}
            //Array.Clear(number);

            #endregion

            #region passing by out
            //int A = 10, B = 20, sumresult, mullresult;
            //srs(A, B, out sumresult, out mullresult);
            //Console.WriteLine($"sum numbers of{sumresult}");
            //Console.WriteLine($"mull numbers of {mullresult}");
            #endregion




        }

    }
}  

