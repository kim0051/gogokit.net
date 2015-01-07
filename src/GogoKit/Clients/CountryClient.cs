﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GogoKit.Http;
using GogoKit.Models;
using GogoKit.Resources;

namespace GogoKit.Clients
{
    public class CountryClient : ICountryClient
    {
        private readonly IApiRootClient _rootClient;
        private readonly IApiConnection _apiConnection;

        public CountryClient(IApiRootClient rootClient, IApiConnection apiConnection)
        {
            _rootClient = rootClient;
            _apiConnection = apiConnection;
        }

        public async Task<PagedResource<Country>> GetCountriesAsync(int page, int pageSize)
        {
            var root = await _rootClient.GetAsync();
            return await _apiConnection.GetAsync<PagedResource<Country>>(root.Links["viagogo:countries"], new Dictionary<string, string>
                                                                                                    {
                                                                                                        {"page", page.ToString()},
                                                                                                        {"page_size", pageSize.ToString()}
                                                                                                    });
        }
    }
}