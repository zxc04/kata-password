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

       
    }
}
