using Elementary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace Elementary_Unit_Test
{
    [TestClass]
    [TestCategory("Random number generation tests")]
    public class ElementaryUnitTest_Random
    {
        [TestMethod]
        public void RandomFloatIntegrity()
        {
            for (int i = 0; i < 1000; i++) // With negatives and positives
            {
                float rnd = Mathf.Random(-1000f, 1000f);

                if (rnd < -1000f || rnd > 1000f)
                    Assert.Fail($"Random float integrity check failed with negatives & positives test\nExpected range: -1000 < x < 1000\nGot: {rnd}");
            }

            for (int i = 0; i < 1000; i++) // With positives only
            {
                float rnd = Mathf.Random(0f, 1000f);

                if (rnd < 0f || rnd > 1000f)
                    Assert.Fail($"Random float integrity check failed with positives only test\nExpected range: 0 < x < 1000\nGot: {rnd}");
            }

            for (int i = 0; i < 1000; i++) // With negatives only
            {
                float rnd = Mathf.Random(-1000f, 0f);

                if (rnd < -1000f || rnd > 0f)
                    Assert.Fail($"Random float integrity check failed with negatives only test\nExpected range: -1000 < x < 0\nGot: {rnd}");
            }
        }

        [TestMethod]
        public void RandomDoubleIntegrity()
        {
            for (int i = 0; i < 1000; i++) // With negatives and positives
            {
                double rnd = Mathf.Random(-1000.0, 1000.0);

                if (rnd < -1000.0 || rnd > 1000.0)
                    Assert.Fail($"Random double integrity check failed with negatives & positives test\nExpected range: -1000 < x < 1000\nGot: {rnd}");
            }

            for (int i = 0; i < 1000; i++) // With positives only
            {
                double rnd = Mathf.Random(0, 1000.0);

                if (rnd < 0 || rnd > 1000.0)
                    Assert.Fail($"Random double integrity check failed with positives only test\nExpected range: 0 < x < 1000\nGot: {rnd}");
            }

            for (int i = 0; i < 1000; i++) // With negatives only
            {
                double rnd = Mathf.Random(-1000.0, 0);

                if (rnd < -1000.0 || rnd > 0.0)
                    Assert.Fail($"Random double integrity check failed with negatives only test\nExpected range: -1000 < x < 0\nGot: {rnd}");
            }
        }

        [TestMethod]
        public void RandomSeedConsistency()
        {
            Mathf.Seed = 8888;
            int[] nums = new int[100];

            // First iteration
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Mathf.Random();
            }

            // 10 Iterations of reinitializing the same seed, and checking if the randomly generated numbers are the same
            for (int index = 0; index < 10; index++)
            {
                Mathf.Seed = 8888;

                for (int i = 0; i < nums.Length; i++)
                {
                    int rnd = Mathf.Random();
                    if (rnd != nums[i])
                        Assert.Fail($"Seed not consistent on iteration #{index + 1} on number #{i + 1}\nExpected: {nums[i]}\nGot: {rnd}");
                }
            }

            // Just to be sure, let's try making another seed, and check it's equality too.
            Mathf.Seed = 1234;
            bool same = true;
            for (int i = 0; i < nums.Length; i++)
            {
                int rnd = Mathf.Random();
                if (rnd != nums[i])
                {
                    same = false;
                    break;
                }
            }

            if (same)
                Assert.Fail($"Different seed returns same results as another seed");
        }
    }

    [TestClass]
    [TestCategory("Elementary math tests")]
    public class ElementaryUnitTest_Math
    {
        [TestMethod]
        public void FibonacciIntegrity()
        {
            long[] expected = new long[10] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int i = 0;
            foreach (long fib in Mathf.Fibonacci.Take(10))
            {
                Assert.AreEqual(expected[i++], fib);
            }
        }
    }
}
