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
  }
}