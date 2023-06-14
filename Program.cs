using static Fundamentals.ArrayExample;
using static Fundamentals.ClassesAndObj;
using static Fundamentals.Animal;
namespace Fundamentals;
class Program
{
    //enum has fixed set of constants
    //enum improves type safety
    //enum can be traversed
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };



    static void Main(string[] args)
    {
        /*
         ArrayExample arrayExample = new ArrayExample();

        Console.WriteLine("One Dimentional Array: ");
        int[] SingleArr = { 10, 20, 30, 40 };
        arrayExample.singleDimentionArrayshow(SingleArr);

        Console.WriteLine("Two Dimentional Array: ");
        int[,] TwoDArr = new int[,] { { 10, 20 }, { 20, 10 } };
        arrayExample.TwoDimentionArrayshow(TwoDArr);


        Console.WriteLine("Jagged Array: ");
        int[][] jaggedArr = new int[2][];
        jaggedArr[0] =new int[]{ 11, 21, 56, 78 };
        jaggedArr[1] =new int[]{ 42, 61, 37, 41, 59, 63 };
        arrayExample.jaggedArray(jaggedArr);



        Console.WriteLine("Array Class");
        // Creating an array  
        int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
        // Creating an empty array  
        int[] arr2 = new int[6];
        // Displaying length of array  
        Console.WriteLine("length of first array: " + arr.Length);
        // Sorting array  
        Array.Sort(arr);
        Console.Write("First array elements: ");
        // Displaying sorted array  
        PrintArray(arr);
        // Finding index of an array element  
        Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
        // Coping first array to empty array  
        Array.Copy(arr, arr2, arr.Length);
        Console.Write("Second array elements: ");
        // Displaying second array  
        PrintArray(arr2);
        Array.Reverse(arr);
        Console.Write("\nFirst Array elements in reverse order: ");
        PrintArray(arr);

        */

        /*
        ClassesAndObj cob = new ClassesAndObj("Ford Aspire", "Ford", "Ambiente", 2100000000, 759846);
        cob.display();
        */

        /*
        Console.WriteLine("Value of PI is: " + StaticClass.PI);
        Console.WriteLine("Cube of 3 is: " + StaticClass.cube(3));
        */


        /*

        Console.WriteLine("Enum is in action: ");


         foreach (string d in Enum.GetNames(typeof(Days)))
        {
            Console.WriteLine(d);
        }


        foreach (Days d in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(d);
        }
        */



        /*
        BabyDog d1 = new BabyDog();
        d1.eat();
        d1.bark();
        d1.weep();
        */

        /*
        MethodOverriding mo = new MethodOverriding();
         mo.eat();
         */

        /*
        Rectangle rect = new Rectangle();
        rect.draw();
        AbstuctClassExample ab = new AbstuctClassExample();
        ab.draw();
         */

        /*
        Rectangles rect = new Rectangles();
        rect.draw();

        circles cir = new circles();
        cir.draw();
        */



        /*Collections*/


        //List collection
        var StringContainer = new List<string>();
        StringContainer.Add("Hey");
        StringContainer.Add("Srijan Kumar Khan");



        //HashSet collection
        var duplicateElement = new HashSet<string>();
        duplicateElement.Add("Data 1");
        duplicateElement.Add("Data 2");
        duplicateElement.Add("Data 3");
        duplicateElement.Add("Data 4");
        duplicateElement.Add("Data 1");

        //SortedSet collection
        var sortedElement = new SortedSet<string>();
        sortedElement.Add("Sonoo");
        sortedElement.Add("Ankit");
        sortedElement.Add("Peter");
        sortedElement.Add("Irfan");
        sortedElement.Add("Ankit");

        //Stack collection



        foreach (var items in StringContainer)
        {
            Console.Write(items + " ");
        }

        Console.WriteLine();

        foreach (var items in duplicateElement)
        {
            Console.Write(items + " ");
        }

        Console.WriteLine();

        foreach (var items in sortedElement)
        {
            Console.Write(items + " ");
        }

    }
}

