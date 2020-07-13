﻿using Microsoft.AspNetCore.Mvc;
using Summaries.Data.Models;
using Summaries.Data.Services;

namespace Summaries.Controllers
{
    [Route("api/[controller]")]
    public class BooksController:Controller
    {
        private IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }

        //Create/Add a new book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _service.AddBook(book);
            return Ok("Added");
        }
    }
}