﻿using System.Runtime.Serialization;
using HalKit.Models.Response;

namespace GogoKit.Models.Response
{
    [DataContract]
    public class Country : Resource
    {
        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}