using System;
using KataPassword.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPassword.Test
{
    [TestClass]
    public class PasswordVerifierTest
    {
        [TestMethod]
        public void ShouldReturnFalseWhenPasswordIs()
        {
            Assert.IsFalse(PasswordVerifier.IsPwdValid(string.Empty));
        }

        [TestMethod]
        public void ShouldReturnFalseWhenPasswordLess8()
        {
            Assert.IsFalse(PasswordVerifier.IsPwdValid("azerty"));
        }

        [TestMethod]
        public void ShouldReturnFalseWhenPassword8OnlyLower()
        {
            Assert.IsFalse(PasswordVerifier.IsPwdValid("abcdefgjk"));
        }
        [TestMethod]
        public void ShouldReturnTrueeWhenPassword8WithLowerAndUpper()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("abcdefgjK"));
        }
        [TestMethod]
        public void ShouldReturnTrueeWhenPassword8WithLowerAndDigit()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("abcdefgj0"));
        }

    }
}
