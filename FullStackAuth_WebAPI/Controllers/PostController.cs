using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: api/posts
        [HttpGet]
        public IActionResult GetAllPosts()
        {
            try
            {
                var posts = _context.Posts.ToList();

                return StatusCode(200, posts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<PostController>
        [HttpPost]
        public IActionResult CreatePost([FromBody] Post data)
        {
            try
            {
                string userId = data.UserId;

                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized();
                }

                data.UserId = userId;

                


                //Add the post to the database and save changes
                _context.Posts.Add(data);
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.SaveChanges();

                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            try
            {
                //Find the post to be deleted
                Post post = _context.Posts.FirstOrDefault(p => p.Id == id);
                if (post == null)
                {
                    // Return a 404 Not Found error if the post with the specified ID does not exist
                    return NotFound();
                }

                //Check if the authenticated user is the user ofthe post
                string userId = User.FindFirstValue("id");
                if (string.IsNullOrEmpty(userId) || post.UserId != userId)
                {
                    // Return a 401 Unauthorized error if the authenticated user is not the user of the post
                    return Unauthorized();
                }

                //Remove the post from the database
                _context.Posts.Remove(post);
                _context.SaveChanges();

                //Return a 204 No Content status code
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                //Return a 500 Internal Server Error with the error message if an exception occurs
                return StatusCode(500, ex.Message);
            }
        }
    }
}
