using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataTests
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            var vowels = new List<string>() { "a", "e", "y", "o", "u", "A", "E", "I", "O", "U", };
            foreach (var vowel in vowels)
            {
                str = str.Replace(vowel, "");
            }
            return str;
        }

        public static bool IsIsogram(string str)
        {
            var strLowerCase = str.ToLower();
            if (strLowerCase.Any(c => strLowerCase.Count(s => s == c) > 1)) return false;
            return true;
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10) return false;

            int x = 0;
            int y = 0;

            foreach (var step in walk)
            {
                switch (step)
                {
                    case "n":
                        x++;
                        break;
                    case "s":
                        x--;
                        break;
                    case "e":
                        y++;
                        break;
                    case "w":
                        y--;
                        break;
                    
                    default: return false;

                }
            }
            if(x == 0 && x == 0) return true;

            return false;
        }
        public static bool ValidatePin(string pin)
        {
            if(pin.Length != 4 &&  pin.Length != 6) return false;
            return Regex.Match(pin, "^[0-9]{4}$").Success || Regex.Match(pin, "^[0-9]{6}$").Success;
        }
        public static string Likes(string[] name)
        {
            switch(name.Length)
            {
                case 1:
                    return name[0] + " likes this";
                case 2:
                    return String.Join(" and ", name) + " like this";
                case 3:
                    return name[0] + ", " + String.Join(" and ", name.Skip(1)) + " like this";
                case >=4:
                    return name[0] + ", " + name[1] + $" and {name.Length - 2} others like this";
                default: return "no one likes this";
            }
        }
        public static Func<char> MakeLooper(string str)
        {
            int count = str.Length;
            Func<char> func = () =>
            {
                if(count == str.Length) count = 0;
                return str[count++];
            };

            return func;
        }

        private static long TotalNumbersAmount(long n)
        {
            if (n == 0) return n;
            return n + TotalNumbersAmount(--n);
        }

        public static long RowSumOddNumbers(long n)
        {
            var lastOddNumber = TotalNumbersAmount(n) * 2 - 1;
            long sum = 0;
            while (n > 0) 
            {
                sum += lastOddNumber;
                lastOddNumber -= 2;
                n--;
            }
            return sum;
        }
        public static string GetMiddle(string s)
        {
            var middleIndex = s.Length/2;
            if (s.Length % 2 == 1) return s[middleIndex].ToString();
            return String.Concat(s[middleIndex - 1], s[middleIndex]);
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j<numbers.Length; j++)
                {
                    if (j == i) continue;
                    if (numbers[i] + numbers[j] == target) return new int[] {i, j};
                }
            }
            return new int[2];
        }
        public static int Find(int[] integers)
        {
            return integers.Count(i => i % 2 == 0) > 1  ? integers.FirstOrDefault(i => i % 2 == 1) : integers.FirstOrDefault(i => i % 2 == 0);
        }
        public static long QueueTime(int[] customers, int n)
        {
            var queues = new int[n];
            foreach(int customer in customers)
            {
                queues[Array.FindIndex(queues, q => q == queues.Min())] += customer;
            }
            return queues.Max();
            
            //var queues = new List<int>();
            //foreach (int customer in customers)
            //{
            //    if (queues.Count < n) queues.Add(customer);
            //    else
            //    {
            //        var indexMin = queues.IndexOf(queues.Min());
            //        queues[indexMin] = queues[indexMin] + customer;
            //    }
            //}
            //return queues.Any() ? queues.Max() : 0;
        }
        public static string PigIt(string str)
        {
            var strArray = str.Split(' ');
            for(int i = 0; i<strArray.Length; i++ )
            {
                strArray[i] = PigWord(strArray[i]);
            }
            return String.Join(' ', strArray);
        }

        private static string PigWord(string word)
        {
            char firstLetter = word[0];
            char endingSign = '\0';
            if (!Char.IsLetterOrDigit(word.Last()))
            {
                if (word.Where(c => !Char.IsLetterOrDigit(c)).Count() == word.Length) return word;
                endingSign = word.Last();
                word = word.Remove(word.Length - 1);
            }
            word = word.Remove(0, 1);
            word += firstLetter + "ay";
            if(endingSign != '\0') word += endingSign;
            return word;
        }
        public static string sumStrings(string a, string b)
        {
            BigInteger aInt;
            BigInteger bInt;
            BigInteger.TryParse(a, out aInt);
            BigInteger.TryParse(b, out bInt);
            return (aInt + bInt).ToString();
        }
    }
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            return String.Format("{0:00}:{1:00}:{2:00}", (seconds / 3600), (seconds % 3600) / 60, (seconds % 3600) % 60);
        }
    }
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (signature.Length == 0 || n == 0) return new double[0];
            var tribonacci = new double[n];
            for (int i = 0; i < n; i++)
            {
                tribonacci[i] = i < 3 ? signature[i] : tribonacci[i - 3] + tribonacci[i - 2] + tribonacci[i - 1];
            }
            return tribonacci;
        }
    }
    public class PyramidSlideDown
    {

        static int maxSum = 0;
        public static void Sum(int[][] pyramid, int x, int y, int sum)
        {
            do
            {
                if (y == pyramid.Length - 1 && x == pyramid[y].Length - 1) return; //end of pyramid
                else if (y == pyramid.Length - 1) // Bottom of pyramid. Add first sum
                {
                    if (maxSum < sum + pyramid[y][x]) maxSum = sum + pyramid[y][x];
                    if (maxSum < sum + pyramid[y][x + 1]) maxSum = sum + pyramid[y][x + 1];
                    return;
                }
                else
                {
                    Sum(pyramid, x, y + 1, sum + pyramid[y][x]);
                    if (pyramid[y].Length - 1 > x) Sum(pyramid, x + 1, y + 1, sum + pyramid[y][x + 1]);
                    return;
                }
            } while (true);
        }
        public static int LongestSlideDown(int[][] pyramid)
        {
            int[,] matrix = new int[pyramid.Length, pyramid.Length + 1];
            for (int y = 0; y < pyramid.Length; y++)
            {
                for (int x = 0; x < pyramid.Length; x++)
                {
                    int number = 0;
                    if (pyramid[y].Length > x) number = pyramid[y][x];
                    matrix[y, x] = number;
                }
            }
            for (int y = pyramid.Length - 2; y >= 0; y--)
            {
                for (int x = 0; x < pyramid.Length; x++)
                {
                    matrix[y, x] = Math.Max(matrix[y, x] + matrix[y + 1, x], matrix[y, x] + matrix[y + 1, x + 1]);
                }
            }


            //maxSum = 0;
            //Sum(pyramid, 0, 0, 0);
            return matrix[0,0];
        }
    }

}