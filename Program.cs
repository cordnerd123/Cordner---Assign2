using System;
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
            string[] outnumstr = new string[3];

            try
            {
                iostr = GetStrings();                // get user input

                unichar = UniqueCharacaters(iostr);  //gets string of unique characters

                outnumstr = CalculateAnswer(unichar, iostr);

                Console.WriteLine(iostr[0] + ":" + outnumstr[0]);
                Console.WriteLine(iostr[1] + ":" + outnumstr[1]);
                Console.WriteLine(iostr[2] + ":" + outnumstr[2]);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Operation Aborted");
                return;
            }
            catch
            {
                throw;
            }
            return;
        }


        public static string[] GetStrings()
        {
            string[] iostr = new string[3];

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
                        iostr = null;
                    }
                    else if (iostr[i] == String.Empty)
                    {
                        Console.WriteLine("You entered a blank string....that's just dumb.");
                        iostr = null;
                    }
                }

                if (iostr[2].Length - iostr[1].Length > 1 & iostr[2].Length - iostr[0].Length > 1)
                {
                    Console.WriteLine("The output string can't be more than 1 char longer than the longest input string");
                    iostr = null;
                }
                else if (iostr[0].Length != iostr[1].Length)
                    if (iostr[2].Length > iostr[0].Length | iostr[2].Length > iostr[1].Length)
                    {
                        Console.WriteLine("The output string can't be longer than input when input strings are of different lengths");
                        iostr = null;
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

            //foreach (string value in iostr) tstr = tstr + value;

            tstr = iostr[0] + iostr[1] + iostr[2];
            tstr = String.Join("", tstr.Distinct());

            return tstr;
        }
        public static SortedDictionary<char, int> SetupDict(string unichar, string outstr) 
        {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            string uncom = String.Empty;
            Random rnd = new Random(123);
            
            int x = rnd.Next(1, unichar.Length - 1);

            //foreach (char value in unichar) dict.Add(value, rnd.Next(0,9));
            foreach (char value in unichar) dict.Add(value, 0);

            // string of char that are not common across any of input strings (ie char not in output)
            foreach (char c in unichar)
                if (!outstr.Contains(c)) uncom = uncom + c;
            dict[uncom[0]] = 1;         // starting with b
            //dict[unichar[x]] = 1;    //random letter
            //dict[unichar[0]] = 1;


            return dict;
        }
        public static int GetStringNum(string s, SortedDictionary <char, int> dict)
        {
            int num = 0;
            string numstr = String.Empty;

            foreach (char c in s) numstr = numstr + dict[c];
            num = Convert.ToInt32(numstr);
            return num;
        }
        public static string StringNumResults(string s, SortedDictionary<char,int> dict)
        {
            string numstr = String.Empty;

            foreach(char c in s) numstr = numstr + dict[c];
            return numstr;
        }
        public static string[] CalculateAnswer(string unichar, string[] iostr)
        {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            string instr1 = iostr[0];
            string instr2 = iostr[1];
            string outstr = iostr[2];
            string[] outnumstr = new string[3];

            Boolean longer = false;

            int i = 0;
            int j = 0;
            int w = 0;

            //get dict of char as key and values set to random numbers
            dict = SetupDict(unichar, outstr);

            int innum1 = GetStringNum(instr1, dict);
            int innum2 = GetStringNum(instr2, dict);
            int outnum = GetStringNum(outstr, dict);

            //determine if out str is longer than inputs - can't change first char of output if true
            if (outstr.Length > instr1.Length | outstr.Length > instr2.Length) longer = true;

            try
            {
                while (innum1 + innum2 != outnum & w < 1000000)
                {
                    int sum = innum1 + innum2;

                    i = (outstr.Length-1) - Convert.ToInt32((Convert.ToString(outnum - sum).Length));
                    j = outstr.Length - Convert.ToInt32((Convert.ToString(sum).Length));

                    if (longer == true)
                    {   // adjust if input sum is higher than output number

                        if (outnum - sum > 0)
                        {  // which input string to adjust?

                            // do we want to check for noncom first?
                            if (instr1[i] != outstr[0])
                            {
                                if (dict[instr1[i]] < 9) dict[instr1[i]]++;
                            }
                            else if (instr2[i] != outstr[0])
                            {
                                if (dict[instr2[i]] < 9) dict[instr2[i]]++;
                            }
                        }
                        else
                        { // adjust if output is higher than input sum
                            if (j == 0 & dict[outstr[j]] < 1) dict[outstr[j]]++;
                            else if (j != 0)
                            {
                                if (dict[outstr[j]] < 9) dict[outstr[j]]++;
                            }
                        }
                    }
   
                    // get new numbers after adjustments
                    innum1 = GetStringNum(instr1, dict);
                    innum2 = GetStringNum(instr2, dict);
                    outnum = GetStringNum(outstr, dict);

                    w++;
                } 
            }
            catch
            {
                // no man's land
                throw;
            }

            outnumstr[0] = StringNumResults(instr1, dict);
            outnumstr[1] = StringNumResults(instr2, dict);
            outnumstr[2] = StringNumResults(outstr, dict);

            return outnumstr;
        }
    }
}
