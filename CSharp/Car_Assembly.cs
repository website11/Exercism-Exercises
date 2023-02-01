using System;
static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) {
            return 0;
        }
        else if (speed == 1 || speed == 2 || speed == 3 || speed == 4) {
            return 1.00;
        }
        else if (speed == 5 || speed == 6 || speed == 7 || speed == 8) {
            return 0.90;
        }
        else if (speed == 9) {
            return 0.80;
        }
        else {
            return 0.77;
        }
    }
    
    
    public static double ProductionRatePerHour(int speed)
    {
        double results = speed * 221 * SuccessRate(speed);
        return results;
    }
    public static int WorkingItemsPerMinute(int speed)
    {
        int items = (int)(ProductionRatePerHour(speed) / 60);
        return items;
    }
}
