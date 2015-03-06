﻿using System;
using System.Threading;

namespace GogoKit.Configuration
{
    public interface IConfiguration
    {
        Uri ViagogoApiUrl { get; set; }
        Uri ViagogoOAuthTokenUrl { get; set; }

        /// <summary>
        /// Determines whether asynchronous operations should capture the current
        /// <see cref="SynchronizationContext"/>.
        /// </summary>
        /// <remarks>See http://blog.stephencleary.com/2012/02/async-and-await.html#avoiding-context.</remarks>
        bool CaptureSynchronizationContext { get; set; }

        string LanguageCode { get; set; }
        string CountryCode { get; set; }
        string CurrencyCode { get; set; }
    }
}