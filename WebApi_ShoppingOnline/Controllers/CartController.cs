﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_ShoppingOnline.Entity;
using WebApi_ShoppingOnline.Service.CartService;

namespace WebApi_ShoppingOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private CartService _cartService;
        public CartController()
        {
            _cartService = new CartService();
        }

        [HttpGet("GetBooksInCart")]
        public IActionResult GetBooksInCart()
        {
            try
            {
                List<CartBook> cartBooks = _cartService.GetCartBooks();
                return StatusCode(StatusCodes.Status200OK, cartBooks);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "có lỗi xảy ra");
            }
        }

        [HttpPost("AddBooksToCart")]
        public IActionResult AddBooksToCart([FromBody] Cart cart, int NumberOfBooks)
        {
            try
            {
                Book book = null;
                Boolean checkAdd = _cartService.AddBooksToCart(cart, book, NumberOfBooks);
                if (checkAdd) return StatusCode(StatusCodes.Status200OK, checkAdd);
                else return StatusCode(StatusCodes.Status422UnprocessableEntity, "Dữ liệu không được xác thực");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "có lỗi xảy ra");
            }
        }
    }
}
