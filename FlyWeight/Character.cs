using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Character
    {
        private char symbol;

        public Character(char symbol)
        {
            this.symbol = symbol;
        }

        public void Print()
        {
            Console.Write(symbol);
        }
    }

    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char symbol)
        {
            if (!characters.ContainsKey(symbol))
            {
                characters[symbol] = new Character(symbol);
            }

            return characters[symbol];
        }
    }

}
