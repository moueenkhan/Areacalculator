// <copyright file="Props15.cs" company="APIMatic">
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
    /// Props15.
    /// </summary>
    public class Props15
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Props15"/> class.
        /// </summary>
        public Props15()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Props15"/> class.
        /// </summary>
        /// <param name="organization">organization.</param>
        /// <param name="projects">projects.</param>
        /// <param name="description">description.</param>
        public Props15(
            string organization,
            List<string> projects,
            string description = null)
        {
            this.Description = description;
            this.Organization = organization;
            this.Projects = projects;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Organization.
        /// </summary>
        [JsonProperty("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or sets Projects.
        /// </summary>
        [JsonProperty("projects")]
        public List<string> Projects { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Props15 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Props15 other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Organization == null && other.Organization == null) || (this.Organization?.Equals(other.Organization) == true)) &&
                ((this.Projects == null && other.Projects == null) || (this.Projects?.Equals(other.Projects) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Organization = {(this.Organization == null ? "null" : this.Organization == string.Empty ? "" : this.Organization)}");
            toStringOutput.Add($"this.Projects = {(this.Projects == null ? "null" : $"[{string.Join(", ", this.Projects)} ]")}");
        }
    }
}