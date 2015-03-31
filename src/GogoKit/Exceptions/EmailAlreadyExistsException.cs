﻿using GogoKit.Models;
using HalKit.Http;

namespace GogoKit.Exceptions
{
    public class EmailAlreadyExistsException : ApiErrorException
    {
        public EmailAlreadyExistsException(IApiResponse<ApiError> response)
            : base(response)
        {
        }
    }
}