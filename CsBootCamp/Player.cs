using System;
using System.Collections.Generic;
using System.Text;

namespace _22PMbootcamp
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }

        public Player() { }

        public Player(int iD, string name, int health)
        {
            ID = iD;
            Name = name;
            Health = health;
        }
    }
}
