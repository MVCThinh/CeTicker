

using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Reflection;
using System.Transactions;

class Program
{
    static string DecryptPassword(string encryptedPassword)
    {
        if (string.IsNullOrEmpty(encryptedPassword))
        {
            return "";
        }
        byte[] passByteData = Convert.FromBase64String(encryptedPassword);
        string originalPassword = System.Text.Encoding.Unicode.GetString(passByteData);
        return originalPassword;
    }


    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> distinct = new HashSet<int>();


        foreach (int num in nums)
        {
            if (distinct.Contains(num))
                return true;
            else distinct.Add(num);
        }
        return false;
    }


    public bool ContainsDuplicate1(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                return true;
        }
        return false;
    }

    public bool IsAnagram(string s, string t)
    {
        if (s == null || t == null)
            return false;
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray).Equals(new string(tArray));
    }

    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
                return new int[2] { map[target - nums[i]], i };
            else map.TryAdd(nums[i], i);
        }
        return new int[2] { 0, 0 };
    }

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedStr = new string(charArray);

            if (!map.ContainsKey(sortedStr))
            {
                map[sortedStr] = new List<string>();
            }

            map[sortedStr].Add(str);
        }

        IList<IList<string>> result = new List<IList<string>>();
        foreach (var kvp in map)
        {
            result.Add(kvp.Value);
        }

        return result;
    }

    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (frequencyMap.ContainsKey(num))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;
        }

        List<int> topKFrequent = frequencyMap.Keys.OrderByDescending(key => frequencyMap[key]).Take(k).ToList();

        return topKFrequent.ToArray();
    }

    public static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        int[] leftProducts = new int[n];
        leftProducts[0] = 1;
        for (int i = 1; i < n; i++)
        {
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
        }

        int rightProducts = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] = leftProducts[i] * rightProducts;
            rightProducts = rightProducts * nums[i];
        }
        return answer;

    }

    public bool IsValidSudoku(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            if (!IsValidRow(board, row))
                return false;
        }

        for (int col = 0; col < 9; col++)
        {
            if (!IsValibColumn(board, col))
                return false;
        }

        for (int boxRow = 0; boxRow < 9; boxRow += 3)
        {
            for (int boxCol = 0; boxCol < 9; boxCol += 3)
            {
                if (!IsValidBox(board, boxRow, boxCol)) return false;
            }
        }
        return true;

    }

    private bool IsValidRow(char[][] board, int row)
    {
        HashSet<char> seen = new HashSet<char>();
        for (int col = 0; col < 9; col++)
        {
            char digit = board[row][col];
            if (digit != '.' && !seen.Add(digit)) return false;
        }
        return true;
    }

    private bool IsValibColumn(char[][] board, int col)
    {
        HashSet<char> seen = new HashSet<char>();
        for (int row = 0; row < 9; row++)
        {
            char digit = board[col][row];
            if (digit != '.' && !seen.Add(digit)) return false;
        }
        return true;
    }

    private bool IsValidBox(char[][] board, int startRow, int startCol)
    {
        HashSet<char> seen = new HashSet<char>();
        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                char digit = board[row][col];
                if (digit != '.' && !seen.Add(digit)) return false;
            }
        }
        return true;
    }

    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanDigits = new()
        {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100 },
            {'D',500 },
            {'M',1000 }
        };

        int result = 0;
        int prvVal = 0;

        for (int i = s.Length -1; i >= 0 ; i--)
        {
            int curVal = romanDigits[s[i]];


            if (curVal >= prvVal)
                result += curVal;
            else
                result -= curVal;

            prvVal = curVal;
        }

        return result;

    }

    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0 )
            {
                // bỏ đi phần tử cuối
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0)
                    return "";
            }
        }
        return prefix;
    }

    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();
                if (c == ')' && top != '(' || c == '}' && top != '{' || c == ']' && top != '[')
                    return false;
            }
        }

        return stack.Count == 0;
    }

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> permutation = new List<int>();
        Array.Sort(nums);
        bool[] used = new bool[nums.Length];

        Permute(nums, permutation, used, result);
        return result;

    }

    private void Permute(int[] nums, List<int> permutation, bool[] used, IList<IList<int>> result)
    {
        if (permutation.Count == nums.Length)
        {
            result.Add(new List<int>(permutation));
            return;
        }
         // 1 ,2 
        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
            permutation.Add(nums[i]); // 1, 1, 1, 2, 3, 4
            used[i] = true;
            Permute(nums, permutation, used, result);
            permutation.RemoveAt(permutation.Count - 1); // Bỏ phần tử cuối cùng
            used[i] = false;
        }
    }

    public int Reverse(int x)
    {
        int rev = 0;
        bool negative = false;

        if (x < 0)
        {
            negative = true;
            x = -x;
        }

        while (x > 0)
        {
            int digit = x % 10;

            rev = rev * 10 + digit;
            x = x / 10;
        }

        if (negative)
        {
            rev = -rev;
        }

        if (rev <int.MinValue || rev >int.MaxValue)
        {
            return 0;
        }
        return rev;

    }



    static void Main(string[] args)
    {
        //Console.WriteLine(DecryptPassword("cAB2AHEAcAB2AHEA"));
        //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
        string PathRoot = @"C:\EQData1\Config\";
        string ConfigName = "\\VisionConfig.ini";
        string ecamName = "LoadingPre1";
        string path1 = Path.Combine(PathRoot, ecamName, ConfigName);
        //Console.WriteLine("khong co cam dc ket noi \n\r Kiem tra lai IP Cam");

        int[] answer = new int[4];
        answer = ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });
    }
}

