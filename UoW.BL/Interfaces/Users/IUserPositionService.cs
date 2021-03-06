﻿using UoW.Models.Users;

namespace UoW.BL.Interfaces.Users
{
    public interface IUserPositionService
    {
        UserPosition GetUserPosition(int userPositionId);
        void SaveUserPosition(UserPosition userPosition);
        void DeleteUserPosition(int userPositionId);
    }
}
