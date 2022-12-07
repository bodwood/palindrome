using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeClassTests
  {
    [TestMethod]
    public void isPalindrome_WordInverse_True()
    {
      PalindromeClass testPalindrome = new PalindromeClass();
      Assert.AreEqual(true, testPalindrome.isPalindrome("deezeNutz"));
    }
    [TestMethod]
    public void palCenter_PalindromeCenter_Char()
    {
      PalindromeClass testPalindrome = new PalindromeClass();
      string palInput = "civic";
      Assert.AreEqual(true, testPalindrome.palCenter(palInput));
    }
  }
}