// <copyright file="Type14Enum.cs" company="APIMatic">
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
    /// Type14Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type14Enum
    {
        /// <summary>
        /// VictorOps.
        /// </summary>
        [EnumMember(Value = "VictorOps")]
        VictorOps
    }
}