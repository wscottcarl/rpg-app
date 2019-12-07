using System.Collections.Generic;

namespace Rpg.Models
{
    public class Character 
    {
        public long Id {get; set;}
        public string Name {get; set;}
        public Race Race {get; set;}
        public @Class Class {get; set;}
        public List<Stat> Stats {get; set;}
        public List<Skill> Skills {get; set;}
        public Player Player {get; set;}
    }
}