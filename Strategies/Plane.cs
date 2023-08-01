namespace StrategyPattern.Strategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            KilometerCost = 50;
        }

        public override decimal Drive(int kilometers)
        {
            if (kilometers > 1000)
                KilometerCost = 35;

            return kilometers * KilometerCost;
        }
    }
}
