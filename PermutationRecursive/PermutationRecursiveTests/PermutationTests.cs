using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PermutationRecursive.Tests
{
    [TestClass()]
    public class PermutationTests
    {
        [TestMethod()]
        public void SetSourceTest_length_2()
        {
            // arrange
            List<string> source = new List<string> { "a", "b" };
            List<List<string>> expected = new List<List<string>> {
                new List<string> { "a","b" },
                new List<string> { "b","a" },
            };

            // act
            Permutation target = new Permutation(source);
            var actual = target.Result;

            // assert
            expected.ToExpectedObject().ShouldMatch(actual);
        }
    }
}