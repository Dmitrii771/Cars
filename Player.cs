using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Player
    {
        Ship ship1_1 = new Ship("1", "1", "4") { Size = 1 };
        Ship ship1_2 = new Ship("1", "1", "4") { Size = 1 };
        Ship ship1_3 = new Ship("1", "1", "4") { Size = 1 };
        Ship ship1_4 = new Ship("1", "1", "4") { Size = 1 };

        Ship ship2_1 = new Ship("2", "2", "3") { Size = 2 };
        Ship ship2_2 = new Ship("2", "2", "3") { Size = 2 };
        Ship ship2_3 = new Ship("2", "2", "3") { Size = 2 };

        Ship ship3_1 = new Ship("3", "3", "2") { Size = 3 };
        Ship ship3_2 = new Ship("3", "3", "2") { Size = 3 };

        Ship ship4_1 = new Ship("4", "4", "1") { Size = 4 };

        private static List<Ship> _ships;

        public string Name { get; set; }

        public Player()
        {
            _ships = new List<Ship>() { ship1_1, ship1_2, ship1_3, ship1_4, ship2_1, ship2_2, ship2_3, ship3_1, ship3_2, ship4_1 };
        }

        public int Set(int c, string pos)
        {
            int first = Int32.Parse(pos[0].ToString()); // Правильно преобразовать символ в число
            int second = Int32.Parse(pos[1].ToString());
            int result = Int32.Parse(first.ToString() + second.ToString());
            return result;
        }

        public string Move()
        {
            return "";
        }

    }
}
