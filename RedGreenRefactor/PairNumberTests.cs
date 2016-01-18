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
        [Test]
        public void Given_2_then_return_true()
        {
            //Arrange
            var pairNumber = new PairNumber();
            //Act
            var actual = pairNumber.IsPair(2);
            //Assert
            Assert.AreEqual(true, actual);
        }
    }

    public class PairNumber
    {
        public bool IsPair(int input)
        {
            throw new NotImplementedException();
        }
    }
}
