using Demo.Built_in_Interfaces;
using Demo.Built_in_Interfaces.ICloneable___IComparable___IComparer;
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

        #region Part 08 Built-In Interface ICompareable

        #region Sorting Array of integers and Array of employees manually

        public static void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        public static void swap(ref Employeee x, ref Employeee y)
        {
            Employeee z = x;
            x = y;
            y = z;
        }
        public static void sortEmpArrDesc(Employeee[] emps)
        {
            for (int i = 0; i < emps.Length - 1; i++)
            {
                for (int j = i + 1; j < emps.Length; j++)
                {
                    if (emps[i].Salary.CompareTo(emps[j].Salary) < 0)
                    {
                        swap(ref emps[i], ref emps[j]);
                    }
                }
            }
        }
        public static void sortIntArrAsc(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i].CompareTo(numbers[j]) > 0)
                    {
                        swap(ref numbers[i], ref numbers[j]);
                    }
                }
            }
        }

        #endregion 

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

            #region Part 07 Built-in Interfaces - ICloneable

            #region Example01

            //Employee employee01 = new Employee() { Id = 100, Name = "Ahmed", Salary = 8_000 };
            //Employee employee02 = new Employee() { Id = 200, Name = "Omnia", Salary = 4_000 };

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 18643596

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 200, Name: Omnia, Salary: 4000

            //Console.WriteLine();

            //employee02 = (Employee)employee01.Clone();
            //Console.WriteLine("After Deep Copy => ");
            //Console.WriteLine();

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 33574638

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 100, Name: Ahmed, Salary: 8000

            //employee02.Name = "Khalid";
            //Console.WriteLine(employee01.Name);// Ahmed 

            #endregion

            #region Example 02 - Employee & Department Class

            #region 01 - Without make cloning on Department inside clone() Method inside Employee Class - Modify on copy affect the original

            //Employeee0 employee01 = new Employeee0() { Id = 100, Name = "Ahmed", Salary = 8_000, Department = new Department() { Code = 1000, Title = "Sales" } };
            //Employeee0 employee02 = new Employeee0() { Id = 200, Name = "Omnia", Salary = 4_000, Department = new Department() { Code = 1500, Title = "HR" } };

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 18643596

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 200, Name: Omnia, Salary: 4000, Department => Code: 1500, Title: HR

            //Console.WriteLine();

            //employee02 = (Employeee0)employee01.Clone();
            //Console.WriteLine("After Deep Copy => ");
            //Console.WriteLine();

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 33574638

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //if (employee02.Department is not null)
            //    employee02.Department.Title = "New Title";
            //Console.WriteLine(employee01.Department.Title);// New Title   

            #endregion

            #region 02 - With make cloning on Department inside clone() Method inside Employee Class - modify on copy not affect the original

            //Employeee employee01 = new Employeee() { Id = 100, Name = "Ahmed", Salary = 8_000, Department = new Department() { Code = 1000, Title = "Sales" } };
            //Employeee employee02 = new Employeee() { Id = 200, Name = "Omnia", Salary = 4_000, Department = new Department() { Code = 1500, Title = "HR" } };

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 18643596

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 200, Name: Omnia, Salary: 4000, Department => Code: 1500, Title: HR

            //Console.WriteLine();

            //employee02 = (Employeee)employee01.Clone();
            //Console.WriteLine("After Deep Copy => ");
            //Console.WriteLine();

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 33574638

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales

            //if (employee02.Department is not null)
            //    employee02.Department.Title = "New Title";

            //Console.WriteLine(employee01.Department.Title); // Sales

            #endregion

            #endregion

            #region Example03 - DeepCopy Using Copy Constructor

            //Employeee employee01 = new Employeee() { Id = 100, Name = "Ahmed", Salary = 8_000, Department = new Department() { Code = 1000, Title = "Sales" } };
            //Employeee employee02 = new Employeee() { Id = 200, Name = "Omnia", Salary = 4_000, Department = new Department() { Code = 1500, Title = "HR" } };

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 18643596

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 200, Name: Omnia, Salary: 4000, Department => Code: 1500, Title: HR

            //Console.WriteLine();

            //employee02 = new Employeee(employee01);
            //Console.WriteLine("After Deep Copy Using Copy Constructor => ");
            //Console.WriteLine();

            //Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");// employee01.GetHashCode(): 54267293
            //Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");// employee02.GetHashCode(): 33574638

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine($"employee01 => {employee01} ");// employee01 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //Console.WriteLine($"employee02 => {employee02} ");// employee02 => Id: 100, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales

            //if (employee02.Department is not null)
            //    employee02.Department.Title = "New Title";

            //Console.WriteLine(employee01.Department.Title); // Sales

            #endregion

            #endregion

            #region Part 08 Built-In Interface ICompareable

            #region Sorting Array of integers and Array of employees manually

            //int[] arr = new int[] { 9, 3, 1, 8, 10, 2, 7, 5, 4, 6 };
            //sortIntArrAsc(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //Employeee[] emps = new Employeee[]
            //{
            //    new Employeee(){Id = 100,Name = "Ahmed",Salary = 10_000},
            //    new Employeee(){Id = 200,Name = "Khalid",Salary = 90_000},
            //    new Employeee(){Id = 300,Name = "Samy",Salary = 40_000}

            //};

            //sortEmpArrDesc(emps);

            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion

            #region Example01 - Sorting Array of integers - Array.Sort(numbers);

            //int[] numbers = new int[] { 1, 8, 7, 4, 5, 6, 9, 3, 10 };
            //Array.Sort(numbers);//Sort() is class[Array] member method that sort the elements of array ASC and take parameter of type that implement the "Icompareable" interface,
            //                    //so it will work here because "numbers" refer to object of type "int[]" and "Int" struct implement the "Icompareable" interface and provide implementation for CompareTo() method.

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");// 1 3 4 5 6 7 8 9 10
            //} 

            #endregion

            #region Example02 - Sorting Array of Employeees - Array.Sort(employees); - Before that "Employee" class implement "ICompareable" interface

            //Employeee[] employees = new Employeee[]
            //  {
            //    new Employeee(){Id = 10,Name = "Ahmed",Salary = 8000},
            //    new Employeee(){Id = 20,Name = "Omnia",Salary = 2000},
            //    new Employeee(){Id = 30,Name = "Nadia",Salary = 10000},
            //    new Employeee(){Id = 40,Name = "Omar",Salary = 6000},
            //  };
            //Array.Sort(employees);//Sort() is class[Array] member method that sort the elements of array ASC and take parameter of type that implement the "Icompareable" interface,
            //                      //so it not will work here because "employees" refer to object of type "Employeee[]" and "Employeee" Class doesn't implement the "Icompareable" interface and not provide implementation for CompareTo() method,
            //                      //so Employee not has comparing behavior between employees
            //                      //So we need to let "Employeee" class implement the "Icompareable" interface and  provide the implementation of comparing between two Employee object based on what?.
            //foreach (Employeee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //} 

            #endregion

            #region Example03 - Sorting Array of Employeees - Array.Sort(employees); - After that "Employee" class implement "ICompareable" interface

            // Employeee[] employees = new Employeee[]
            //{
            //     new Employeee(){Id = 10,Name = "Ahmed",Salary = 8000,Department = new Department(){ Code = 1000,Title = "Sales"} },
            //     new Employeee(){Id = 20,Name = "Omnia",Salary = 2000,Department = new Department(){ Code = 1500,Title = "HR"} },
            //     new Employeee(){Id = 30,Name = "Nadia",Salary = 10000,Department = new Department(){ Code = 2000,Title = "Managing"} },
            //     new Employeee(){Id = 40,Name = "Omar",Salary = 6000,Department = new Department(){ Code = 3000,Title = "Hiring"} },
            //};

            // Array.Sort(employees);

            // foreach (Employeee employee in employees)
            // {
            //     Console.WriteLine(employee); // Id: 20, Name: Omnia, Salary: 2000, Department => Code: 1500, Title: HR
            //                                  // Id: 40, Name: Omar, Salary: 6000, Department => Code: 3000, Title: Hiring
            //                                  // Id: 10, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //                                  // Id: 30, Name: Nadia, Salary: 10000, Department => Code: 2000, Title: Managing
            // }


            // int result = employees[0].CompareTo("Eslam");
            // Console.WriteLine(result);// Throw Exception => (Unable to cast object of type 'String' to type Employeee) Because inside CompareTo(object? obj)
            //                           // we make casting from object? obj which refer to object of type string to Employee Which is can't be casted  

            #endregion

            #endregion

            #region Part 09 Built-In Interface IComparer - Add new Comparison behavior to the Type Employee [Compare baed on Id].

            //   Employeee[] employees = new Employeee[]
            //{
            //       new Employeee(){Id = 20,Name = "Omnia",Salary = 2000,Department = new Department(){ Code = 1500,Title = "HR"} },
            //       new Employeee(){Id = 10,Name = "Ahmed",Salary = 8000,Department = new Department(){ Code = 1000,Title = "Sales"} },
            //       new Employeee(){Id = 40,Name = "Omar",Salary = 6000,Department = new Department(){ Code = 3000,Title = "Hiring"} },
            //       new Employeee(){Id = 30,Name = "Nadia",Salary = 10000,Department = new Department(){ Code = 2000,Title = "Managing"} },
            //};

            //   Array.Sort(employees,new EmployeeeComparer() );

            //   //Sorted based on Id not salary
            //   foreach (Employeee employee in employees)
            //   {
            //       Console.WriteLine(employee); // Id: 10, Name: Ahmed, Salary: 8000, Department => Code: 1000, Title: Sales
            //                                    // Id: 20, Name: Omnia, Salary: 2000, Department => Code: 1500, Title: HR
            //                                    // Id: 30, Name: Nadia, Salary: 10000, Department => Code: 2000, Title: Managing
            //                                    // Id: 40, Name: Omar, Salary: 6000, Department => Code: 3000, Title: Hiring
            //   }

            #endregion

            #region part 10 - Sorting Array of integers Desc - using Array.Sort() Method By making new class that implement IComparer and provide new comparison behavior - sorting Desc

            //int[] arr = new int[] { 5, 4, 7, 8, 9, 6, 3, 0, 2 };
            //Array.Sort(arr, new IntDescComparer());

            //foreach (var num in arr)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion

        }
    }
}
