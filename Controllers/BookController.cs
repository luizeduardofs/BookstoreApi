using BookstoreApi.Data;
using BookstoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : BookstoreApiBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAllBooks()
    {
        var books = DummyData.books;

        return Ok(books);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] Book request)
    {
        var newBook = new Book
        {
            Id = DummyData.books.Last().Id + 1,
            Title = request.Title,
            Author = request.Author,
            Gender = request.Gender,
            Price = request.Price,
            Stock = request.Stock,
        };

        DummyData.books.Add(newBook);

        return Created(string.Empty , newBook);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult UpdateBook([FromRoute] int id, [FromBody] Book request)
    {
        var existingBook = DummyData.books.FirstOrDefault(book => book.Id == id);

        if (existingBook == null)
            return NotFound("O livro não for encontrado na base de dados");

        existingBook.Title = request.Title;
        existingBook.Author = request.Author;
        existingBook.Gender = request.Gender;
        existingBook.Price = request.Price;
        existingBook.Stock = request.Stock;

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteBook([FromRoute] int id)
    {
        var bookToRemove = DummyData.books.FirstOrDefault(book => book.Id == id);

        if (bookToRemove == null)
            return NotFound("O livro não for encontrado na base de dados");

        DummyData.books.Remove(bookToRemove);
        return NoContent();
    }
}
