using Elementary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Elementary_Unit_Test
{
    [TestClass]
    public class ElementaryUnitTest
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
    }
}
