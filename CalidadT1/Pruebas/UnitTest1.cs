using CalidadT1;
using NUnit.Framework;

namespace Pruebas
{
    public class TestRomanos
    {
        [Test]
        public void Caso01Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(1);
            Assert.AreEqual("I", valor);
        }
        [Test]
        public void Caso02Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(5);
            Assert.AreEqual("V", valor);
        }
        [Test]
        public void Caso03Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(10);
            Assert.AreEqual("X", valor);
        }
        [Test]
        public void Caso04Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(50);
            Assert.AreEqual("L", valor);
        }
        [Test]
        public void Caso05Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(100);
            Assert.AreEqual("C", valor);
        }
        [Test]
        public void Caso06Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(500);
            Assert.AreEqual("D", valor);
        }
        [Test]
        public void Caso07Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(1000);
            Assert.AreEqual("M", valor);
        }
        [Test]
        public void Caso08Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(11);
            Assert.AreEqual("XI", valor);
        }
        [Test]
        public void Caso09Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(24);
            Assert.AreEqual("XXIV", valor);
        }
        [Test]
        public void Caso10Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(20);
            Assert.AreEqual("XX", valor);
        }
        [Test]
        public void Caso11Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(29);
            Assert.AreEqual("XXIX", valor);
        }
        [Test]
        public void Caso12Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(13);
            Assert.AreEqual("XIII", valor);
        }
        [Test]
        public void Caso13Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(111);
            Assert.AreEqual("CXI", valor);
        }
        [Test]
        public void Caso14Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(124);
            Assert.AreEqual("CXXIV", valor);
        }
        [Test]
        public void Caso15Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(120);
            Assert.AreEqual("CXX", valor);
        }
        [Test]
        public void Caso16Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(129);
            Assert.AreEqual("CXXIX", valor);
        }
        [Test]
        public void Caso17Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(113);
            Assert.AreEqual("CXIII", valor);
        }
        [Test]
        public void Caso18Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(411);
            Assert.AreEqual("CDXI", valor);
        }
        [Test]
        public void Caso19Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(424);
            Assert.AreEqual("CDXXIV", valor);
        }
        [Test]
        public void Caso20Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(420);
            Assert.AreEqual("CDXX", valor);
        }
        [Test]
        public void Caso21Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(429);
            Assert.AreEqual("CDXXIX", valor);
        }
        [Test]
        public void Caso22Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(413);
            Assert.AreEqual("CDXIII", valor);
        }
        [Test]
        public void Caso23Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(611);
            Assert.AreEqual("DCXI", valor);
        }
        [Test]
        public void Caso24Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(720);
            Assert.AreEqual("DCCXX", valor);
        }
        [Test]
        public void Caso25Romanos()
        {
            var romano = new RomanoGenerator();
            var valor = romano.GetRomano(824);
            Assert.AreEqual("DCCCXXIV", valor);
        }
    }
}