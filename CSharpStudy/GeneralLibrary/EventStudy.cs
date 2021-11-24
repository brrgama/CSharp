using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary
{
    public class EventStudy
    {
        /*
        //This delegate can be used to point to methods
        //which return void and take a string.
        public delegate void MyEventHandler(string foo);

        //This event can cause any method which conforms
        //to MyEventHandler to be called.
        public event MyEventHandler SomethingHappened;

        //Here is some code I want to be executed
        //when SomethingHappened fires.
        void HandleSomethingHappened(string foo)
        {
            //Do some stuff
        }

        //I am creating a delegate (pointer) to HandleSomethingHappened
        //and adding it to SomethingHappened's list of "Event Handlers".
        myObj.SomethingHappened += new MyEventHandler(HandleSomethingHappened);

        //To raise the event within a method.
        SomethingHappened("bar");
        */

    }
}


namespace DelegateArticle
{
    public delegate string FirstDelegate(int x);

    public delegate int SecondDelegate(string value);

    public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
    
    public class DelegateTest
    {
        string name;

        public delegate void SecondDelegate(char a, char b);

        public static void Test()
        {
            FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);

            DelegateTest instance = new DelegateTest();
            instance.name = "My instance";

            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

            Console.WriteLine(d1(10)); // Writes out "Static method: 10"
            Console.WriteLine(d2(20)); // Writes out "My instance: 5"
        }

        static string StaticMethod(int i)
        {
            return string.Format("Static method: {0}", i);
        }

        string InstanceMethod(int i)
        {
            return string.Format("{0}: {1}", name, i);
        }
    }

    public class Test
    {
        public int ToDelegate(string message)
        {
            Console.WriteLine(message);
            return 0;
        }

        public bool Method(Func<string, int> myMethodName)
        {
            int i = myMethodName("My string");
            return true;
        }

        public void Method2()
        {
            Method(ToDelegate);
        }

        public event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("add operation");
            }
            remove
            {
                Console.WriteLine("remove operation");
            }
        }

        static void Main()
        {
            Test t = new Test();

            //t.MyEvent += EventHandler (t.DoNothing);
            t.MyEvent -= null;
        }

        void DoNothing(object sender, EventArgs e)
        {
        }
    }
}
