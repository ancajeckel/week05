using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Producer : IProducer
    {
        private List<string> ProducerList = new List<string>() { "Ford", "Skoda", "Renault" };

        public string Name { get; private set; }

        public Producer(string name)
        {
            if (name != null && ProducerList.Contains(name))
            {
                this.Name = name;
            }
        }

        public void PrintProducerDetail()
        {
            Console.WriteLine($"Producer {this.Name}");
        }
    }
}
