﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UoW.BL.Interfaces.Users;
using UoW.Models.Contracts.Requests;
using UoW.Models.Contracts.Responses;
using UoW.Models.Users;

namespace UoW.Controllers.Users
{
    [Route("[controller]")]
    [ApiController]
    public class UserPositionController : ControllerBase
    {
        private IUserPositionService _userPositionService;
        private IMapper _mapper;
        public UserPositionController(IUserPositionService userPositionService, IMapper mapper)
        {
            _userPositionService = userPositionService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUserPosition(int positionId)
        {
            var position = _userPositionService.GetUserPosition(positionId);

            if (position == null) return NotFound($"Position with Id {positionId}");

            var response = _mapper.Map<UserPositionResponse>(position);

            return Ok(response);
        }

        [HttpPost]
        public IActionResult SaveUserPosition(UserPositionRequest request)
        {
            if (request == null) return NotFound(request);

            var position = _mapper.Map<UserPosition>(request);

            _userPositionService.SaveUserPosition(position);

            return Ok(position);
        }

        [HttpDelete]
        public IActionResult DeleteUserPosition(int positioId)
        {

            _userPositionService.DeleteUserPosition(positioId);

            return Ok();
        }

    }
}
