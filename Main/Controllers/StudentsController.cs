﻿using API.Services;
using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _iStudentService;
        private readonly ICurrentUserService _iCurrentUserService;

        public StudentsController(IStudentService iStudentService, ICurrentUserService iCurrentUserService)
        {
            _iStudentService = iStudentService;
            _iCurrentUserService = iCurrentUserService;
        }

        [HttpPost("UpdateStudent")]
        public async Task<IActionResult> UpdateStudentAccount(StudentVM studentVM)
        {
            var accountId = _iCurrentUserService.GetUserId().ToString();
            if (accountId == null)
            {
                return BadRequest("Sign Account!!!");
            }
            var result = await _iStudentService.UpdateStudent(accountId, studentVM);
            return Ok(result);
        }

        [HttpGet("GetStudentCurrent")]
        public async Task<IActionResult> GetTutorCurrent()
        {
            var accountId = _iCurrentUserService.GetUserId().ToString();
            if (accountId == null)
            {
                return BadRequest("Sign Account!!!");
            }
            var result = await _iStudentService.GetStudentCurrent(accountId);
            return Ok(result);
        }
    }
}
