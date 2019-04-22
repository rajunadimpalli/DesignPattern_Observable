using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_StructuredSample
{

    public class ConcreteSubject : Subject
    {
        string subjectState;
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
