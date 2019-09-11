using System.Collections.Generic;
using System.Linq;

namespace Task5Library
{
    public static class Bouquet
    {
        private static List<Flower> flowers = new List<Flower>();

        public static void Add(Flower flower)
        {
            flowers.Add(flower);
        }

        public static void Remove(Flower flower)
        {
            flowers.Remove(flower);
        }

        public static List<Flower> Flowers()
        {
            return flowers;
        }

        public static double TotalCost()
        {
            return flowers.Select(s => s.Price()).Sum();
        }

        public static string Contains()
        {
            int rose = 0;
            int tulip = 0;
            int clove = 0;

            foreach (var a in flowers)
            {
                if (a is Rose)
                    rose++;
                if (a is Tulip)
                    tulip++;
                if (a is Clove)
                    clove++;
            }

            List<string> strings = new List<string>();

            if (rose != 0)
                strings.Add($"{rose} roses");
            if (tulip != 0)
                strings.Add($"{tulip} tulips");
            if (clove != 0)
                strings.Add($"{clove} cloves");

            return string.Join(", ", strings.ToArray());
        }
    }
}
