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


    }
}
