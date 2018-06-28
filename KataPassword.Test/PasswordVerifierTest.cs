﻿using System;
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
        public void ShouldReturnTrueWhenPassword8WithLowerAndUpper()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("abcdefgjK"));
        }
        [TestMethod]
        public void ShouldReturnTrueWhenPassword8WithLowerAndDigit()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("abcdefgj0"));
        }
        [TestMethod]
        public void ShouldReturnTrueWhenPassword8WithLowerAndSymbol()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("abcdefgj@"));
        }

        [TestMethod]
        public void ShouldReturnTrueWhenPassword8WithUpperAndNumber()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("AZERTY1SD"));
        }

        [TestMethod]
        public void ShouldReturnTrueWhenPassword8WithUpperAndSymbol()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("123456&@"));
        }
        [TestMethod]
        public void ShouldReturnTrueWhenPassword8WithDigitAndSymbol()
        {
            Assert.IsTrue(PasswordVerifier.IsPwdValid("AZERTY&SD"));
        }

    }
}
