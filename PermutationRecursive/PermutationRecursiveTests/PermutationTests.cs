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

        [TestMethod()]
        public void SetSourceTest_length_3()
        {
            // arrange
            List<string> source = new List<string> { "b", "c", "d" };
            List<List<string>> expected = new List<List<string>> {
                new List<string> { "b", "c", "d" },
                new List<string> { "b", "d", "c" },
                new List<string> { "c", "b", "d" },
                new List<string> { "c", "d", "b" },
                new List<string> { "d", "b", "c" },
                new List<string> { "d", "c", "b" },
            };

            // act
            Permutation target = new Permutation(source);
            var actual = target.Result;

            // assert
            expected.ToExpectedObject().ShouldMatch(actual);
        }
    }
}