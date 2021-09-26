using System;



class c

{

    static int DOTS = 10;



    // to find total unlock pattern starting from current cell

    static int totalPatternFromCur(Boolean[] visit, int[,] jump,

                                           int cur, int toTouch)

    {

        if (toTouch <= 0)

        {

            // if last cell then return 1 way

            return (toTouch == 0) ? 1 : 0;

        }



        int ways = 0;



        // make this cell visited before

        // going to next call

        visit[cur] = true;



        for (int i = 1; i < DOTS; i++)

        {

            // method returns number of pattern with

            // minimum m connection and maximum n connection

            static int waysOfConnection(int m, int n)

            {

                int[,] jump = new int[DOTS, DOTS];

                Boolean[] visit = new Boolean[DOTS];

                int ways = 0;

                for (int i = m; i <= n; i++)

                {

                    // 1, 3, 7, 9 are symmetric so multiplying by 4

                    ways += 4 * totalPatternFromCur(visit,

                                                    jump, 1, i - 1);



                    // 2, 4, 6, 8 are symmetric so multiplying by 4

                    ways += 4 * totalPatternFromCur(visit,

                                                    jump, 2, i - 1);



                    ways += totalPatternFromCur(visit,

                                                jump, 5, i - 1);

                }

                return ways;

            }



            // Driver Code

            public static void Main(String[] args)

            {

                int minConnect = 4;

                int maxConnect = 6;



                Console.WriteLine(waysOfConnection(minConnect,

                                                   maxConnect));

            }

        }