using System;

class FiveDifferentNumbers
{
    static void Main(string[] args)
    {

        // Problem:
        // You will be given two numbers – a and b.
        // Generate five numbers - n1, n2, n3, n4, n5, for which the following conditions are true: a ≤ n1 < n2 < n3 < n4 ≤ n5 ≤ b.
        // If there is no number in the given interval, which satisfies the conditions – print “No”.


        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (Math.Abs(a - b) < 5)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                if (j <= i || k <= j || l <= k || m <= l) continue;

                                else
                                {
                                    Console.Write(i + " ");
                                    Console.Write(j + " ");
                                    Console.Write(k + " ");
                                    Console.Write(l + " ");
                                    Console.WriteLine(m);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}