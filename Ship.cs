using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    enum Direction
    {
        vertical = 0,
        horizontal
    }
    class Ship : Transport
    {
        public int Size { get; set; }
        public Direction Direction { get; set; }

        public Ship(string mark, string model, string number)
           : base(mark, model, number) { }
        public override void Move()
        {
            Console.WriteLine("Корабль плывет");
        }
    }
}
