using System;

namespace Palindrome
{
  public class PalindromeClass
  {
    string word = "hello";
    public bool isPalindrome(string word){
      string[] stringArray;
      return true;
    }

    public bool palCenter(string word){ //return char
    
      char[] charArray = word.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray).Equals(word);

      }
  }
}