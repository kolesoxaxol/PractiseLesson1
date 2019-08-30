using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class Input
    {
        public static int Validation(int size, string text)
        {
            int menuSelect;
            string menuSelectResult;
            bool menuOptionResult;
            bool menuOption;
            do
            {
                Console.WriteLine(text);
                menuSelectResult = Console.ReadLine();
                menuOption = int.TryParse(menuSelectResult, out menuSelect);
                if (menuOption == true)
                {
                    if (menuSelect < 0 || menuSelect > size)
                    {
                        do
                        {
                            Console.WriteLine($"Plese, select from 0 to {size}.");
                            menuSelectResult = Console.ReadLine();
                            menuOption = int.TryParse(menuSelectResult, out menuSelect);
                            if (0 < menuSelect && menuSelect <= size)
                            {
                                menuOptionResult = true;
                            }
                            else
                            {
                                menuOptionResult = false;
                            }
                        }
                        while (!menuOptionResult);
                    }
                }
            }
            while (!menuOption);

            return menuSelect;
        }
    }
}
