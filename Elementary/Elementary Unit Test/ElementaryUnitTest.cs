﻿using Elementary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace Elementary_Unit_Test
{
    [TestClass]
    [TestCategory("Random Number Generation Tests")]
    public class ElementaryUnitTestRandom
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
                if (rnd != i)
                {
                    same = false;
                    break;
                }
            }

            if (same)
                Assert.Fail("Different seed returns same results as another seed");
        }
    }

    [TestClass]
    [TestCategory("Elementary Math Tests")]
    public class ElementaryUnitTestMath
    {
        [TestMethod]
        public void FibonacciIntegrity()
        {
            ulong[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int i = 0;
            foreach (ulong fib in Mathf.Fibonacci.Take(10))
            {
                Assert.AreEqual(expected[i++], fib);
            }
        }

        [TestMethod]
        public void Primes()
        {
            uint[] expected = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int i = 0;
            foreach (uint prime in Mathf.Primes.Take(10))
            {
                Assert.IsTrue(expected[i++] == prime);
            }
        }

        [TestMethod]
        public void PrimesLong()
        {
            ulong[] expected = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int i = 0;
            foreach (ulong prime in Mathf.PrimesLong.Take(10))
            {
                Assert.IsTrue(expected[i++] == prime);
            }
        }

        [TestMethod]
        public void PrimesIntegrity()
        {
            int[] nums = { 5, 2, 0, 61, -10, -5, 911, 0 };
            bool[] expected = { true, true, false, true, false, false, true, false };

            for (int i = 0; i < nums.Length; i++)
            {
                Assert.IsTrue(nums[i].IsPrime() == expected[i]);
            }
        }
    }

    [TestClass]
    [TestCategory("Elementary LimitedQueue<T> Tests")]
    public class ElementaryUnitTestLimitedQueue
    {
        [TestMethod]
        public void QueueIntegrity()
        {
            LimitedQueue<int> queue = new LimitedQueue<int>(5);

            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(-6);

            Assert.IsTrue(queue.Count == 3);

            queue.Dequeue();

            Assert.IsTrue(queue.Count == 2);

            queue.Enqueue(0);
            queue.Enqueue(0);
            queue.Enqueue(0);
            queue.Enqueue(0);

            int[] expected = { -6, 0, 0, 0, 0 };
            int index = 0;

            foreach (int i in queue)
            {
                Assert.AreEqual(expected[index++], i);
            }

            queue.Dequeue();
            int peekedInt = queue.Peek();

            Assert.IsTrue(queue.Count == 4);
            Assert.IsTrue(peekedInt == 0);
            Assert.IsTrue(queue[3] == 0);

            queue.Capacity = 2;

            Assert.IsTrue(queue.Count == queue.Capacity);

            queue.Clear();
            
            Assert.IsTrue(queue.Count == 0);
        }
    }

    [TestClass]
    [TestCategory("Elementary IComparable<T> Extensions Tests")]
    public class ElementaryUnitTestComparableExtension
    {
        [TestMethod]
        public void RangeIntegrity()
        {
            Assert.IsTrue(5.InRange(0, 10));
            Assert.IsTrue(3.14f.InRange(0, 10));
            Assert.IsTrue(3.141.InRange(0, 10));
            Assert.IsTrue(8.125789541m.InRange(0, 10));
            Assert.IsTrue(0f.InRange(0, 10));
            Assert.IsTrue(10f.InRange(0, 10));

            Assert.IsFalse((-10).InRange(0, 10));
            Assert.IsFalse(100f.InRange(0, 10));
            Assert.IsFalse(10.00001.InRange(0, 10));
            Assert.IsFalse(int.MaxValue.InRange(0, 10));

            Assert.IsTrue(5.InRangeExclusive(0, 10));
            Assert.IsTrue(2.InRangeExclusive(0, 10));

            Assert.IsFalse((-1).InRangeExclusive(0, 10));
            Assert.IsFalse(12.InRangeExclusive(0, 10));
            Assert.IsFalse(0.InRangeExclusive(0, 10));
            Assert.IsFalse(10.InRangeExclusive(0, 10));
        }
    }
}
