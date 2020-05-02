using System;

namespace SnailRace
{
    static class Factory
    {
        static private string[] _names = Properties.Resources.Names.Split(Convert.ToChar("\n"));
        static private Random _random = new Random();//used to generate different types of beters

        /// <summary>
        /// Creates and returns an array of 'howMany' Beters of random types
        /// </summary>
        /// <param name="howMany"></param>
        /// <returns>Beter[]</returns>
        static public Beter[] GenerateBeters(int howMany)
        {
            Beter[] betersArray = new Beter[howMany];
            for (int i = 0; i < howMany; i++)
            {
                switch (_random.Next(1, 20))
                {
                    case 1:
                        betersArray[i] = new Rich();//has $50
                        break;
                    case 2:
                        betersArray[i] = new Normal();//has $50
                        break;
                    default:
                        betersArray[i] = new Poor();//has $50
                        break;
                }
                betersArray[i].Name = _names[_random.Next(0, _names.Length)];//select a random name from the list of names
            }
            return betersArray;
        }

        /// <summary>
        /// Creates and returns an array of 'howMany' Snails
        /// </summary>
        /// <param name="howMany"></param>
        /// <returns>Snail[]</returns>
        static public Snail[] GenerateSnails(int howMany)
        {
            Snail[] snailArray = new Snail[howMany];
            for (int i = 0; i < howMany; i++)
            {
                snailArray[i] = new Snail();
            }
            return snailArray;
        }
    }
}
