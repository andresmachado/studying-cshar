namespace OtherTasksNamespace {
    public class ExampleLists () {
        public static void Lists() {
            // Lists are a type of collection that can store multiple elements of the same type.
            // Lists are similar to arrays, but they are more flexible and can grow and shrink in size as needed.
            // IMPORTANT: They're passed by reference, so if you pass a list to a method and modify it, the changes will be reflected in the original list.
            
            // You can create a list of any type using the following notation:
            // List<Type> listName = new List<Type>(); 
            // or List<Type> listName = new List<Type> {item1, item2, item3}; or 
            // var listName = new int[]; or 
            // you can define the number of elements in the array: 
            // var listName = new int[5]; 
            // You can also initialize the array with values: 
            // var listName = new int[] {1, 2, 3, 4, 5}; or var listName = new int[5] {1, 2, 3, 4, 5};

            Console.WriteLine("\n----------------Lists----------------\n");
            var myArray = new int[] {1, 2, 3, 4, 5};
            var myArray2 = new int[5] {1, 2, 3, 4, 5};
            // Trying to add an element to an array that has been initialized with a fixed number of elements will result in an error.
            try {
                myArray[5] = 6;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
            // You can add elements to a list using the Add method:
            var myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine(myList);
            
            // You can also add a range of elements to a list using the AddRange method:
            var myList2 = new List<int>();
            // You can use collection expression to add elements to the list like: myList2.AddRange([1, 2, 3, 4, 5]);
            myList2.AddRange(new int[] {1, 2, 3, 4, 5});
            Console.WriteLine(myList2);

            // You can remove elements from a list using the Remove method:
            var myList3 = new List<int>();
            myList3.AddRange(new int[] {1, 2, 3, 4, 5});
            myList3.Remove(3);
            Console.WriteLine(myList3);

            // It's possible to create a list of custom structs or classes:
            var myList4 = new List<MyStruct>();
            myList4.Add(new MyStruct { MyProperty = 1 });
            myList4.Add(new MyStruct { MyProperty = 2 });
            myList4.Add(new MyStruct { MyProperty = 3 });
            Console.WriteLine(myList4[0].MyProperty); // This will print 1
            Console.WriteLine(myList4[1].MyProperty); // This will print 2

            // You can iterate through a list using a foreach loop:
            var myList5 = new List<int>();
            myList5.AddRange([1, 2, 3, 4, 5]);
            Console.WriteLine("\n----------------Foreach loop----------------\n");
            foreach (var item in myList5)
            {
                Console.WriteLine(item);
            }

            // You can also use the Count property to get the number of elements in a list:
            Console.WriteLine("\n---------------- Count----------------\n");
            var myList6 = new List<int>();
            myList6.AddRange([1, 2, 3, 4, 5]);
            Console.WriteLine($"myList6.Count - {myList6.Count}"); // This will print 5

            // You can use Count to iterate through a list:
            var myList7 = new List<int>();
            myList7.AddRange([1, 2, 3, 4, 5]);
            Console.WriteLine("\n----------------For loop with Count----------------\n");
            for (int i = 0; i < myList7.Count; i++)
            {
                Console.WriteLine(myList7[i]);
            }
        }
    }
    struct MyStruct
    {
        public int MyProperty { get; set; }
    }
}