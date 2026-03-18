public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(magazine.Length<ransomNote.Length){
            return false;
        }
        int[] count = new int[26];

        foreach(char c in magazine){
            count[c-'a']++;
        }
        foreach(char c in ransomNote){
            --count[c-'a'];
            if(count[c-'a']<0)
                return false;
        }
        return true;
    }
}
Console.WriteLine("Hello, World!");