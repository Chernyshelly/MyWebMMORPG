﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMMO.Models;

namespace WebMMO.GameCore
{
    public class Character : User
    {
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
    }
}
