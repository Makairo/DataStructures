using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> MyList = new LinkedList<int>();
            LinkedList<string> MyStringList = new LinkedList<string>();


            MyList.Append(54);
            MyList.Append(56);
            MyList.Append(67);
            MyList.Append(78);
            MyList.Print();


            MyStringList.Append("Hello");
            MyStringList.Append("my");
            MyStringList.Append("name");
            MyStringList.Append("is");
            MyStringList.Append("Andrew");
            MyStringList.Print();
        }
    }
}
