namespace assignment_determinant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array1 = new int[2, 3, 2]
        {
                { { 1, 4 }, { 2, 7 }, { 9, 2 } },
                { { 4, 3 }, { 4, 0 }, { 2, 2 } }
        };
            int[,,] array2 = new int[2, 3, 2]
        {
                { { 1, 3 }, { 2, 5 }, { 3, 2 } },
                { { 5, 3 }, { 4, 10 }, { 2, 5 } }
        };
            int[,,] multiplication = new int[2, 3, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        multiplication[i, j, k] = array1[i, j, k] * array2[i, j, k];
                        Console.WriteLine(multiplication[i, j, k]);
                    }
                }
            }


        }
    }
}