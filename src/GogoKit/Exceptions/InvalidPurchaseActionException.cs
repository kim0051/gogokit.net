﻿using GogoKit.Models;
using HalKit.Http;

namespace GogoKit.Exceptions
{
    public class InvalidPurchaseActionException : ApiErrorException
    {
        public InvalidPurchaseActionException(IApiResponse<ApiError> response)
            : base(response)
        {
        }
    }
}