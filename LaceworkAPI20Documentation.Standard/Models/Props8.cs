// <copyright file="Props8.cs" company="APIMatic">
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
    /// Props8.
    /// </summary>
    public class Props8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props8"/> class.
        /// </summary>
        public Props8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props8"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="accountIds">accountIds.</param>
        public Props8(
            string description = null,
            List<string> accountIds = null)
        {
            this.Description = description;
            this.AccountIds = accountIds;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets AccountIds.
        /// </summary>
        [JsonProperty("accountIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccountIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props8 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props8 other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AccountIds == null && other.AccountIds == null) || (this.AccountIds?.Equals(other.AccountIds) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.AccountIds = {(this.AccountIds == null ? "null" : $"[{string.Join(", ", this.AccountIds)} ]")}");
        }
    }
}