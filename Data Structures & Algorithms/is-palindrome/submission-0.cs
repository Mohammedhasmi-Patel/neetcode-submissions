public class Solution {
    public bool IsPalindrome(string s) {
        
        int end = s.Length - 1;
        int start = 0;

        while(start < end ){
            if(!Char.IsLetterOrDigit(s[start])){
                start++;
                continue;
            }

            if(!Char.IsLetterOrDigit(s[end])){
                end--;
                continue;
            }

            if(Char.ToLower(s[start]) != Char.ToLower(s[end])){
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}
