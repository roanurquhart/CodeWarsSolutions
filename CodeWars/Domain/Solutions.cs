using CodeWars.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public static class Solutions
    {

        public static int[] FoldArray(int[] array, int runs)
        {
            if (runs == 0) return array;

            var finArr = array;
            if (array.Length % 2 == 0)
            {
                finArr = array.Take(array.Length / 2).ToArray();
            }
            else
            {
                finArr = array.Take(array.Length / 2 + 1).ToArray();
            }            
            var half = 0;
            var secondPointer = array.Length - 1;

            half = array.Length / 2;
            for (int i = 0; i < half; i++)
            {
                finArr[i] = array[i] + array[secondPointer];
                secondPointer--;
            }
            return FoldArray(finArr, runs - 1);

        }

        public static string SongDecoder(string input)
        {
            var built = new StringBuilder();
            var finAnswer = input.Replace("WUB", " ");
            for (int i = 0; i < finAnswer.Length; i ++)
            {
                if (i == 0 && !finAnswer[i].Equals(' '))
                {
                    built.Append(finAnswer[i]);
                }
                if (!finAnswer[i].Equals(' ')) built.Append(finAnswer[i]);
                try
                {
                    if (i != 0 && finAnswer[i].Equals(' ') && !finAnswer[i + 1].Equals(' '))
                    {
                        built.Append(finAnswer[i]);
                    }
                }
                catch
                {
                }
            }
            return built.ToString();
        }

        public static Direction[] dirReduc(Direction[] arr)
        {
            var reverseAnswer = new Stack<Direction>();
            var finalAnswer = new Stack<Direction>();
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    var temp = reverseAnswer.Peek();
                    switch (arr[i])
                    {
                        case Direction.NORTH:
                            if (temp.Equals(Direction.SOUTH))
                            {
                                reverseAnswer.Pop();
                            }
                            else reverseAnswer.Push(arr[i]);
                            continue;
                        case Direction.SOUTH:
                            if (temp.Equals(Direction.NORTH))
                            {
                                reverseAnswer.Pop();
                            }
                            else reverseAnswer.Push(arr[i]);
                            continue;
                        case Direction.WEST:
                            if (temp.Equals(Direction.EAST))
                            {
                                reverseAnswer.Pop();
                            }
                            else reverseAnswer.Push(arr[i]);
                            continue;
                        case Direction.EAST:
                            if (temp.Equals(Direction.WEST))
                            {
                                reverseAnswer.Pop();
                            }
                            else reverseAnswer.Push(arr[i]);
                            continue;
                    }
                }
                catch
                {
                    reverseAnswer.Push(arr[i]);
                }
            }
            
            while (reverseAnswer.Count > 0) finalAnswer.Push(reverseAnswer.Pop());
            return finalAnswer.ToArray();
            

        }
            
        public static string Rot13(string message)
        {
            var upFirst = "ABCDEFGHIJKLM";
            var upLast = "NOPQRSTUVWXYZ";
            var downFirst = upFirst.ToLower();
            var downLast = upLast.ToLower();
            var finalAnswer = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if ((int)message[i] > 64 && (int)message[i] < 78)
                {
                    for (int j = 0; j < upFirst.Length; j++)
                    {
                        if (message[i] == upFirst[j]) finalAnswer.Append(upLast[j]);
                    }
                }
                else if ((int)message[i] > 77 && (int)message[i] < 91)
                {
                    for (int j = 0; j < upLast.Length; j++)
                    {
                        if (message[i] == upLast[j]) finalAnswer.Append(upFirst[j]);
                    }
                }
                else if ((int)message[i] > 96 && (int)message[i] < 110)
                {
                    for (int j = 0; j < downFirst.Length; j++)
                    {
                        if (message[i] == downFirst[j]) finalAnswer.Append(downLast[j]);
                    }
                }
                else if ((int)message[i] > 109 && (int)message[i] < 123)
                {
                    for (int j = 0; j < downLast.Length; j++)
                    {
                        if (message[i] == downLast[j]) finalAnswer.Append(downFirst[j]);
                    }
                }
                else finalAnswer.Append(message[i]);
            }

            return finalAnswer.ToString();
        }

        public static int[] DeleteNthWithLINQ(int[] arr, int x)
        {
            var finalAnswer = new List<int>();
            var answer = arr.GroupBy(i => i).Where(j => j.Count() <= x);
            foreach(IGrouping<int,int> group in answer)
            {
                finalAnswer.Add(group.Key);
            }
            return finalAnswer.ToArray();
           
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            var numDictionary = new Dictionary<int, int>();
            var finalList = new List<int>();

            foreach(var i in arr)
            {
                if (numDictionary.ContainsKey(i))
                {
                    numDictionary[i]++;

                    if (numDictionary[i] > x) continue;

                    finalList.Add(i);
                } else
                {
                    numDictionary.Add(i, 1);
                    finalList.Add(i);
                }
            }

            return finalList.ToArray();
        }

        public static string TitleCase(string title, string minorWords = "")
        {
            string[] titles = title.Split(" ");
            titles = titles.Select(x => x.ToLower()).ToArray();

            if (title.Equals("")) return title;
            try
            {
                minorWords.ToLower();
            }
            catch (Exception)
            {
                minorWords = "";
            }
           
            if (!minorWords.Equals(""))
            {
                string[] minors = minorWords.Split(" ");
                minors = minors.Select(x => x.ToLower()).ToArray();

                for (int i = 0; i < titles.Length; i++)
                {
                    if (!minors.Contains<string>(titles[i]))
                    {
                        titles[i] = Char.ToUpper(titles[i][0]) + titles[i].Substring(1);

                    }
                }
                titles[0] = Char.ToUpper(titles[0][0]) + titles[0].Substring(1);
            }
            else { 
                for (int i = 0; i < titles.Length; i++)
                {
                    titles[i] = Char.ToUpper(titles[i][0]) + titles[i].Substring(1);
                }
            }
            title = string.Join(" ", titles);
            return title;
        }

        public static int Sum(int[] integers)
        {
            return integers.Sum();
            
        }

        public static int CountChar(char[] chars, char charToCount)
        {
            return chars.Count<char>(c => c.Equals(charToCount));
        }

        public static int[] CalculateSquares(int start, int end)
        {
            if (start == end || start > end) throw new ArgumentOutOfRangeException();

            IEnumerable<int> results = Enumerable.Range(start, end-start).Select(x => x * x);
            int[] final = results.Cast<int>().ToArray();

            return final;
        }

        public static void ArrayFind()
        {
            Point[] points = { new Point(100, 200),
            new Point(150, 250), new Point(250, 375),
            new Point(275, 395), new Point(295, 450) };

            // Find the first Point structure for which X times Y 
            // is greater than 100000. 
            Point first = Array.Find(points, ProductGT10);
            // OR
            Point firstB = Array.Find(points, p=>(p.X*p.Y)>100000);
            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);

        }

        private static bool ProductGT10(Point p)
        {
            return p.X * p.Y > 100000;
        }

        public static void GetMissingCandies(int[] candies)
        {
            if (candies.Length == 0 || candies.Length == 1) Console.WriteLine(-1);

            int max = 0;
            int handedOut = 0;

            foreach (int candy in candies)
            {
                if (candy > max) max = candy;
            }
            foreach (int candy in candies)
            {
                if (candy < max)
                {
                    handedOut += max - candy;
                }
            }
            Console.WriteLine(handedOut);
        }

        public static void BinaryAddition(int a, int  b)
        {
            int total = a + b;
            string answer = "";
            do
            {
                answer += (total % 2).ToString();
                total /= 2;
            } while (total >= 1);
            char[] reverse = answer.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(new String(reverse));
        }

        public static void LowestAddition(int[] numbers)
        {
            int lowest = 2147483646;
            int secondLowest = 0;

            foreach (int i in numbers)
            {
                if (i < lowest)
                {
                    secondLowest = lowest;
                    lowest = i;
                }
                else if (i < secondLowest)
                {
                    secondLowest = i;
                }
            }
            Console.WriteLine(lowest + secondLowest);
        }

        public static void DisemvowelTrolls(String str)
        {
            StringBuilder newString = new StringBuilder("", 1000000);
            for (var i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        break;
                    case 'A':
                        break;
                    case 'e':
                        break;
                    case 'E':
                        break;
                    case 'i':
                        break;
                    case 'I':
                        break;
                    case 'o':
                        break;
                    case 'O':
                        break;
                    case 'u':
                        break;
                    case 'U':
                        break;
                    default:
                        newString.Append(str[i]);
                        break;
                }
            }
            Console.WriteLine(newString.ToString());
        }

        public static String Sorted(int[] array)
        {
            var initial = array[0];
            /*option 2: starting
              option 1: ascending
              option 0: descending
              option -1: none;
            */
            var option = 2;
            for (var i = 1; i < array.Length; i++)
            {
                if ((option == 2 || option == 1) && array[i] >= initial)
                {
                    option = 1;
                    initial = array[i];
                }
                else if ((option == 2 || option == 0) && array[i] <= initial)
                {
                    option = 0;
                    initial = array[i];
                }
                else
                {
                    return "no";
                }
            }
            switch (option)
            {
                case 0:
                    return "yes, descending";
                case 1:
                    return "no, ascending";
                default:
                    return "";
            }
        }

        public static int GetTotal(List<int> numbers)
        {
            // using Aggregate, return the total for the list of numbers
            return numbers.Aggregate<int>((total, next) => next + total);
        }

    }
}
