using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMMO.Models
{
    public enum CharacterClass
    {
        Bogatyr,
        Rogue,
        Priest
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public CharacterClass Class { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
    }
}
