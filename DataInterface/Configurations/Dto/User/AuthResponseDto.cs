﻿namespace DataInterface.Configurations.Dto.User
{
    public class AuthResponseDto
    {
        public string UserId { get; set; }
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
        public string ErrorMessage { get; set; }

    }
}
