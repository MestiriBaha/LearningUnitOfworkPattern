using LearningUnitOfworkPattern.core;
using LearningUnitOfworkPattern.core.Interfaces;
using LearningUnitOfworkPattern.core.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningUnitOfworkPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _unitOfWork; 
        public BooksController ( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }
        [HttpGet]
        public IActionResult GetByID()
        {
            return Ok(_unitOfWork.Books.GetByID(1)); 
        }
            }
}
