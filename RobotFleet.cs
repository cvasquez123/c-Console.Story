using System;
using System.Collections.Generic;
using System.Text;

namespace Story
{
    class RobotFleet : Robot
    {
        public string _mood { get; set; }

        public RobotFleet(String name, int strength, string mood) : base (name, strength)
        {
            _name = name;
            _mood = mood;
            _strength = strength;
            

        }
    }
}
