using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMMO.Models;

namespace WebMMO.GameCore
{
    public enum CharacterClass
    {
        Bogatyr,
        Rogue,
        Priest
    }
    public class Character
    {
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public CharacterClass Class { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
    }
}
