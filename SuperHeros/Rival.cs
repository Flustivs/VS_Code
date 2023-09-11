using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeros
{
    /// <summary>
    /// _rivalname, _organization, _power, _costume, _sidekick, _mask
    /// 
    /// </summary>
    public class Rival
    {
        private string _rivalName;
        private string[] _organization;
        private string[] _power;
        private string _costume;
        private bool _sidekick;
        private bool _mask;

        public string Rivals
        {
            get { return _rivalName; }
            private set { _rivalName = value; }
        }
    }
}
