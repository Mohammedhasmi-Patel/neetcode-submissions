public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> dic = new Dictionary<int,int>();

        foreach(int num in nums){
            if(dic.ContainsKey(num)){
                dic[num]++;
            }else{
                dic[num] = 1;
            }
        }

        // if(dic.Count == k){
        //     List<int> arr = new List<int>();
        //     foreach(var kv in dic){
        //         arr.Add(kv.Value);
        //     }
        //     return arr.ToArray();
        // }
        
        List<int> sortedValues = new List<int>();
        foreach(var kv in dic){
            sortedValues.Add(kv.Value);
        }

        sortedValues.Sort();
        sortedValues.Reverse();
        List<int> topKFreq = new List<int>();
        foreach(int num in sortedValues){
            if(topKFreq.Count == k) break;
            topKFreq.Add(num);
        }
        List<int> ans = new List<int>();

        foreach(var kv in dic){
            int key = kv.Key;
            int value = kv.Value;
            if(topKFreq.Contains(value)){
                ans.Add(key);
            }
        }

        return ans.ToArray();

        
    }
}
