﻿using AutoMapper;
using FDNS.Common.DataTransferObjects;
using FDNS.Services.Abstractions.Base;
using FDNS.WebAPI.Extensions;
using FDNS.WebAPI.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FDNS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AccountController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("register"), AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterUserRequest request)
        {
            var authUserDto = _mapper.Map<AuthUserDTO>(request);
            var result = await _userService.RegisterAsync(authUserDto);
            
            if (result.IsSuccess)
            {
                var userResponse = _mapper.Map<UserResponse>(result.Value.user, opts =>
                    opts.Items.Add("Token", result.Value.token));
                return Ok(userResponse);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost("login"), AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginUserRequest request)
        {
            var authUserDto = _mapper.Map<AuthUserDTO>(request);
            var result = await _userService.LoginAsync(authUserDto);

            if (result.IsSuccess)
            {
                var userResponse = _mapper.Map<UserResponse>(result.Value.user, opts => 
                    opts.Items.Add("Token", result.Value.token));
                return Ok(userResponse);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentUser()
        {
            var result = await _userService.GetCurrentUserAsync(User.GetUserName());
            var userResponse = _mapper.Map<UserResponse>(result.Value.user, opts =>
                opts.Items.Add("Token", result.Value.token));
            return result.IsSuccess ? Ok (userResponse) : BadRequest(result.Errors);
        }
    }
}