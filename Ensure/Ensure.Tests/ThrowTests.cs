using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ensure.Tests
{
    [TestClass]
    public class ThrowTests
    {
        [TestMethod]
        public void Throw_New_ThrowsExceptionWithMessage()
        {
            try
            {
                Throw.New<FakeException>("bar message");
            }
            catch (FakeException e)
            {
                Assert.AreEqual(e.Message, "bar message");
                return;
            }

            Assert.Fail("Throw didn't throw expected exception type");
        }

        private class FakeException : Exception
        {
            public FakeException(string message) : base(message)
            {
            }
        }
    }
}
