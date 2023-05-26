

using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipes;
using System.Reflection;
using System.Text;
using System.Transactions;
using System.Xml;
using Test;

class Program
{
    //static string DecryptPassword(string encryptedPassword)
    //{
    //    if (string.IsNullOrEmpty(encryptedPassword))
    //    {
    //        return "";
    //    }
    //   // byte[] passByteData = Convert.FromBase64String(encryptedPassword);
    //   // string originalPassword = System.Text.Encoding.Unicode.GetString(passByteData);
    //    return originalPassword;
    //}

    /// <summary>
    /// Sử dụng HashSet kiểm tra chỉ duy nhất tồn tại
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Sử dụng Array.Sort kiểm tra xem 2 chuỗi có giống nhau hay không
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Sử dụng vòng lặp for duyệt qua từng phần tử
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Sử dụng Dictionary
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
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

        for (int i = s.Length - 1; i >= 0; i--)
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
    /// <summary>
    /// Sử dụng IndexOf tìm chuỗi trong chuỗi
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                // bỏ đi phần tử cuối
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0)
                    return "";
            }
        }
        return prefix;
    }
    /// <summary>
    /// Sử dụng Stack
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Sử dụng đệ quy và hoán vị
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
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
        int result = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                return 0;
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                return 0;

            result = result * 10 + digit;

        }

        return result;

    }
    /// <summary>
    /// Sử dụng thuật toán Exapand Round Center
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return string.Empty;

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            int length1 = ExpandAroundCenter(s, i, i);
            if (length1 > maxLength)
            {
                maxLength = length1;
                start = i - length1 / 2;
            }

            int length2 = ExpandAroundCenter(s, i, i + 1);
            if (length2 > maxLength)
            {
                maxLength = length2;
                start = i - length2 / 2 + 1;
            }
        }

        return s.Substring(start, maxLength);

    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }

    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length) return s;

        List<StringBuilder> rows = new List<StringBuilder>();

        for (int i = 0; i < numRows; i++)
        {
            rows.Add(new StringBuilder());
        }

        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            rows[currentRow].Append(c);

            if (currentRow == 0 || currentRow == numRows - 1)
            {
                goingDown = !goingDown;
            }

            currentRow += goingDown ? 1 : -1;

        }

        StringBuilder result = new StringBuilder();

        foreach (StringBuilder row in rows)
        {
            result.Append(row.ToString());
        }

        return result.ToString();

    }

    public int MyAtoi(string s)
    {
        int index = 0;
        int sign = 1;
        int result = 0;


        // Bỏ qua khoảng trắng đầu chuỗi
        while (index < s.Length && s[index] == ' ')
        {
            index++;
        }

        // Xác đinh dấu
        if (index < s.Length && (s[index] == '-' || s[index] == '+'))
        {
            sign = (s[index] == '-') ? -1 : 1;
            index++;
        }

        // Đọc các chữ số và chuyển thành số nguyên
        while (index < s.Length && char.IsDigit(s[index]))
        {
            int digit = s[index] - '0';

            // Kiểm tra nếu nhân result với 10 có vượt quá giới hạn không

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
            {
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            index++;
        }

        return result * sign;

    }

    /// <summary>
    /// Sử dụng Dictionary
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int start = 0;
        Dictionary<char, int> charMap = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++)
        {
            char currentChar = s[end];

            if (charMap.ContainsKey(currentChar))
            {
                start = Math.Max(start, charMap[currentChar] + 1);
            }

            charMap[currentChar] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;


    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    /// <summary>
    /// Sử dụng Link-Noted
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode();
        ListNode current = dummyHead;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry;

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            int digit = sum % 10;
            carry = sum / 10;

            current.next = new ListNode(digit);
            current = current.next;

        }

        return dummyHead.next;
    }

    /// <summary>
    /// Thuật toán chia để trị
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double result;

        var mergedArray = nums1.Concat(nums2).ToArray();
        var sortedArray = mergedArray.OrderBy(num => num).ToArray();

        // 1, 2, 3, 4 ,5, 6 length = 6 /2 = 3

        int haflLen = sortedArray.Length / 2;
        if (sortedArray.Length % 2 == 0)
        {
            result = (sortedArray[haflLen] + sortedArray[haflLen - 1]) / 2.0;
        }
        else
            result = sortedArray[haflLen];

        return result;

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

        //int[] answer = new int[4];
        //answer = ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });

        //var result = FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
        //Console.WriteLine(result);


        List<string> listCard = new List<string>(104);
        Dictionary<string, int> mapCardScore = new Dictionary<string, int>();

        List<string> playerHand = new List<string>();
        List<string> bankerHand = new List<string>();

        int cardIndex = 10;
        int banker = 0;
        int player = 0;
        int equal = 0;

        bacarat bacarat = new bacarat();
        bacarat.CreateCard(mapCardScore, listCard);
        for (int i = 0; i < 30; i++)
        {
            bacarat.StartMatch(mapCardScore, listCard, playerHand, bankerHand, ref cardIndex, ref player, ref banker, ref equal );
            playerHand.Clear();
            bankerHand.Clear();
        }

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"Result: B:{banker} - P:{player} - E:{equal} ");


    }
}

