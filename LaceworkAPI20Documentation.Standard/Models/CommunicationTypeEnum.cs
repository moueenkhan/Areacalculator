// <copyright file="CommunicationTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CommunicationTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommunicationTypeEnum
    {
        /// <summary>
        /// HTTPS.
        /// </summary>
        [EnumMember(Value = "HTTPS")]
        HTTPS,

        /// <summary>
        /// EnumHTTPSSelfSignedCert.
        /// </summary>
        [EnumMember(Value = "HTTPS Self Signed Cert")]
        EnumHTTPSSelfSignedCert
    }
}