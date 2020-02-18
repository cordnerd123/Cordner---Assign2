using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Cordner___Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Question 1");
            //int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            //int target = 9;
            //int[] r = TargetRange(l1, target);
            // Write your code to print range r here

            // Console.WriteLine("Question 2");
            //string s = "University of South Florida";
            //string rs = StringReverse(s);
            //Console.WriteLine(rs);

            //Console.WriteLine("Question 3");
            //int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            //int sum = MinimumSum(l2);
            //Console.WriteLine(sum);

            //Console.WriteLine("Question 4");
            //string s2 = "daniel";
            //string sortedString = FreqSort(s2);
            //Console.WriteLine(sortedString);

            //Console.WriteLine("Question 5-Part 1");
            //int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = { 2, 2 };
            //int[] intersect1 = Intersect1(nums1, nums2);
            //Console.WriteLine("Part 1- Intersection of two arrays is: ");
            //DisplayArray(intersect1);
            //Console.WriteLine("\n");
            //Console.WriteLine("Question 5-Part 2");
            //int[] intersect2 = Intersect2(nums1, nums2);
            //Console.WriteLine("Part 2- Intersection of two arrays is: ");
            //DisplayArray(intersect2);
            //Console.WriteLine("\n");

            //Console.WriteLine("Question 6");
            //char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            //int k = 3;
            //Console.WriteLine(ContainsDuplicate(arr, k));

            //Console.WriteLine("Question 7");
            //int rodLength = 13;
            //int priceProduct = GoldRod(rodLength);
            //Console.WriteLine(priceProduct);

            //Console.WriteLine("Question 8");
            //string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            //string keyword = "hhllo";
            //Console.WriteLine(DictSearch(userDict, keyword));

            //Console.WriteLine("Question 8");
            SolvePuzzle();
            
        }

        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return new int[] { };
        }

        public static string StringReverse(string s)
        {
            try
            {
                //write your code here
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public static int MinimumSum(int[] l2)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static string FreqSort(string s2)
        {
            SortedDictionary<char, string> dict = new SortedDictionary<char, string>();
            string outstring = String.Empty;
            Boolean multi = false;

            try
            {
                // put ea char into dictionary with value as frequency
                foreach (char c in s2)
                {
                    if (!dict.ContainsKey(c)) dict.Add(c, c.ToString());
                    else
                    {
                        dict[c] = dict[c] + c.ToString();
                        multi = true;
                    }
                }

                if (multi == false) return outstring = "There ain't no double letters in your string";

                foreach (var item in dict.OrderByDescending(r => r.Value))
                {
                    outstring = outstring + item.Value;
                }

            }
            catch (Exception)
            {   //I feel like there should be somehting in here to handle specific exceptions
                // however, I couldn't generate any errors
                throw;
            }
            return outstring;
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            Boolean foundit = false;

            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    if (!dict.ContainsKey(arr[i]))
                    {
                        dict.Add(arr[i], 0);
                    }
                    else
                    {
                        dict[arr[i]] = i - dict[arr[i]];

                        if (dict[arr[i]] <= k)
                        {
                            foundit = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return foundit;
        }

        public static int GoldRod(int rodLength)
        {
            int x = 1;
            int y = 1;
            try
            {
                if (rodLength == 3) x = rodLength;
                else if (rodLength > 4)
                {
                    x = 3;
                    y = GoldRod(rodLength - 3);
                }
                else if (rodLength >= 2)
                {
                    x = 2;
                    y = GoldRod(rodLength - 2);
                }
            }

            catch (Exception)
            {
                throw;
            }
            return x * y;
        }
        public static bool DictSearch(string[] userDict, string keyword)
        {
            int x = userDict.Length;
            Boolean foundit = false;

            try
            {
                for (int i = 0; i < x; i++)
                {
                    if (userDict[i].Length == keyword.Length)
                    {
                        int distance =
                            userDict[i].ToCharArray()
                            .Zip(keyword.ToCharArray(), (c1, c2) => new { c1, c2 })
                            .Count(m => m.c1 != m.c2);

                        if (distance == 1)
                        {
                            foundit = true;
                            break;
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return foundit;
        }
        public static void SolvePuzzle()
        {
            string[] iostr = new string[3];
            string unichar = String.Empty;
            int len=0;

            try
            {
                iostr = GetStrings();                // get user input

                unichar = UniqueCharacaters(iostr);  //gets string of unique characters

                testsomestuff(unichar, iostr);
            }
            catch (Exception)
            {
                throw;
            }
            return;
        }

        public static string[] GetStrings()
        {
            string[] iostr = new string[3];
            Boolean test = false;

            Console.WriteLine("Please enter two input strings, and an output string and hit ENTER after each");
            iostr[0] = Console.ReadLine();
            iostr[1] = Console.ReadLine();
            iostr[2] = Console.ReadLine();

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    iostr[i] = iostr[i].ToLower();          //ensure lowercase
                    iostr[i] = iostr[i].Replace(" ", "");   //ensure no spaces

                    if (iostr[i].Any(c => char.IsDigit(c)) == true)
                    {
                        Console.WriteLine("You entered a number instead of a string. FIX IT!");
                    }
                    else if (iostr[i] == String.Empty)
                    {
                        Console.WriteLine("You entered a blank string....that's just dumb.");
                    }
                }
            }
            catch
            {
                throw;
            }

            return iostr;
        }

        public static string UniqueCharacaters(string[] iostr)
        {
            string tstr = String.Empty;
            string test = String.Empty;

            //foreach (string value in iostr) tstr = tstr + value;

            tstr = iostr[0] + iostr[1] + iostr[2];
            tstr = String.Join("", tstr.Distinct());

            return tstr;
        }

        public static SortedDictionary<char,int> SetupDict (string unichar)
        {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            foreach (char value in unichar) dict.Add(value, 0);

            return dict;
        }

        public static void testsomestuff(string unichar, string[] iostr)
        {

            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            string instr1 = iostr[0];
            string instr2 = iostr[1];
            string outstr = iostr[2];

            string innumstr1 = String.Empty;
            string innumstr2 = String.Empty;
            string outnumstr = String.Empty;
            string itstr = String.Empty;

            int innum1;
            int innum2;
            int outnum;

            //get dict of char as key and values set to 0
            dict = SetupDict(unichar);

            /////////////////////////////////////////////////////
            //loop should start here
            ///////////////////////////////////////////////////////

            // make assignments in some kind of loop - below is a test case
            dict[Convert.ToChar("u")] = 1;
            dict[Convert.ToChar("b")] = 4;
            dict[Convert.ToChar("e")] = 8;
            dict[Convert.ToChar("r")] = 6;
            dict[Convert.ToChar("c")] = 9;
            dict[Convert.ToChar("o")] = 4;
            dict[Convert.ToChar("l")] = 2;
            dict[Convert.ToChar("n")] = 0;

            // get string of characters to iterate through (ie char not in output string)
            foreach (char c in instr1 + instr2) if (!iostr[2].Contains(c)) itstr = itstr + c;

            // convert values for first string into a number
            foreach (char c in instr1) innumstr1 = innumstr1 + dict[c];
            innum1 = Convert.ToInt32(innumstr1);

            // convert values for 2nd string into a number
            foreach(char c in instr2) innumstr2 = innumstr2 + dict[c];
            innum2 = Convert.ToInt32(innumstr2);

            // convert values for output str into a number
            foreach (char c in outstr) outnumstr = outnumstr + dict[c];
            outnum = Convert.ToInt32(outnumstr);

            Console.WriteLine(innum1 + innum2);
            Console.WriteLine(outnum);
        }
 
    }
}
