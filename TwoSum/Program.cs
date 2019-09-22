using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
          int [] myArr = { 2, 7, 11, 15 };
          
            foreach (var item in processArr(myArr, 9))
            {
                Console.WriteLine(item);
            }
          Console.ReadLine();
        }
    private static int [] processArr (int [] myArr, int target)
    {
            int[] result = { 0, 0};
            if (myArr == null || myArr.Length == 0) return result;
            Dictionary<int, int> visited = new Dictionary<int, int>();
            for (int i = 0; i < myArr.Length; i++)
            {
                if (visited.ContainsKey(target - myArr[i]))
                {
                    visited.TryGetValue((target - myArr[i]), out int value);
                    //if you want the values 
                    //result[0] = myArr[value];
                    //result[1] = myArr[i];
                    //if you want the array indexs
                    result[0] = value;
                    result[1] = i;
                }
                if (visited.ContainsKey(myArr[i])) continue;
                else visited.Add(myArr[i], i);
                
            }
            return result;
    }
    }
}
