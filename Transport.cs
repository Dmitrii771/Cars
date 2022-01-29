using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    abstract class Transport
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }

        public Transport(string mark, string model, string number)
        {
            Mark = mark;
            Model = model;
            Number = number;
        }

        abstract public void Move();
        public void ShowInfo()
        {
            Console.WriteLine($"Mark: {Mark}, Model: {Model}, Number: {Number}");
        }

    }
}
