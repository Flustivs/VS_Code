using Jedi_Mind.Model;
using Jedi_Mind.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind.Controller
{
    public class Controller
    {
        GUI GUI = new GUI();
        Dictionary Dictionary = new Dictionary();

        public void Start()
        {
            GUI.AllValues(Dictionary.AddValues());
            GUI.Writefirst(Dictionary.AddValues());
            GUI.Remove(Dictionary.Remove());
            GUI.AllValues(Dictionary.Remaining());
        }
    }
}
