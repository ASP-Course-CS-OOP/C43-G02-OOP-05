using Demo.Interface_Example_01;

namespace Demo
{
    internal class Program
    {
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
            
            //That's Because the "TypeA" implement "IType" not inherit from it.
            //So it implement just signature methods not implement default implemented methods.


            #endregion

        }
    }
}
