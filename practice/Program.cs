// using System;
// using System.IO;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Data;

// namespace Project
// {
//     /*
//     class Student{
//         public string name, city;
//         public int age, id;
//         public Student(string name, int id, int age, string city){
//             this.name = name;
//             this.id = id;
//             this.age = age;
//             this.city = city;
//         }
//         public void showDetails()=>Console.WriteLine($"Name: {name}\tID: {id}\tAge: {age}\t City: {city}");

//         public static bool operator<(Student a, Student b)=>a.age>b.age;
//         public static bool operator>(Student a, Student b)=>a.age>b.age;
//     }

//     public static class ListExtension2{
//         public delegate TResult ExtensionDelegate<TSource, TResult>(TSource x);
//         public static IEnumerable<TResult> MySelect<TSource, TResult>(this List<TSource> source, ExtensionDelegate<TSource, TResult> extnsionFunc){
//             foreach(var i in source){
//                 yield return extnsionFunc(i);
//             }
//         }
//     }
//     */


//     /*
//     class Person
//     {
//         public string[] phoneNumbers = new string[3];
//         public string[] phoneNumbers2 = new string[3];

//         // Simple indexer without validation
//         public string this[int index]
//         {
//             get { return phoneNumbers[index]; }
//             set { phoneNumbers[index] = value; }
//         }
//     }
//     */


//     class Geeks
//     {
//         private string name;
//         private int age;
//         public Geeks(Geeks g)
//         {
//             this.name = g.name;
//             this.age = g.age;
//         }
//         public Geeks(string name, int age)
//         {
//             this.name = name;
//             this.age = age;
//         }
//         public void Show() => System.Console.WriteLine($"{name} -- {age}");
//     }

//     class Person
//     {
//         public string Name { get; private set; }
//         public int Age { get; private set; }
//         public void SetName(string name)=>Name=name;
//         public void SetAge(int age)=>Age=age;
//         public override string ToString()=>$"{Name}, {Age}";
//     }

//     class Program
//     {
//         static void Main()
//         {
//             Console.Clear();

//             var person=new Person();
//             person.SetName("Shajid");
//             person.SetAge(20);
//             System.Console.WriteLine(person);


//             // var file=File.Create("shajid.txt");
//             // file.Close();
//             // using(StreamWriter write=new StreamWriter("shajid.txt")){
//             //     write.WriteLine("2104095");
//             // }


//             // Geeks g1=new Geeks("Shajid", 21);
//             // g1.Show();
//             // Geeks g2=new Geeks(g1);
//             // g2.Show();

//             /*
//             Person person = new Person();

//             // Setting phone numbers using the indexer
//             person[0] = "123-456-7890";
//             person[1] = "987-654-3210";
//             person[2] = "555-123-4567";

//             // Getting and displaying phone numbers using the indexer
//             Console.WriteLine("Phone Numbers:");
//             Console.WriteLine("1. " + person[0]);
//             Console.WriteLine("2. " + person[1]);
//             Console.WriteLine("3. " + person[2]);
//             */




//             /*
//             List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//             List<int> numbers2 = new List<int> { 1, 5, 6 };

//             var doubledNumbers = numbers.Except(numbers2);

//             foreach (int number in doubledNumbers)
//             {
//                 Console.WriteLine(number);
//             }
//             */



//             // string fPath="./test.txt";
//             // var newFile=File.Create(fPath);
//             // newFile.Close();

//             /*
//             string[] lines={
//                 "Hello World",
//                 "Bye World",
//                 DateTime.Now.ToString()
//             };
//             File.WriteAllLines(fPath, lines);
//             string[] readLines=File.ReadAllLines(fPath);
//             foreach(string line in readLines) System.Console.WriteLine(line);
//             */


//             /*
//             StreamWriter writer=null;
//             try{
//                 writer = new StreamWriter(fPath);
//                 string[] lines={
//                     "Hello World", 
//                     "Bye World", 
//                     DateTime.Now.ToString()
//                 };
//                 foreach(string line in lines) writer.WriteLine(line);
//                 string line;
//                 using((line=))
//             }catch(Exception err){
//                 Console.WriteLine($"Error: {err.Message}");
//             }finally{
//                 writer.Close();
//             }

//             StreamReader reader=null;
//             try{
//                 reader = new StreamReader(fPath);
//                 string line;
//                 while((line=reader.ReadLine())!=null) System.Console.WriteLine(line);
//             }catch(Exception err){
//                 Console.WriteLine($"Error: {err.Message}");
//             }finally{
//                 reader.Close();
//             }
//             */



//             /*
//             List<Student> students=new List<Student>{
//                 new Student("Shajid", 1, 20, "Chittagong"),
//                 new Student("John", 2, 22, "Dhaka"),
//                 new Student("Alice", 3, 21, "Rajsahi"),
//                 new Student("Bob", 4, 23, "Chittagong"),
//                 new Student("Emma", 5, 20, "Dhaka"),
//                 new Student("Alex", 6, 22, "Rajsahi"),
//                 new Student("Eva", 7, 21, "Chittagong"),
//                 new Student("David", 8, 23, "Dhaka"),
//                 new Student("Sophia", 9, 20, "Rajsahi"),
//                 new Student("Michael", 10, 22, "Chittagong")
//             };

//             System.Console.WriteLine("\n\n---------------");
//             foreach(var i in students.Where((a)=>a.age>20)) i.showDetails();

//             System.Console.WriteLine("\n\n---------------");
//             foreach(var i in students.Where(a=>a.age==students.Min(b=>b.age))) i.showDetails();

//             System.Console.WriteLine("\n\n---------------");
//             foreach(var i in students.OrderByDescending((a)=>a.age)) i.showDetails();

//             var s = students.Select(a=>a.age==20);

//             try{
//                 students.Find(a=>a.age==224).showDetails();

//             }catch(Exception e){
//                 System.Console.WriteLine($"Error: {e.Message}");
//             };
//             */

//             // List2 x = new List2();
//             // x.Add(1);
//             // x.Add(2);
//             // x.Add(3);
//             // x.Add(4);
//             // x.Add(5);
//             // foreach(var i in x) System.Console.WriteLine(i);

//             // List<int> list=new List<int>{1,2,3,4,5};
//             // list.Remove(list.Where(e=>e>3).ToList()[0]);
//             // foreach(var i in list) System.Console.WriteLine(i);


//         }
//     }
// }
using System;
namespace Termfinal
{
    class CustomCollection<T>
    {
        private T[] customCollection;
        private int index = 0;
        public CustomCollection(int capacity)
        {
            this.Capacity = capacity;
            customCollection = new T[capacity];
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.index)
                {
                    throw new IndexOutOfRangeException();
                }
                return customCollection[index];
            }
            set
            {
                if (index < 0 || index >= this.index)
                {
                    throw new IndexOutOfRangeException();
                }
                customCollection[index] = value;
            }
        }
        public int Capacity { get; }
        public int Count => index;
        public void Add(T value)
        {
            if (index == customCollection.Length)
            {
                throw new InvalidOperationException("Collection is at maximum capacity.");
            }
            customCollection[index] = value;
            index++;
        }
        public void RemoveAt(int x)
        {
            if (x < 0 || x >= index)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = x; i < index - 1; i++)
            {
                customCollection[i] = customCollection[i + 1];
            }
            index--;
        }
        public void Clear()
        {
            Array.Clear(customCollection, 0, customCollection.Length);
            index = 0;
        }
        public override string ToString()
        {
            return string.Join(" ", customCollection[..index]);
        }
    }
    class Program
    {
        public static void Main()
        {
            CustomCollection<int> customCollection = new CustomCollection<int>(10);
            for (int i = 0; i < 10; i++)
            {
            customCollection.Add(i);
            }
            customCollection.RemoveAt(4);
            Console.WriteLine(customCollection.ToString());
        }
    }
}