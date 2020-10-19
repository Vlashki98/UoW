﻿using PoW.DL.Interfaces.Users;
using PoW.DL.Repositories.Users;
using PoW.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;
using UoW.BL.Interface.User;

namespace UoW.BL.Services.User
{
    public class TeamService : ITeamService
    {
        ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public Team GetTeamById(int id)
        {
            return _teamRepository.GetById(id);
        }
    }
}
