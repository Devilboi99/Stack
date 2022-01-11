using NUnit.Framework;
using System;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.Drawing;
using System.Text;
using stack;

namespace TestStack
{
    [TestFixture]
    public class TestCasePushAndPop
    {
        [TestCase(10, 5, "98765", 5,"4")]
        [TestCase(2,0, "", 2,"1")]
        [TestCase(1,1,"0",0, "System.ArgumentException: Стек пуст")]
        public void Test(int countElements,int countPop, string exceptedValue, int exceptedSize, string exceptedTop)
        {
            var stack = new Stack<int>();
            var actualValue = new StringBuilder();
            for (var j = 0; j < countElements; j++)
            {
                stack.Push(j);
            }
            for (var j = 0; countPop > j; j++)
                actualValue.Append(stack.Pop());
            
            Assert.AreEqual(exceptedValue, actualValue.ToString());
            Assert.AreEqual(stack.Top().ToString(), exceptedTop);
            Assert.AreEqual(exceptedSize, stack.Size);
            stack.Clear();
            Assert.AreEqual(stack.Size, 0);
            
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