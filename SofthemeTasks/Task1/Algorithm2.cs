namespace Task1
{
    public static class Algorithm2
    {
        public static int FindMaxNotZeroLength(string inputString)
        {
            string res = "1";
            while (inputString.Contains(res))
                res += "1";
            return res.Length - 1;
        }
    }
}
