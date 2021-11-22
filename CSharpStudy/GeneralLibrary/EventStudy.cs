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
}
