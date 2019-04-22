using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_StructuredSample
{
    // The 'ConcreteObserver' class
    public class ConcreteObserver : Observer
    {
        string name;
        string observerState;
        ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
                name, observerState);
        }

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
