using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Firm.The_Firm;

namespace The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectManager projectManager = new ProjectManager();
            Sweeper sweeper = new Sweeper();

            projectManager.ShowProjectManager();
            sweeper.ShowSweeper();
        }
    }
}
