using Demo.Interface_Example_01;
using Demo.Interface_Example_02;

namespace Demo
{
    internal class Program
    {

        #region Part 03 Interface - Example 02

        public static void PrintTenNumbersFromSeries(ISeries series)
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

        }
    }
}
