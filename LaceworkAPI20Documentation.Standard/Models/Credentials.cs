// <copyright file="Credentials.cs" company="APIMatic">
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
    /// Credentials.
    /// </summary>
    public class Credentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials"/> class.
        /// </summary>
        public Credentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials"/> class.
        /// </summary>
        /// <param name="clientId">clientId.</param>
        /// <param name="privateKeyId">privateKeyId.</param>
        /// <param name="clientEmail">clientEmail.</param>
        /// <param name="privateKey">privateKey.</param>
        public Credentials(
            string clientId,
            string privateKeyId,
            string clientEmail,
            string privateKey)
        {
            this.ClientId = clientId;
            this.PrivateKeyId = privateKeyId;
            this.ClientEmail = clientEmail;
            this.PrivateKey = privateKey;
        }

        /// <summary>
        /// Gets or sets ClientId.
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets PrivateKeyId.
        /// </summary>
        [JsonProperty("privateKeyId")]
        public string PrivateKeyId { get; set; }

        /// <summary>
        /// Gets or sets ClientEmail.
        /// </summary>
        [JsonProperty("clientEmail")]
        public string ClientEmail { get; set; }

        /// <summary>
        /// Gets or sets PrivateKey.
        /// </summary>
        [JsonProperty("privateKey")]
        public string PrivateKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Credentials : ({string.Join(", ", toStringOutput)})";
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

            return obj is Credentials other &&
                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.PrivateKeyId == null && other.PrivateKeyId == null) || (this.PrivateKeyId?.Equals(other.PrivateKeyId) == true)) &&
                ((this.ClientEmail == null && other.ClientEmail == null) || (this.ClientEmail?.Equals(other.ClientEmail) == true)) &&
                ((this.PrivateKey == null && other.PrivateKey == null) || (this.PrivateKey?.Equals(other.PrivateKey) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId == string.Empty ? "" : this.ClientId)}");
            toStringOutput.Add($"this.PrivateKeyId = {(this.PrivateKeyId == null ? "null" : this.PrivateKeyId == string.Empty ? "" : this.PrivateKeyId)}");
            toStringOutput.Add($"this.ClientEmail = {(this.ClientEmail == null ? "null" : this.ClientEmail == string.Empty ? "" : this.ClientEmail)}");
            toStringOutput.Add($"this.PrivateKey = {(this.PrivateKey == null ? "null" : this.PrivateKey == string.Empty ? "" : this.PrivateKey)}");
        }
    }
}