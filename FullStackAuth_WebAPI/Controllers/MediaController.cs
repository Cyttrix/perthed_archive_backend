﻿using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using MySqlX.XDevAPI;
using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860



namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public MediaController(ApplicationDbContext context)
        {
            _context = context;
        }


        // Post api/<MediaController>/5
        [HttpPost, Authorize]
        public IActionResult PostMediaToList([FromBody] Media data)
        {
            try
            {
                string userId = User.FindFirstValue("id");

                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized();
                }

                data.UserId = userId;

                _context.Media.Add(data);
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

        //PUT api/<MediaController>/5
        [HttpPut("{id}"), Authorize]
        public IActionResult UpdateMediaInList(int id, [FromBody] Media data)
        {
            try
            {
                //Find the Media to be updated
                Media media = _context.Media.Include(r => r.User).FirstOrDefault(m => m.Id == id);

                if (media == null)
                {
                    //Return a 404 Note Found error if the media with the specified ID does not exist
                    return NotFound();
                }

                //Check if the authenticated user is the user of the review
                var userId = User.FindFirstValue("id");
                if (string.IsNullOrEmpty(userId) || media.UserId == userId)
                {
                    //Return a 401 Unauthroized error if the authenticated user is not the user of the media in the list
                    return Unauthorized();
                }


                //Update the media properties
                media.UserId = userId;
                media.User = _context.Users.Find(userId);
                media.Status = data.Status;
                media.Score = data.Score;
                media.Progress = data.Progress;
                media.DateCompleted = data.DateCompleted;
                media.Note = data.Note;

                


                if (!ModelState.IsValid)
                {
                    //Return a 400 Bad Request error if the request data is invalid
                    return BadRequest(ModelState);
                }
                _context.SaveChanges();


                //Return a 201 Created status code and the updated media object
                return StatusCode(201, media);
            }
            catch (Exception ex)
            {
                //Return a 500 Internal Server Error with the error message if an exception occurs
                return StatusCode(500, ex.Message);
            }
        }


        // DELETE api/<MediaController>/5
        [HttpDelete("{id}"), Authorize]
        public IActionResult DeleteMediaInList(int id)
        {
          try {
              //Find the media in list to be deleted
              Media media = _context.Media.FirstOrDefault(m => m.Id == id);
              if (media == null)
                {
                    return NotFound();
                }

                //Check if the authenticated user is the user of the media
                var userId = User.FindFirstValue("id");
                if (string.IsNullOrEmpty(userId) || media.UserId != userId)
                {
                    //Return a 401 Unauthorized error if the authenticated user is not the user of the media
                    return Unauthorized();
                }

                //Remove the media from the database
                _context.Media.Remove(media);
                _context.SaveChanges();

                //Return a 204 No Content status code
                return StatusCode(204);
          }
          catch (Exception ex)
            {
                //Return a 500 Internal Server Error with the message if an exception occurs
                return StatusCode(500, ex.Message);
            }
        }
    }
}
