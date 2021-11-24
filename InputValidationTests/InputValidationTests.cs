using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputValidationLibDN5;

namespace InputValidationTests
{
    [TestClass]
    public class isAlphabeticTests
    {
        [TestMethod]
        public void T001_check_abc_isValid()
        {
            bool isValid = IVL5.stringisAlpha("abc");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T002_check_abc123_isInValid()
        {
            bool isValid = IVL5.stringisAlpha("abc123");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void T003_check_dot123_isInValid()
        {
            bool isValid = IVL5.stringisAlpha(".123");

            Assert.IsFalse(isValid);
        }
    }

    [TestClass]
    public class isAlphanumericTests
    {
        [TestMethod]
        public void T101_check_abc123_isValid()
        {
            bool isValid = IVL5.stringisAlphaNum("abc123");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T102_check_abcpound123_isInValid()
        {
            bool isValid = IVL5.stringisAlphaNum("abc#123");

            Assert.IsFalse(isValid);
        }
    }

    [TestClass]
    public class isDigitTests
    {
        [TestMethod]
        public void T201_check_123_isValid()
        {
            bool isValid = IVL5.stringisDigit("123");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T202_check_dot123_isInValid()
        {
            bool isValid = IVL5.stringisDigit(".123");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void T203_check_abc123_isInValid()
        {
            bool isValid = IVL5.stringisDigit("abc123");

            Assert.IsFalse(isValid);
        }
    }

    [TestClass]
    public class isDecimalTests
    {
        [TestMethod]
        public void T301_check_123_isValid()
        {
            bool isValid = IVL5.stringisDecimal("123");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T302_check_dot123_isValid()
        {
            bool isValid = IVL5.stringisDecimal(".123");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T303_check_123dot456_isValid()
        {
            bool isValid = IVL5.stringisDecimal("123.456");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T304_check_abc_isInValid()
        {
            bool isValid = IVL5.stringisDecimal("abc");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void T305_check_123dtabc_isInValid()
        {
            bool isValid = IVL5.stringisDecimal("123.abc");

            Assert.IsFalse(isValid);
        }
    }

    [TestClass]
    public class isYNTests
    {
        [TestMethod]
        public void T401_check_y_isValid()
        {
            bool isValid = IVL5.stringisYN("y");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T402_check_Y_isValid()
        {
            bool isValid = IVL5.stringisYN("Y");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T403_check_n_isValid()
        {
            bool isValid = IVL5.stringisYN("n");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T404_check_N_isValid()
        {
            bool isValid = IVL5.stringisYN("N");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T405_check_abc_isInValid()
        {
            bool isValid = IVL5.stringisYN("abc");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void T406_check_123_isInValid()
        {
            bool isValid = IVL5.stringisYN("123");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void T407_check_abcdot123_isValid()
        {
            bool isValid = IVL5.stringisYN("abc.123");

            Assert.IsFalse(isValid);
        }
    }

    [TestClass]
    public class isTFTests
    {
        [TestMethod]
        public void T501_check_t_isValid()
        {
            bool isValid = IVL5.stringisTF("t");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T502_check_T_isValid()
        {
            bool isValid = IVL5.stringisTF("T");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T503_check_f_isValid()
        {
            bool isValid = IVL5.stringisTF("f");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T504_check_F_isValid()
        {
            bool isValid = IVL5.stringisTF("F");

            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void T505_check_abc_isInValid()
        {
            bool isValid = IVL5.stringisTF("abc");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void T506_check_123_isInValid()
        {
            bool isValid = IVL5.stringisTF("123");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void T507_check_abcdot123_isValid()
        {
            bool isValid = IVL5.stringisTF("abc.123");

            Assert.IsFalse(isValid);
        }
    }
}
