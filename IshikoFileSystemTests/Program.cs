using Ishiko.TestFramework;

namespace IshikoFileSystemTests
{
    class Program
    {
        static int Main(string[] args)
        {
            TestHarness theTestHarness = new TestHarness();

            return theTestHarness.run();
        }
    }
}
