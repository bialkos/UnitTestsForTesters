using System;

namespace UnitTestsFortTesters
{
    public class PenaltyPointsCalculator
    {
        private const int speedLimit = 65;
        private const int maxSupportedSpeed = 300;
        private const int kmPerPenaltyPoint = 5;

        public int CalculatePenaltyPoints(int speed)
        {
            if (speed < 0 || speed > maxSupportedSpeed)
                throw new ArgumentOutOfRangeException();

            if (speed <= speedLimit)
                return 0;

            var penaltyPoints = (speed - speedLimit) / kmPerPenaltyPoint;

            return penaltyPoints;
        }
    }
}



