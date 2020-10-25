﻿using Microsoft.AspNetCore.Mvc;
using UoW.BL.Interfaces.Users;
using UoW.Models.Users;
using UoW.Models.Users;

namespace UoW.Controllers
{
    [Route("specialties")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private ISpecialtyService _specialtyService;

        public SpecialtyController(ISpecialtyService specialtyService)
        {
            _specialtyService = specialtyService;
        }
        [HttpGet]
        public Speciality GetSpecialty(int id)
        {
            return _specialtyService.GetSpecialtyById(id);
        }

        [HttpGet]
        public Speciality GetSpecialtyById(int specialtyId)
        {
            return _specialtyService.GetSpecialtyById(specialtyId);
        }
    }
}
