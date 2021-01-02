using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMMO.GameCore.EffectCore;

namespace WebMMO.GameCore.ItemCore
{
    public interface IEquipment : IItem
    {
        public int Level { get; set; }
        public int StrengthBonus { get; set; }
        public int AgilityBonus { get; set; }
        public int IntelligenceBonus { get; set; }
        public List<IEffect> Effects { get; set; }
    }
}
