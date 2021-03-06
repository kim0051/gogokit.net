﻿using GogoKit.Models;
using GogoKit.Models.Response;
using HalKit.Http;

namespace GogoKit.Exceptions
{
    public class InvalidDeleteException : ApiErrorException
    {
        public InvalidDeleteException(IApiResponse<ApiError> response)
            : base(response)
        {
        }
    }
}