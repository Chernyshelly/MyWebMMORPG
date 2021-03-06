﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMMO.GameCore.Triggers;

namespace WebMMO.GameCore.ItemCore
{
    public enum ItemRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }
    public interface IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemRarity Rarity { get; set; }
        public int GoldValue { get; set; }
        public bool isUsable { get; set; }
        public void ActionOnProc(Trigger trigger);
    }
}
