using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeros
{
    /// <summary>
    /// _heroName, _heroOrganization, _power, _costume, _moral, _sidekick, _mask
    /// 
    /// </summary>
    public class Hero
    {
        private string _heroName;
        private string[] _heroOrganization;
        private string[] _power;
        private string _costume;
        private string _moral;
        private bool _sidekick;
        private bool _mask;

        public string HeroName
        {
            get { return _heroName; }
            private set { _heroName = value; }
        }
    }
}
