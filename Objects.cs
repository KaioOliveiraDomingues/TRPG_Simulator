using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_Simulator.ConsoleApp
{
    public class ItemTeste
    {
        static int counter;
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public void createItem(string Name, string Description)
        {
            this.Id = counter++;
            this.Name = Name;
            this.Description = Description;
        }

        public void returnItem()
        {
            Console.WriteLine("Id = " +  Id + "/ Name = " + Name + "/ Description = " + Description);
        }

    }

}
