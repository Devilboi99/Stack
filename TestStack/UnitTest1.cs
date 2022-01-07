using NUnit.Framework;
using System;
using stack;

namespace TestStack
{
    [TestFixture]
    public class TestCasePush
    {

        [TestCase(10)]
        public void Test(int count)
        {
            var stack = new Stack<int>();
            for (var j = 0; j < count; j++)
            {
                stack.Push(j);
            }
        }

        [TestCase(24, 21)]
        public void TestPop(int countPush, int countPop)
        {
            

        }

        [TestFixture]
    public class TestStackPop
    {
    }

}
}