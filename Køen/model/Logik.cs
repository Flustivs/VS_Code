using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen.model
{
    /// <summary>
    /// Here i make the queue
    /// </summary>
    public class Logik
    {
        Queue<string> Playstations = new Queue<string>();

        public Queue<string> Queue
        {
            get { return Playstations; }
            set { Playstations = value; }
        }

    }
}
