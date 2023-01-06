using LearningUnitOfworkPattern.core;
using LearningUnitOfworkPattern.core.Interfaces;
using LearningUnitOfworkPattern.core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningUnitOfworkPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork      
        public AuthorsController (IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork
                }
        [HttpGet]
        public IActionResult GetByID()
        {
            return Ok(_unitOfWork.Authors.GetByID(1));
        }
        [HttpGet("GetAll")]
    public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Authors.GetAll());
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_unitOfWork.Authors.Find(x => x.Name == "Baha")); 
        }
        [HttpPost("Add")]
        public IActionResult Add (Author baha  )
        {
            return Ok(_unitOfWork.Authors.Add(baha));   
        }
    }
}
