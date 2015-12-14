namespace Task1
{
    public static class Algorithm1
    {
        public static int FindMaxNotZeroLength(string inputString)
        {
            int counter = 0, maxValue = 0;
            foreach (var ch in inputString)
            {
                if (ch == '1') counter++;
                else counter = 0;
                if (counter > maxValue) maxValue = counter;
            }
            return maxValue;
        }
    }
}
