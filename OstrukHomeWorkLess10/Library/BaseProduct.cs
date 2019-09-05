using System;

namespace Library
{
    public class BaseProduct
    {
        private int shelfLife;
        protected int ShelfLife { get => shelfLife; set => shelfLife = value; }

        public DateTime DelayEmulator(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day + ShelfLife);
        }
    }
}
