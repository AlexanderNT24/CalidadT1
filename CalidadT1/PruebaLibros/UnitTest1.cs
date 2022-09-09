using CalidadT1;
using NUnit.Framework;


namespace PruebaLibros
{
    public class TestLibros
    {
        [Test]
        public void Caso01Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro1";
            libro.Price = 10; 
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro1";
            libro2.Price = 10;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro1";
            libro3.Price = 10;
            tienda.AddToCart(libro3);
            var libro4 = new Book();
            libro4.Name = "Libro2";
            libro4.Price = 10;
            tienda.AddToCart(libro4);
            var precio = tienda.GetTotal();
            Assert.AreEqual(38, precio);
        }
        [Test]
        public void Caso02Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro3";
            libro.Price = 9;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro3";
            libro2.Price = 9;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro3";
            libro3.Price = 9;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(25.2, precio);
        }
        [Test]
        public void Caso03Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro4";
            libro.Price = 10;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro5";
            libro2.Price = 10;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro6";
            libro3.Price = 10;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(30, precio);
        }
        [Test]
        public void Caso04Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro7";
            libro.Price = 9;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro8";
            libro2.Price = 9;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro9";
            libro3.Price = 9;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(27, precio);
        }
        [Test]
        public void Caso05Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro10";
            libro.Price = 6;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro11";
            libro2.Price = 3;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro12";
            libro3.Price = 9;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(18,precio);
        }
        [Test]
        public void Caso06Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro4";
            libro.Price = 2;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro5";
            libro2.Price = 2;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro6";
            libro3.Price = 3;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(7, precio);
        }
        [Test]
        public void Caso07Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro1";
            libro.Price = 1;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro2";
            libro2.Price = 1;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro3";
            libro3.Price = 2;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(4, precio);
        }
        [Test]
        public void Caso08Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro1";
            libro.Price = 18;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro1";
            libro2.Price = 18;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro2";
            libro3.Price = 3;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(37.2, precio);
        }
        [Test]
        public void Caso09Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro1";
            libro.Price = 20;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro1";
            libro2.Price = 20;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro2";
            libro3.Price = 10;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(48, precio);
        }
        [Test]
        public void Caso10Libros()
        {
            var tienda = new BookStore();
            var libro = new Book();
            libro.Name = "Libro1";
            libro.Price = 8;
            tienda.AddToCart(libro);
            var libro2 = new Book();
            libro2.Name = "Libro1";
            libro2.Price = 8;
            tienda.AddToCart(libro2);
            var libro3 = new Book();
            libro3.Name = "Libro2";
            libro3.Price = 10;
            tienda.AddToCart(libro3);
            var precio = tienda.GetTotal();
            Assert.AreEqual(25.2, precio);
        }
    }
}