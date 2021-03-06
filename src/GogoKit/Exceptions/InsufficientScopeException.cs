﻿using GogoKit.Models;
using GogoKit.Models.Response;
using HalKit.Http;

namespace GogoKit.Exceptions
{
    public class InsufficientScopeException : ApiErrorException
    {
        public InsufficientScopeException(IApiResponse<ApiError> response) : base(response)
        {
        }
    }
}
