using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime.Test
{
    public class UnitTest5
    {
        Services services;
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            services = new Services(); // Initialize your shared resource
        }
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
            Assert.That(ketQua, Is.True);
        }


        [Test]
        [TestCase(11)]
        [TestCase(7)]
        public void TC_La_So_Nguyen_To(int value)
        {
            bool ketQua = services.IsPrime(value);
            Assert.That(ketQua, Is.True);
        }

        [Test]
        [TestCase(4)]

        public void TC_Khong_La_So_Nguyen_To(int value)
        {
            bool ketQua = services.IsPrime(value);
            Assert.That(ketQua, Is.False);
        }
    }

}
