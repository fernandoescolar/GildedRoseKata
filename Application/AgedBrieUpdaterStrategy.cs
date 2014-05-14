namespace GildedRose.Application
{
    internal class AgedBrieUpdaterStrategy : UpdaterStrategyBase
    {
        public override void UpdateQuality(Item item)
        {
            IncreaseQuality(item);

            if (HasExpired(item))
            {
                IncreaseQuality(item);
            }
        }

        private static void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}