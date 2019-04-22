using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_StructuredSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // configure observer pattern
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject, "John"));
            subject.Attach(new ConcreteObserver(subject, "Deo"));

            // change subject state and notify observers
            subject.SubjectState = "Test";
            subject.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
