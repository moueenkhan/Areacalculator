// <copyright file="Data84.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace LaceworkAPI20Documentation.Standard.Models
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
    using LaceworkAPI20Documentation.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Data84.
    /// </summary>
    public class Data84
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data84"/> class.
        /// </summary>
        public Data84()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data84"/> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="queueUrl">queueUrl.</param>
        public Data84(
            Models.Credentials10 credentials = null,
            string tenantId = null,
            string queueUrl = null)
        {
            this.Credentials = credentials;
            this.TenantId = tenantId;
            this.QueueUrl = queueUrl;
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credentials10 Credentials { get; set; }

        /// <summary>
        /// Gets or sets TenantId.
        /// </summary>
        [JsonProperty("tenantId", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets QueueUrl.
        /// </summary>
        [JsonProperty("queueUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data84 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Data84 other &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.TenantId == null && other.TenantId == null) || (this.TenantId?.Equals(other.TenantId) == true)) &&
                ((this.QueueUrl == null && other.QueueUrl == null) || (this.QueueUrl?.Equals(other.QueueUrl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.TenantId = {(this.TenantId == null ? "null" : this.TenantId == string.Empty ? "" : this.TenantId)}");
            toStringOutput.Add($"this.QueueUrl = {(this.QueueUrl == null ? "null" : this.QueueUrl == string.Empty ? "" : this.QueueUrl)}");
        }
    }
}