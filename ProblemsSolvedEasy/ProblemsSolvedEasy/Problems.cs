using System.Text;

namespace ProblemsSolvedEasy
{
    public class Problems
    {
        /*
         * Breaking the Records
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */
        public static List<int> BreakingRecords(List<int> scores)
        {
            int[] baseScore = new int[] { scores.First(), scores.First() };
            int broke = 0;
            int worst = 0;
            for (int i = 1; i < scores.Count; i++)
            {
                int score = scores[i];
                if (score > baseScore[0])
                {
                    baseScore[0] = score;
                    broke++;
                }
                if (score < baseScore[1])
                {
                    baseScore[1] = score;
                    worst++;
                }
            }

            return new List<int>() { broke, worst };
        }


        /*
         * Number Line Jumps
         * Complete the 'kangaroo' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER x1
         *  2. INTEGER v1
         *  3. INTEGER x2
         *  4. INTEGER v2
         */
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {
                for (int i = 0; i <= 10000; i++)
                {
                    int pK1 = (i * v1) + x1;
                    int pK2 = (i * v2) + x2;

                    if (pK1 == pK2) return "YES";
                }
            }

            return "NO";
        }

        /*
         * Apple and Orange
         * Complete the 'countApplesAndOranges' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER s
         *  2. INTEGER t
         *  3. INTEGER a
         *  4. INTEGER b
         *  5. INTEGER_ARRAY apples
         *  6. INTEGER_ARRAY oranges
         */
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var resA = from pA in apples where s <= (a + pA) && t >= (a + pA) select pA;
            var resO = from pO in oranges where s <= (b + pO) && t >= (b + pO) select pO;

            Console.WriteLine(resA.Count());
            Console.WriteLine(resO.Count());
        }

        /*
         * Grading Students
         * Complete the 'GradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> ret = new List<int>();
            foreach (var item in grades)
            {
                int newRes = item;
                int ten = item % 10;
                if (item > 37)
                    newRes += (ten == 3 || ten == 8) ? 2 : (ten == 4 || ten == 9) ? 1 : 0;

                ret.Add(newRes);
            }

            return ret;
        }

        /*
         * Time Conversion
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */
        public static string TimeConversion(string s)
        {
            return DateTime.Parse(s).TimeOfDay.ToString();
        }

        /*
         * Birthday Cake Candles
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */
        public static int BirthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            var grp = candles.GroupBy(o => o);
            var res = grp.Last();
            return res.Count();
        }

        /*
         * Mini-Max Sum
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static void MiniMaxSum(List<long> arr)
        {
            arr.Sort();
            long minVal = arr[0];
            arr.RemoveAt(0);

            long maxSum = arr.Sum();

            arr.Add(minVal);
            arr.Sort();
            arr.RemoveAt(arr.Count - 1);

            long minSum = arr.Sum();

            Console.WriteLine(minSum.ToString() + " " + maxSum.ToString());
        }

        /*
         * Staircase
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */
        public static void Staircase(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string line = string.Empty;
                line = line.PadLeft(i + 1, '#');
                line = line.PadLeft(n, ' ');

                sb.AppendLine(line);
            }

            Console.WriteLine(sb.ToString());
        }

        /*
         * Diagonal Difference
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int sumFront = 0;
            int sumBack = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sumFront += arr[i][i];
                sumBack += arr[i][arr[i].Count - (i + 1)];
            }

            return Math.Abs(sumFront - sumBack);
        }

        /*
         * A Very Big Sum
         * Complete the 'aVeryBigSum' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER_ARRAY ar as parameter.
         */
        public static long AVeryBigSum(List<long> ar)
        {
            return ar.Sum();
        }

        /*
         * Compare the Triplets
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int[] result = new int[] { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    result[0] += 1;
                else if (a[i] < b[i])
                    result[1] += 1;
            }

            return result.ToList();
        }

        /*
         * Simple Array Sum
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */
        public static int SimpleArraySum(List<int> ar)
        {
            return ar.Sum();
        }

        /*
         * Solve Me First
         */
        public static int SolveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            return a + b;
        }

        /*
         * Plus Minus
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static void PlusMinus(List<int> arr)
        {
            decimal arrLenth = arr.Count;

            decimal posCount = (decimal)arr.FindAll(o => o > 0).Count / arrLenth;
            decimal negCount = (decimal)arr.FindAll(o => o < 0).Count / arrLenth;
            decimal zeroCount = (decimal)arr.FindAll(o => o == 0).Count / arrLenth;

            string patt = "0.000000";

            Console.WriteLine(posCount.ToString(patt));
            Console.WriteLine(negCount.ToString(patt));
            Console.WriteLine(zeroCount.ToString(patt));
        }
    }
}
