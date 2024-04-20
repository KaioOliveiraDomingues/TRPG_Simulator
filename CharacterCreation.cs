using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_Simulator.ConsoleApp
{
    public class Character
    {
        public static int Counter;
        private int Id;
        public String? Name;
        public int Age;
        public String Race;
        public String Class;
        public enum Races
        {
            Human = 0,
            Elf = 1,
            Dwarf = 2,
            Golem = 3,
            Goblin = 4,
            Orc = 5,
            Half_Elf = 6,
            Halfling = 7,
            Gnomes = 8,
            Draconic = 9,
        }
        public enum Classes
        {
            Warrior = 0,
            Mage = 1,
            Druid = 2,
            Berserker = 3,
            Paladin = 4,
            Ranger = 5,
            Thief = 6,
            Cleric = 7,
            Witch = 8,
            Monk = 9,
            Artificer = 10,
            Guardian = 11,
            Bard = 12,
        }
        public Atributtes Atributtes;

        public Character(String Name, int Age, int Race, int Class) 
        {
            this.Id = ++Counter;
            this.Name = Name;
            this.Age = Age;
            //Definindo Raça
            Races races = (Races)Race;
            this.Race = races.ToString();
            //Definindo Classe
            Classes clas = (Classes)Class;
            this.Class = clas.ToString();
            //Criando atributos (ainda só aleatorios)
            this.Atributtes = new Atributtes(this.Id);
        }

        public void ReturnCharacter()
        {
            Console.WriteLine("ID: " + this.Id + " Name: " + this.Name + " Age: " + this.Age + " Race: " + this.Race + " Class: " + this.Class);
            Console.WriteLine("Str: " + this.Atributtes.Strenght + " Dex: " + this.Atributtes.Dexterity + " Con: " + this.Atributtes.Constitution
                + " Int: " + this.Atributtes.Intelligence + " Agi: " + this.Atributtes.Agility + " Wis: " + this.Atributtes.Wisdom + " Chr: " + this.Atributtes.Charisma);
        }

    }

    public class Atributtes
    {
        private int Id;
        public int Strenght;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Agility;
        public int Wisdom;
        public int Charisma;

        public Atributtes(int Id, int Strenght, int Dexterity, int Constitution, int Intelligence, int Agility, int Wisdom, int Charisma)
        {
            this.Id = Id;
            this.Strenght = Strenght;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intelligence = Intelligence;
            this.Agility = Agility;
            this.Wisdom = Wisdom;
            this.Charisma = Charisma;
        }
        public Atributtes(int Id)
        {
            Random random = new Random();
            this.Id = Id;
            this.Strenght = random.Next(6, 19);
            this.Dexterity = random.Next(6, 19);
            this.Constitution = random.Next(6, 19);
            this.Intelligence = random.Next(6, 19);
            this.Agility = random.Next(6, 19);
            this.Wisdom = random.Next(6, 19);
            this.Charisma = random.Next(6, 19);
        }

    }
}
