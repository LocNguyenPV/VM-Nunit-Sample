using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CheckPrime.Test
{
    public class TestProduct
    {
        Product product;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            product = new Product();
           
        }

        [SetUp]
        public void SetUp()
        {
            product.Price = 100;
        }
      
        [Test]
        [TestCase("Laptop", "Dell")]
        [TestCase("Mobile", "Android")]
        public void TC3(string name, string description)
        {
            product.Name = name;
            product.Description = description;
            var chuoiSoSanh = $@"Name: {name} - Description: {description}";
            var ketQua = product.ToString();
            Assert.That(ketQua, Is.EqualTo(chuoiSoSanh));
        }


        [Test]
        [TestCase(2, 200)]
        [TestCase(5, 500)]
        public void TC4(int soLuong, float tongTien)
        {
            product.Amount = soLuong;
            // Error
            product.Price = 10;
            Console.WriteLine(product.Price);
            var ketQua = product.TotalPrice;
            Assert.That(ketQua, Is.EqualTo(tongTien));
        }

        [Test]
        [TestCase(10, 1000)]
        [TestCase(20, 2000)]
        public void TC5(int soLuong, float tongTien)
        {
            Console.WriteLine(product.Price);
            product.Amount = soLuong;
            var ketQua = product.TotalPrice;
            Assert.That(ketQua, Is.EqualTo(tongTien));
        }


    }
}
