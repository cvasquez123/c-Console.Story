using System;
using System.Collections.Generic;
using System.Text;

namespace Story
{
    class Robot 
    {
        public string _name { get; set; }
        public int _strength { get; set; }

        public Robot( string name, int strength)
        {
            _name = name;
            _strength = strength;

        }

    }
}
