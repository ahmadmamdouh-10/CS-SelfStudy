using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    #region Employee Class Implemented IComparable
    class Employee:IComparable
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }

        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            if (Salary < e.Salary)
            {
                return -1;

            }
            else if (Salary > e.Salary)
            {
                return 1;
            }
            else return 0;

        }
    }
    #endregion

    #region EmployeeComparer Class Implement Icomparer
    //class EmployeeComperer:IComparer<Employee>
    // {
    //     public int Compare(Employee emp1, Employee emp2)
    //     {
    //         return emp1.ID.CompareTo(emp2.ID);
    //     }

    // } 
    #endregion

    #region MyList implementation with IEnumerable & InnerClass Iterator
    //class myList : IEnumerable 
    //{
    //    Employee[] arr;
    //    int index; 

    //    public myList()
    //    {
    //        arr = new Employee[10];
    //        index = -1;
    //    }

    //    public void Add(Employee emp)
    //    {
    //        ++index;
    //        if (index > arr.Length - 1)
    //        {
    //            Extend();
    //        } else
    //        {
    //            arr[index] = emp;
    //        }
    //    }


    //    public Employee Get(int index)
    //    {
    //        return arr[index];
    //    }

    //    private void Extend()
    //    {

    //    }

    //    public IEnumerator GetEnumerator()
    //    {
    //        return new iterator(this);
    //    }

    //    class iterator : IEnumerator
    //    {
    //        myList myList;
    //        int currentIndex = -1;
    //        public iterator(myList myList)
    //        {
    //            this.myList = myList;
    //        }
    //        public object Current
    //        {
    //            get
    //            {
    //                return myList.arr[currentIndex];
    //            }
    //        }
    //        public bool MoveNext()
    //        {
    //            currentIndex++;
    //            if(currentIndex > myList.index)
    //            {
    //                return false;
    //            }
    //            else
    //            {
    //                return true;
    //            }
    //        }

    //        public void Reset()
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }





    //} 
    #endregion

    #region InnerClass Idea
    //class A
    //{
    //    int x;
    //    class B
    //    {
    //        int y;

    //        public B()
    //        {
    //            A a = new A();
    //            a.x = 10;   
    //        }
    //    }
    //} 
    #endregion

    #region Indexer 
    //public class ListBoxTest
    //{
    //    // initialize the list box with strings
    //    public ListBoxTest(params string[] initialStrings)
    //    {
    //        // allocate space for the strings
    //        strings = new String[256];
    //        // copy the strings passed in to the constructor
    //        foreach (string s in initialStrings)
    //        {
    //            strings[ctr++] = s;
    //        }
    //    }
    //    // add a single string to the end of the list box
    //    public void Add(string theString)
    //    {
    //        strings[ctr] = theString;
    //        ctr++;
    //    }
    //    // allow array-like access
    //    public string this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index >= strings.Length)
    //            {
    //                // handle bad index
    //            }
    //            return strings[index];
    //        }
    //        set
    //        {
    //            strings[index] = value;
    //        }
    //    }
    //    private int findString(string searchString)
    //    {
    //        for (int i = 0; i < strings.Length; i++)
    //        {
    //            if (strings[i].StartsWith(searchString))
    //            {
    //                return i;
    //            }
    //        }
    //        return -1;
    //    }
    //    // index on string
    //    public string this[string index]
    //    {
    //        get
    //        {
    //            if (index.Length == 0)
    //            {
    //                // handle bad index
    //            }
    //            return this[findString(index)];
    //        }
    //        set
    //        {
    //            strings[findString(index)] = value;
    //        }
    //    }
    //    // publish how many strings you hold
    //    public int GetNumEntries()
    //    {
    //        return ctr;
    //    }
    //    private string[] strings;
    //    private int ctr = 0;
    //} 
    #endregion



    class Program
    {
       
        static void Main(string[] args)
        {
            #region Self-Study
            #region Already Studied
            /*
                * What is done?
                * ===============
                * 1-  console
                * 2-  built in datatypes 
                * 3-  string datatype 
                * 4-  C# Operators
                * 5-  nullable type 
                * 6-  data type conversion
                * 7-  arrays
                * 8-  comments 
                * 9-  if, switch
                * 10- while,do while 
                * 11- for,foreach {break & continue }
                * 12- methods 
                * 13- namespaces
                * 14- classes & Sealed Classes(cannot inherit from it)
                * 15- static methods 
                * 16- Inheritance
                * 17- Method Hiding
                * 18- polymorhpism
                * 19- method overriding vs hiding
                * 20- method overlooding
                * 21- Properties 
                * 21- Structs 
                * 22- Differences between Classes & structs
                * 23- Interface
                * 24- Explicit Implenetation of Interface
                * 25- Abstract Classes
                * 26- Enums
                * 27- Access Modifiers
                * 28- Types vs type members
                * 30- Generics 
                * 31- Why should we override ToString method 
                * 32- Difference between Convert.ToString & ToString
                * 33- Partial Classes
                * 34- Indexers
                * 35- 
                * */
            #endregion


            #region Questions Need to be asked
            /*
                 * Question: 
                 * ==========
                 * 
                 * 1- 
                 * 2- 
                 * 3-
                 */
            #endregion


            #region To Do List
            /*
                 * To Do List{Need}
                 * ================
                 * 
                 * 1- Delegates {36}
                 * 2- MultiCast Delegates{39}
                 * 3- Exception Handling{40}
                 * 4- Inner Exception {41}
                 * 5- custom Exception{42}
                 * 6- Exception Handling Abuse{43}
                 * 7- Preventing Exception Handling Abuse{44}
                 * 8- Internal & Protected Internal Access Modifiers{50}
                 * 9- Attributes {52}
                 * 10- Reflection {53}
                 * 11- Late binding using Reflection{55}
                 * 12- Why should we override Equals method{58} 
                 * 13- Difference between System String and System Text String Builder{60}
                 * 14- Stopped on {67}
                 * 
                 */
            #endregion
            #endregion
            #region IComparerUsage
            //Employee[] arr = new Employee[3];
            //arr[0] = new Employee { ID = 1, Name = "Ahmed", Salary = 2000 };
            //arr[1] = new Employee { ID = 2, Name = "Ahmed", Salary = 3000 };
            //arr[2] = new Employee { ID = 3, Name = "Ahmed", Salary = 4000 };


            //Array.Sort(arr, new EmployeeComperer()); 
            #endregion


            #region IEnumberable interface for using foreach
            //myList myList = new myList();

            //myList.Add(new Employee { ID = 1, Name = "Ahmed", Salary = 2000 });
            //myList.Add(new Employee { ID = 2, Name = "Ahmed", Salary = 2000 });
            //myList.Add(new Employee { ID = 3, Name = "Ahmed", Salary = 2000 });

            ///*
            // * foreach Alone Cannot reach array in myList
            // *   because
            // * 1- array is Private
            // * 2- cannot what it will loop in
            // * so to foreach works it must be a "Waseet ma benhom"
            // * can access the arr. 
            // * 
            // * l waseet will be an Inner Class
            // * 
            // * 
            // * 
            // * IEnumerator iterator = myList.GetEnumerator();
            // * 
            // * while(iterator.MoveNext())
            // * {
            // *       Employee emp=(Employee)iterator.Current
            // *       Console.WriteLine(emp);
            // * }



            //*/
            //foreach (Employee emp in myList)
            //{
            //    Console.WriteLine(emp.ID);

            //} 
            #endregion

            #region Class List Collection
            //List< Employee > myList = new List<Employee>();

            //myList.Add(new Employee { ID = 1, Name = "Ahmed", Salary = 2000 });
            //myList.Add(new Employee { ID = 2, Name = "Ahmed", Salary = 2000 });
            //myList.Add(new Employee { ID = 3, Name = "Ahmed", Salary = 2000 });
            //myList.Add(new Employee { ID = 4, Name = "Ahmed", Salary = 2000 });
            //myList.Add(new Employee { ID = 5, Name = "Ahmed", Salary = 2000 });

            //Console.WriteLine(myList.Count()); 
            #endregion

            #region Dictionary Collection & foreach inderxer
            ////Dictionary<int, Employee> dic = new Dictionary<int, Employee>();

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "A");
            //dic.Add(2, "A");
            //dic.Add(3, "A");
            //dic.Add(4, "A");
            //dic.Add(5, "A");
            //dic.Add(6, "A");
            //dic.Add(7, "A");
            //dic.Add(8, "A");
            //dic.Add(9, "A");
            //dic.Add(10, "A");
            //dic.Add(11, "A");
            //dic.Add(12, "A");
            //dic.Add(13, "A");
            //dic.Add(14, "A");


            //if (dic.ContainsKey(1))
            //{
            //    string s = dic[1];
            //    Console.WriteLine(s); 
            //}


            //foreach (KeyValuePair<int, string> kvp in dic)
            //{
            //    Console.WriteLine(kvp);
            //}

            //Console.WriteLine(dic.ContainsKey(5)); 
            #endregion

            #region Using The params keyword 
            //Program p = new Program();
            //p.DisplayVals(5, 6, 7, 8);

            //int[] explicitArray = new int[5] { 1, 2, 3, 4, 5 };

            //p.DisplayVals(explicitArray); 
            #endregion


            #region Rectangle Array


            /*
         * C# supports two types of multidimensional arrays: rectangular and jagged. In a rectangular
           array, every row is the same length. A jagged array, however, is an array of arrays, each of
           which can be a different length.
         */

            //const int rows = 7;
            //const int columns = 4;
            //// declare a 4x3 integer array
            //int[,] rectangularArray = new int[rows, columns];

            //// populate the array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        rectangularArray[i, j] = i + j;
            //    }
            //}
            //// report the contents of the array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.WriteLine("rectangularArray[{0},{1}] = {2}",
            //        i, j, rectangularArray[i, j]);
            //    }
            //} 
            #endregion

            #region Jagged Array 

            //const int rows = 4;
            //// declare the jagged array as 4 rows high
            //int[][] jaggedArray = new int[rows][];
            //// the first row has 5 elements
            //jaggedArray[0] = new int[5];
            //// a row with 2 elements
            //jaggedArray[1] = new int[2];
            //// a row with 3 elements
            //jaggedArray[2] = new int[3];
            //// the last row has 5 elements
            //jaggedArray[3] = new int[5];
            //// Fill some (but not all) elements of the rows
            //jaggedArray[0][3] = 15;
            //jaggedArray[1][1] = 12;
            //jaggedArray[2][1] = 9;
            //jaggedArray[2][2] = 99;
            //jaggedArray[3][0] = 10;
            //jaggedArray[3][1] = 11;
            //jaggedArray[3][2] = 12;
            //jaggedArray[3][3] = 13;
            //jaggedArray[3][4] = 14;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("jaggedArray[0][{0}] = {1}",
            //    i, jaggedArray[0][i]);
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("jaggedArray[1][{0}] = {1}",
            //    i, jaggedArray[1][i]);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("jaggedArray[2][{0}] = {1}",
            //    i, jaggedArray[2][i]);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("jaggedArray[3][{0}] = {1}",
            //    i, jaggedArray[3][i]);
            //} 
            #endregion


            #region Lambda Expression
            //    // List to store numbers
            //    List<int> numbers = new List<int>() {36, 71, 12,
            //                     15, 29, 18, 27, 17, 9, 34};

            //    // for each loop to display the list
            //    Console.Write("The list : ");
            //    foreach (var value in numbers)
            //    {
            //        Console.Write("{0} ", value);
            //    }
            //    Console.WriteLine();

            //    // Using lambda expression
            //    // to calculate square of
            //    // each value in the list
            //    var square = numbers.Select(x => x * x);

            //    // for each loop to display squares
            //    Console.Write("Squares : ");
            //    foreach (var value in square)
            //    {
            //        Console.Write("{0} ", value);
            //    }
            //    Console.WriteLine();

            //    // Using Lambda expression to
            //    // find all numbers in the list
            //    // divisible by 3
            //    List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            //    //for each loop to display divBy3
            //    Console.Write("Numbers Divisible by 3 : ");
            //    foreach (var value in divBy3)
            //    {
            //        Console.Write("{0} ", value);
            //    }
            //    Console.WriteLine();
            //} 
            #endregion


























        }
        #region DisplayVals using Key word params
        //public void DisplayVals(params int[] intVals)
        //{
        //    foreach(int i in intVals)
        //    {
        //        Console.WriteLine(i);
        //    }

        //} 
        #endregion
    }
}
