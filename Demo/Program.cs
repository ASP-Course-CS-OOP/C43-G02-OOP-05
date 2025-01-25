using Demo.Interface_Example_01;
using Demo.Interface_Example_02;
using Demo.Interface_Example_03;

namespace Demo
{
    internal class Program
    {

        #region Part 03 Interface - Example 02

        public static void PrintTenNumbersFromSeries(ISeries series) // Develop Against Interface
        {
            if (series is null)
                return;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }

        #endregion

        static void Main(string[] args)
        {

            #region Part 01 What is Interface

            //Done [ Check NoteBook ]

            #endregion

            #region Part 02 Interface - Example 01

            //IType type;
            ////Declare reference "type" of type "IType".
            ////This reference "type" Hold garbage value.
            ////This reference "type" can refer to an object of any type [class - struct] that implement "IType" interface. 
            ////CLR will allocate 4 uninitialized bytes in STACK [still not hold address of any object so it's uninitialized bytes ]
            ////CLR will allocate 0 bytes in "HEAP"

            ////We can't make object from Interface ?
            //// - Because if make object this mean you can access methods inside it and those methods are not implemented [just signature].
            ////IType type = new IType(); // => INVALID.

            //type = new TypeA();
            //type.MyProperty = 10;
            //type.MyMethod();//Hello, World!
            //type.Print();//Default Implemented Method!.

            ////The Default Implemented Method inside interface accessed only throw reference of type interface that refer to object of type implement this interface.
            ////if you make reference of type "TypeA" and this reference "typeA" refer to object of type "TypeA", this reference can access only the implemented method and can't access the default implemented method. 
            //TypeA typeA = new TypeA();
            ////typeA.Print();//ERROR

            //That's Because the "TypeA" implement "IType" not inherit from it [TypeA not inherit this default implemented method and not implemented it, so can't access it throw reference from "TypeA" that refer to object of type "TypeA"].
            //So it implement just signature methods not implement default implemented methods.


            #endregion

            #region Part 03 Interface - Example 02

            //TypeAA seriesBy2 = new TypeAA();
            //PrintTenNumbersFromSeries(seriesBy2);// 0       2       4       6       8       10      12      14      16      18

            //TypeB seriesBy3 = new TypeB();
            //PrintTenNumbersFromSeries(seriesBy3);// 0       3       6       9       12      15      18      21      24      27


            //TypeC seriesBy4 = new TypeC();
            //PrintTenNumbersFromSeries(seriesBy4);// 0       4       8       12      16      20      24      28      32      36

            #endregion

            #region Part 04 Interface - Example 03

            //IMovable movable0 = new Car();
            //movable0.Forward();  // Car move forward on ground!
            //movable0.Backward(); // Car move backward on ground!
            //movable0.Left();     // Car move left on ground!
            //movable0.Right();    // Car move right on ground!

            //Console.WriteLine("-----------------------------------");

            //Airplane01 airplane0 = new Airplane01();
            //airplane0.Forward();   // Airplane move forward!  
            //airplane0.Backward();  // Airplane move backward!
            //airplane0.Left();      // Airplane move left!
            //airplane0.Right();     // Airplane move right!

            //Console.WriteLine("-----------------------------------");

            //IFlyable flyable0 = new Airplane01();
            //flyable0.Forward();   // Airplane move forward!
            //flyable0.Backward();  // Airplane move backward!
            //flyable0.Left();      // Airplane move left!
            //flyable0.Right();     // Airplane move right!

            //Console.WriteLine("-----------------------------------");

            //IMovable movable = new Airplane02(); // only see the "IMovable" methods inside "Airplane02" class
            //movable.Forward();   // Airplane move forward on ground!
            //movable.Backward();  // Airplane move backward on ground!
            //movable.Left();      // Airplane move left on ground!
            //movable.Right();     // Airplane move right on ground!

            //Console.WriteLine("-----------------------------------");

            //IFlyable flyable = new Airplane02(); // // only see the "IFlyable" methods inside "Airplane02" class
            //flyable.Forward();   // Airplane move backward on sky!
            //flyable.Backward();  // Airplane move backward on sky!
            //flyable.Left();      // Airplane move left on sky!
            //flyable.Right();     // Airplane move right on sky!

            //Console.WriteLine("-----------------------------------");

            //// Error Case.
            ////Airplane02 airplane = new Airplane02();
            ////airplane.Forward();
            ////airplane.Backward();
            ////airplane.Left();
            ////airplane.Right(); 

            #endregion

            #region Part 05 Deep Copy Vs Shallow Copy

            #region Shallow Copy

            //int[] arr01 = new int[] { 1, 2, 3 };
            //int[] arr02 = new int[] { 4, 5, 6 };

            //Console.WriteLine($"arr01.GetHashCode() : {arr01.GetHashCode()}");//  arr01.GetHashCode() : 54267293
            //Console.WriteLine($"arr02.GetHashCode() : {arr02.GetHashCode()}");//  arr02.GetHashCode() : 18643596

            //arr02 = arr01;// Shallow Copy
            //Console.WriteLine("After Shallow Copy ---> arr02 = arr01");       //  After Shallow Copy ---> arr02 = arr01

            //Console.WriteLine($"arr01.GetHashCode() : {arr01.GetHashCode()}");//  arr01.GetHashCode() : 54267293
            //Console.WriteLine($"arr02.GetHashCode() : {arr02.GetHashCode()}");//  arr02.GetHashCode() : 54267293

            //arr02[0] = 100;

            //Console.WriteLine($"arr02[0] -> {arr02[0]}"); // arr02[0] -> 100
            //Console.WriteLine($"arr01[0] -> {arr01[0]}"); // arr01[0] -> 100

            #endregion

            #region Deep Copy - clone() with array of integers int[]. 

            //int[] arr01 = new int[] { 1, 2, 3 };
            //int[] arr02 = new int[] { 4, 5, 6 };

            //Console.WriteLine($"arr01.GetHashCode() : {arr01.GetHashCode()}");//          arr01.GetHashCode() : 54267293
            //Console.WriteLine($"arr02.GetHashCode() : {arr02.GetHashCode()}");//          arr02.GetHashCode() : 18643596

            //arr02 = (int[])arr01.Clone();// Deep Copy
            //Console.WriteLine("After Deep Copy ---> arr02 = (int[])arr01.Clone()");//     After Deep Copy ---> arr02 = (int[])arr01.Clone()

            //Console.WriteLine($"arr01.GetHashCode() : {arr01.GetHashCode()}");//          arr01.GetHashCode() : 54267293
            //Console.WriteLine($"arr02.GetHashCode() : {arr02.GetHashCode()}");//          arr02.GetHashCode() : 33574638

            //arr02[0] = 100; // Modify the copy object element.

            //Console.WriteLine($"arr02[0] -> {arr02[0]}"); // arr02[0] -> 100
            //Console.WriteLine($"arr01[0] -> {arr01[0]}"); // arr01[0] -> 1  [Modify on the copy object not affect the original object]

            //foreach (var number in arr01)
            //{
            //    Console.Write(number + " "); // 1 2 3
            //}

            //Console.WriteLine();

            //foreach (var number in arr02)
            //{
            //    Console.Write(number + " "); // 100 2 3s
            //}

            #endregion

            #endregion

            #region Part 06 Why Clone Method Says it Makes a Shallow Copy

            //// Clone() method with array of references [array of strings].

            //string[] names01 = new string[] { "Amr", "Mona" };
            //string[] names02 = new string[] { "Ahmed", "Yassmin" };

            //Console.WriteLine($"names01.GetHashCode() : {names01.GetHashCode()}");         // names01.GetHashCode() : 54267293
            //Console.WriteLine($"names02.GetHashCode() : {names02.GetHashCode()}");         // names02.GetHashCode() : 18643596

            //names02 = (string[])names01.Clone(); // Deep Copy
            //Console.WriteLine("After Deep Copy --> names02 = (string[])names01.Clone();"); // After Deep Copy --> names02 = (string[])names01.Clone();

            //Console.WriteLine($"names01.GetHashCode() : {names01.GetHashCode()}");         // names01.GetHashCode() : 54267293
            //Console.WriteLine($"names02.GetHashCode() : {names02.GetHashCode()}");         // names02.GetHashCode() : 33574638

            //names02[0] = "Eslam";

            //Console.WriteLine(names02[0]);// Eslam
            //Console.WriteLine(names01[0]);// Amr

            #endregion

        }
    }
}
