// <copyright file="Props23.cs" company="APIMatic">
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
    /// Props23.
    /// </summary>
    public class Props23
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props23"/> class.
        /// </summary>
        public Props23()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props23"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="machineTags">machineTags.</param>
        public Props23(
            string description = null,
            List<Models.FormatKey1Value1Key2Value2> machineTags = null)
        {
            this.Description = description;
            this.MachineTags = machineTags;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets MachineTags.
        /// </summary>
        [JsonProperty("machineTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FormatKey1Value1Key2Value2> MachineTags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props23 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props23 other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.MachineTags == null && other.MachineTags == null) || (this.MachineTags?.Equals(other.MachineTags) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.MachineTags = {(this.MachineTags == null ? "null" : $"[{string.Join(", ", this.MachineTags)} ]")}");
        }
    }
}