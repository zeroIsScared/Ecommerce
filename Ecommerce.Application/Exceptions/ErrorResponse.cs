﻿namespace Ecommerce.WebAPI.Exceptions
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
    }
}
