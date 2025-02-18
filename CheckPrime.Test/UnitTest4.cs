using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime.Test
{
    [TestFixture]
    public class UnitTest5
    {
        Services services = new Services();

        [Test]
        public void TC1()
        {
           bool ketQua = services.IsPrime(14);
           Assert.That(ketQua, Is.False);
        }

        [Test]
        public void TC2()
        {
            bool ketQua = services.IsPrime(11);
            Assert.That(ketQua, Is.True);
        }

        [Test]
        public void TC3()
        {
            bool ketQua = services.IsPrime(1);
            Assert.That(ketQua, Is.False);
        }

        [Test]
        public void TC4()
        {
            bool ketQua = services.IsPrime(0);
            Assert.That(ketQua, Is.False);
        }

        [Test]
        public void TC5()
        {
            bool ketQua = services.IsPrime(7);
            Assert.That(ketQua, Is.False);
        }
    }

}
