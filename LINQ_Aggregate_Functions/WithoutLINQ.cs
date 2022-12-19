using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Aggregate_Functions
{
    public static class WithoutLINQ
    {
        public static int MinNoLINQ(this int[] integers) 
        {
            int? result = null;
            foreach (int integer in integers)
            {
                if (!result.HasValue || integer < result)
                {
                    result = integer;
                }
            }
            return (int)result;
        }

        public static int MaxNoLINQ(this int[] integers)
        {
            int? result = null;
            foreach (int integer in integers)
            {
                if (!result.HasValue || integer > result)
                {
                    result = integer;
                }
            }
            return (int)result;
        }

        public static int SmallestEvenNumNoLINQ(this int[] integers)
        {
            int? result = null;
            foreach (int integer in integers)
            {
                if(integer % 2 == 0)
                {
                    if (!result.HasValue || integer < result)
                    {
                        result = integer;
                    }
                }
            }
            return (int)result;
        }

        public static int LargestEvenNumNoLINQ(this int[] integers)
        {
            int? result = null;
            foreach (int integer in integers)
            {
                if (integer % 2 == 0)
                {
                    if (!result.HasValue || integer > result)
                    {
                        result = integer;
                    }
                }
            }
            return (int)result;
        }

        public static int SmallestOddNumNoLINQ(this int[] integers)
        {
            int? result = null;
            foreach (int integer in integers)
            {
                if (integer % 2 == 1)
                {
                    if (!result.HasValue || integer < result)
                    {
                        result = integer;
                    }
                }
            }
            return (int)result;
        }

        public static int LargestOddNumNoLINQ(this int[] integers)
        {
            int? result = null;
            foreach (int integer in integers)
            {
                if (integer % 2 == 1)
                {
                    if (!result.HasValue || integer > result)
                    {
                        result = integer;
                    }
                }
            }
            return (int)result;
        }

        public static int SumOfAllNumsNoLINQ(this int[] integers)
        {
            int result = 0;
            foreach (int integer in integers)
            {
                result += integer;
            }
            return result;
        }

        public static int SumOfAllEvenNumsNoLINQ(this int[] integers)
        {
            int result = 0;
            foreach (int integer in integers)
            {
                if (integer % 2 == 0)
                {
                    result += integer;
                }
            }
            return result;
        }

        public static int SumOfAllOddNumsNoLINQ(this int[] integers)
        {
            int result = 0;
            foreach (int integer in integers)
            {
                if (integer % 2 == 1)
                {
                    result += integer;
                }
            }
            return result;
        }

        public static int CountOfAllNumsNoLINQ(this int[] integers)
        {
            int result = 0;
            foreach (int integer in integers)
            {
                result++;
            }
            return result;
        }

        public static int CountOfAllEvenNumsNoLINQ(this int[] integers)
        {
            int result = 0;
            foreach (int integer in integers)
            {
                if (integer % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }

        public static int CountOfAllOddNumsNoLINQ(this int[] integers)
        {
            int result = 0;
            foreach (int integer in integers)
            {
                if (integer % 2 == 1)
                {
                    result++;
                }
            }
            return result;
        }

        public static double AverageOfAllNumsNoLINQ(this int[] integers)
        {
            double count = 0;
            double sum = 0;
            double? result = null;

            foreach (var integer in integers)
            {
                count++;
                sum += integer;
            }
            result = sum / count;
            return (double)result;
        }

        public static double AverageOfAllEvenNumsNoLINQ(this int[] integers)
        {
            double count = 0;
            double sum = 0;
            double? result = null;

            foreach (var integer in integers)
            {
                if (integer % 2 == 0)
                {
                    count++;
                    sum += integer;
                }
            }
            result = sum / count;
            return (double)result;
        }

        public static double AverageOfAllOddNumsNoLINQ(this int[] integers)
        {
            double count = 0;
            double sum = 0;
            double? result = null;

            foreach (var integer in integers)
            {
                if (integer % 2 == 1)
                {
                    count++;
                    sum += integer;
                }
            }
            result = sum / count;
            return (double)result;
        }

        public static int MinLengthCountryNameNoLINQ(this string[] words)
        {
            int? result = null;
            foreach (string word in words)
            {
                if (!result.HasValue || word.Length < result)
                {
                    result = word.Length;
                }
            }
            return (int)result;
        }

        public static int MaxLengthCountryNameNoLINQ(this string[] words)
        {
            int? result = null;
            foreach (string word in words)
            {
                if (!result.HasValue || word.Length > result)
                {
                    result = word.Length;
                }
            }
            return (int)result;
        }
    }
}
