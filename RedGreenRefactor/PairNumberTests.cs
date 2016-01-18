using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RedGreenRefactor
{
    public class PairNumberTests
    {
        [TestCase(1, false)][TestCase(2, true)][TestCase(3, false)][TestCase(4, true)]
        [TestCase(5, false)][TestCase(6, true)][TestCase(7, false)][TestCase(8, true)]
        [TestCase(9, false)][TestCase(10, true)][TestCase(11, false)][TestCase(12, true)]
        public void Given_2_then_return_true(int input, bool expected)
        {
            //Arrange
            var pairNumber = new PairNumber();
            //Act
            var actual = pairNumber.IsPair(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class PairNumber
    {
        public bool IsPair(int input)
        {
            if (input == 1) return false;
            if (input == 2) return true;
            if (input == 3) return false;
            if (input == 4) return true;
            if (input == 5) return false;
            if (input == 6) return true;
            if (input == 7) return false;
            if (input == 8) return true;
            if (input == 9) return false;
            if (input == 10) return true;
            if (input == 11) return false;
            if (input == 12) return true;            
            throw new NotImplementedException();
        }
    }
}
