﻿namespace api.Dtos.User
{
    public class ChangePasswordRequestDTO
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
    }
}
