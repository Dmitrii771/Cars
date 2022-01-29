using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Field
    {
        private int[,] _field = new int[10, 10];

        public Field()
        {
            
        }

        public void SetShip(int coords)
        {
            int f = (coords - coords % 10) / 10;
            int s = coords % 10;
            _field[f, s] = 7;
        }

        public void Show()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(_field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
