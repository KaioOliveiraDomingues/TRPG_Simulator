using System;

namespace TRPG_Simulator.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Character Creation feature branch");
            Character personagem = new Character("Douglas", 23, 6, 2);
            personagem.ReturnCharacter();

        }
    }
    
}



