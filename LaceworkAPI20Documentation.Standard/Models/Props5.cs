// <copyright file="Props5.cs" company="APIMatic">
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
    /// Props5.
    /// </summary>
    public class Props5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props5"/> class.
        /// </summary>
        public Props5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props5"/> class.
        /// </summary>
        /// <param name="lwAccounts">lwAccounts.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="description">description.</param>
        public Props5(
            List<string> lwAccounts,
            string updatedBy = null,
            double? lastUpdated = null,
            string description = null)
        {
            this.UpdatedBy = updatedBy;
            this.LastUpdated = lastUpdated;
            this.Description = description;
            this.LwAccounts = lwAccounts;
        }

        /// <summary>
        /// Gets or sets UpdatedBy.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets LastUpdated.
        /// </summary>
        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public double? LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets LwAccounts.
        /// </summary>
        [JsonProperty("lwAccounts")]
        public List<string> LwAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props5 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props5 other &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true)) &&
                ((this.LastUpdated == null && other.LastUpdated == null) || (this.LastUpdated?.Equals(other.LastUpdated) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.LwAccounts == null && other.LwAccounts == null) || (this.LwAccounts?.Equals(other.LwAccounts) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
            toStringOutput.Add($"this.LastUpdated = {(this.LastUpdated == null ? "null" : this.LastUpdated.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.LwAccounts = {(this.LwAccounts == null ? "null" : $"[{string.Join(", ", this.LwAccounts)} ]")}");
        }
    }
}