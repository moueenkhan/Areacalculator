// <copyright file="Props6.cs" company="APIMatic">
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
    /// Props6.
    /// </summary>
    public class Props6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props6"/> class.
        /// </summary>
        public Props6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props6"/> class.
        /// </summary>
        /// <param name="accountIds">accountIds.</param>
        /// <param name="description">description.</param>
        public Props6(
            List<string> accountIds,
            string description = null)
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
        [JsonProperty("accountIds")]
        public List<string> AccountIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props6 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props6 other &&
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