using BookstoreApi.Models;

namespace BookstoreApi.Data;

public static class DummyData
{
    public static List<Book> books = [
        new Book { Id = 1, Title = "Dom Casmurro", Author = "Machado de Assis", Gender = "Fiction", Price = 25.99, Stock = 50 },
        new Book { Id = 2, Title = "Orgulho e Preconceito", Author = "Jane Austen", Gender = "Romance", Price = 19.99, Stock = 30 },
        new Book { Id = 3, Title = "Sherlock Holmes: Um Estudo em Vermelho", Author = "Arthur Conan Doyle", Gender = "Mystery", Price = 29.99, Stock = 20 },
        new Book { Id = 4, Title = "1984", Author = "George Orwell", Gender = "Fiction", Price = 21.50, Stock = 40 },
        new Book { Id = 5, Title = "A Menina que Roubava Livros", Author = "Markus Zusak", Gender = "Fiction", Price = 27.75, Stock = 25 },
        new Book { Id = 6, Title = "O Morro dos Ventos Uivantes", Author = "Emily Brontë", Gender = "Romance", Price = 23.00, Stock = 35 },
        new Book { Id = 7, Title = "O Caso dos Dez Negrinhos", Author = "Agatha Christie", Gender = "Mystery", Price = 18.99, Stock = 15 },
        new Book { Id = 8, Title = "A Revolução dos Bichos", Author = "George Orwell", Gender = "Fiction", Price = 20.50, Stock = 60 },
        new Book { Id = 9, Title = "Orgulho e Preconceito", Author = "Jane Austen", Gender = "Romance", Price = 19.99, Stock = 30 },
        new Book { Id = 10, Title = "O Nome da Rosa", Author = "Umberto Eco", Gender = "Mystery", Price = 31.25, Stock = 18 }
    ];

}
