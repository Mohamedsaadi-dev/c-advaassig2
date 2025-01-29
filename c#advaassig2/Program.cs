namespace c_advaassig2
{
    internal class Program
    {


        static void Main(string[] args)
        { }
            #region q1
          public static void ProcessQueries(int[] arr, int[] queries)
        {
            
            foreach (int x in queries)
            {
                int count = 0;

                
                foreach (int num in arr)
                {
                    if (num > x)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }

        static void Main()
        {
          
            string[] firstInput = Console.ReadLine().Split(' ');
            int N = int.Parse(firstInput[0]); 
            int Q = int.Parse(firstInput[1]); 

            
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

 
            int[] queries = new int[Q];
            for (int i = 0; i < Q; i++)
            {
                queries[i] = int.Parse(Console.ReadLine());
            }

            
            ProcessQueries(arr, queries);
        }
        #endregion
        #region q2
        //public static string CheckPalindrome(int[] arr)
        //        {
        //            int n = arr.Length;


        //            for (int i = 0; i < n / 2; i++)
        //            {
        //                if (arr[i] != arr[n - i - 1])
        //                {
        //                    return "NO"; 
        //                }
        //            }

        //            return "YES"; 
        //        }

        //        static void Main()
        //        {

        //            int[] arr = { 1, 3, 2, 3, 1 };


        //            string result = CheckPalindrome(arr);

        //            Console.WriteLine(result);
        //        }

        #endregion
        #region q3
        #endregion
        #region q4
        //     public static string CheckBalancedParentheses(string input)
        //{

        //    Stack<char> stack = new Stack<char>();


        //    foreach (char ch in input)
        //    {

        //        if (ch == '(' || ch == '{' || ch == '[')
        //        {
        //            stack.Push(ch);
        //        }

        //        else if (ch == ')' || ch == '}' || ch == ']')
        //        {
        //            if (stack.Count == 0)
        //            {
        //                return "Not Balanced";
        //            }

        //            char top = stack.Pop();


        //            if ((ch == ')' && top != '(') ||
        //                (ch == '}' && top != '{') ||
        //                (ch == ']' && top != '['))
        //            {
        //                return "Not Balanced";
        //            }
        //        }
        //    }


        //    return stack.Count == 0 ? "Balanced" : "Not Balanced";
        //}

        //static void Main()
        //{
        //    string input = "[()]{}";


        //string result = CheckBalancedParentheses(input);


        //    Console.WriteLine(result);
        //}

        #endregion
        #region q5
        //public static int[] RemoveDuplicates(int[] arr)
        //{

        //    HashSet<int> uniqueElements = new HashSet<int>(arr);


        //    int[] result = new int[uniqueElements.Count];
        //    uniqueElements.CopyTo(result);

        //    return result;
        //}

        //static void Main()
        //{

        //    int[] arr = new int[] { 1, 2, 2, 3, 4, 4, 5 };


        //    int[] result = RemoveDuplicates(arr);


        //    Console.WriteLine("Array after removing duplicates: " + string.Join(", ", result));
        //}
        #endregion
        #region q6
        //public static void RemoveOddNumbers(List<int> numbers)
        //   {
        //       numbers.RemoveAll(n => n % 2 != 0);
        //   }

        //   static void Main()
        //   {
        //       List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //       RemoveOddNumbers(numbers);

        //       Console.WriteLine("Modified List (without odd numbers): " + string.Join(", ", numbers));
        //   }

        #endregion
        #region q7
        #endregion
        #region q8
        // public static void SearchTargetInStack(List<int> numbers, int target)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    int count = 0;
        //    foreach (var num in numbers)
        //    {
        //        stack.Push(num);
        //    }

        //    while (stack.Count > 0)
        //    {
        //        count++;
        //        int current = stack.Pop();

        //        if (current == target)
        //        {
        //            Console.WriteLine($"Target was found successfully and the count = {count}");
        //            return;
        //        }
        //    }
        //    Console.WriteLine("Target was not found");
        //}

        //static void Main()
        //{
        //    List<int> numbers = new List<int> { 1, 3, 5, 7, 9, 2, 4 };

        //    Console.Write("Enter the target number to search: ");
        //    int target = int.Parse(Console.ReadLine());

        //    SearchTargetInStack(numbers, target);
        //}

        #endregion
        #region q9
        //    public static List<int> FindIntersection(List<int> arr1, List<int> arr2)
        //{
        //    Dictionary<int, int> count1 = new Dictionary<int, int>();
        //    Dictionary<int, int> count2 = new Dictionary<int, int>();
        //    List<int> result = new List<int>();

        //    foreach (int num in arr1)
        //    {
        //        if (count1.ContainsKey(num))
        //            count1[num]++;
        //        else
        //            count1[num] = 1;
        //    }

        //    foreach (int num in arr2)
        //    {
        //        if (count2.ContainsKey(num))
        //            count2[num]++;
        //        else
        //            count2[num] = 1;
        //    }

        //    foreach (var pair in count1)
        //    {
        //        int num = pair.Key;
        //        if (count2.ContainsKey(num))
        //        {

        //            int minCount = Math.Min(count1[num], count2[num]);
        //            for (int i = 0; i < minCount; i++)
        //            {
        //                result.Add(num);
        //            }
        //        }
        //    }

        //    return result;
        //}

        //static void Main()
        //{
        //    List<int> arr1 = new List<int> { 1, 2, 3, 4, 4 };
        //    List<int> arr2 = new List<int> { 10, 4, 4 };

        //    List<int> result = FindIntersection(arr1, arr2);

        //    Console.WriteLine("Intersection: " + string.Join(", ", result));
        //}


        #endregion
        #region q10
        //   public static List<int> FindSubArrayWithSum(List<int> arr, int target)
        //{
        //    int currentSum = 0;
        //    int start = 0;
        //    for (int end = 0; end < arr.Count; end++)
        //    {
        //        currentSum += arr[end];

        //        while (currentSum > target && start <= end)
        //        {
        //            currentSum -= arr[start];
        //            start++;
        //        }

        //        if (currentSum == target)
        //        {
        //            List<int> result = new List<int>();
        //            for (int i = start; i <= end; i++)
        //            {
        //                result.Add(arr[i]);
        //            }
        //            return result;
        //        }
        //    }

        //    return new List<int>();
        //}

        //static void Main()
        //{
        //    List<int> arr = new List<int> { 1, 2, 3, 7, 5 };
        //    int target = 12;

        //    List<int> result = FindSubArrayWithSum(arr, target);

        //    if (result.Count > 0)
        //    {
        //        Console.WriteLine("Subarray with sum " + target + ": " + string.Join(", ", result));
        //    }
        //    else
        //    {
        //        Console.WriteLine("No subarray found with the target sum.");
        //    }
        #endregion
        #region q11
        //    public static Queue<int> ReverseFirstKElements(Queue<int> queue, int K)
        //{
        //    Stack<int> stack = new Stack<int>();


        //    for (int i = 0; i < K; i++)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }


        //    int remaining = queue.Count - K;
        //    for (int i = 0; i < remaining; i++)
        //    {
        //        queue.Enqueue(queue.Dequeue());
        //    }

        //    return queue;
        //}

        //static void Main()
        //{

        //    Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
        //    int K = 3;

        //    Queue<int> result = ReverseFirstKElements(queue, K);


        //    Console.WriteLine(string.Join(", ", result));
        //}
        #endregion

    }
    }




