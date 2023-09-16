using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind.Model
{
    public class Dictionary
    {
        Dictionary<string, int> _dictionary = new Dictionary<string, int>();


        public Dictionary<string, int> AddValues()
        {
            if (!_dictionary.Any())
            {
                _dictionary.Add("Luke", 37);
                _dictionary["DarthVader"] = 29;
                _dictionary.Add("Han", 14);
            }
            return _dictionary;
        }
        public Dictionary<string, int> Remove()
        {
            _dictionary.Remove("Han");
            return _dictionary;
        }
        public Dictionary<string, int> Remaining()
        {
            return _dictionary;
        }
    }
}
