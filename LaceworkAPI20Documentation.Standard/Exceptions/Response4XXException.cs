// <copyright file="Response4XXException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using LaceworkAPI20Documentation.Standard;
    using LaceworkAPI20Documentation.Standard.Http.Client;
    using LaceworkAPI20Documentation.Standard.Models;
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Response4XXException.
    /// </summary>
    public class Response4XXException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Response4XXException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public Response4XXException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }
    }
}