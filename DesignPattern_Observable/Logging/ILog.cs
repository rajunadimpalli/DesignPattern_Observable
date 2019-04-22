using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Observable.Logging
{
    // This interface defines a single method to write requested log to an output device
    public interface ILog
    {
        // Write log request to a given output device
        void Log(object sender, LogEventArgs e);
    }
}
