namespace LinqueAssignment
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            //1.Given an array of numbers. Find  the cube of the numbers that are greater than 100 but less than 1000 using LINQ.
            int[] num = { 2, 4, 6, 8, 10 };
            var res =from n in num
                     let i= n*n*n
                     where i>100&&i<1000
                     select i;
            foreach(var h in res)
                Console.WriteLine(h);

        }
    }
}
