﻿using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestMethodAddition()
        {

            int a = 1;
            int b = 2;
            int exp = 3;

            CalculatorEngine engine = new CalculatorEngine();

            int actual = engine.Addition(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethodSoustration()
        {

            int a = 5;
            int b = 2;
            int exp = 3;

            CalculatorEngine engine = new CalculatorEngine();

            int actual = engine.Soustraction(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethodMultiplication()
        {

            int a = 1;
            int b = 2;
            int exp = 2;

            CalculatorEngine engine = new CalculatorEngine();

            int actual = engine.Multiplication(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethodDivision()
        {

            int a = 4;
            int b = 2;
            int exp = 2;

            CalculatorEngine engine = new CalculatorEngine();

            int actual = engine.Division(a, b);

            Assert.AreEqual(exp, actual);
        }

        //[TestMethod]
        #region testDivZero
        public void TestMethodDivisionParZero()
        {

            int a = 4;
            int b = 0;
            int exp = Int32.MinValue;

            CalculatorEngine engine = new CalculatorEngine();

            int actual = engine.Division(a, b);

            Assert.AreEqual(exp, actual);
        } 
        #endregion
    }
}
