using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ensure;

namespace Ensure.Tests
{
    [TestClass]
    public class VerifyTests
    {
        [TestMethod]
        public void Verify_NotNullCheck_ThrowsArgumentNullExceptionWithMessage()
        {
            try
            {
                Verify.NotNull<FakeException>(null, "bar message");
            }
            catch(FakeException e)
            {
                Assert.AreEqual(e.Message, "bar message");
                return;
            }

            Assert.Fail("Not null check didn't throw expected exception type");
        }

        [TestMethod]
        public void Verify_NotNullCheck_ThrowsArgumentNullExceptionWithDefaultMessage()
        {
            try
            {
                Verify.NotNull<FakeException>(null);
            }
            catch (FakeException e)
            {
                Assert.AreEqual(e.Message, "Source object is null");
                return;
            }

            Assert.Fail("Not null check didn't throw expected exception type");
        }

        [TestMethod]
        public void Verify_NotNullCheck_DidNotThrowsArgumentNullExceptionWithMessage()
        {
            Verify.NotNull<FakeException>(new object(), "bar message");
        }

        [TestMethod]
        public void Verify_NotNullCheck_DidNotThrowsArgumentNullExceptionWithDefaultMessage()
        {
            Verify.NotNull<FakeException>(new object());
        }

        private class FakeException : Exception
        {
            public FakeException(string message) : base(message)
            {
            }
        }
    }
}
