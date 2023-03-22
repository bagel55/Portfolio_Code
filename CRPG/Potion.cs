﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class Potion: Item
    {
        public int AmountToHeal;

        public Potion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
