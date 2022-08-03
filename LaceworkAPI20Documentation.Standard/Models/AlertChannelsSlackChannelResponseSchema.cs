// <copyright file="AlertChannelsSlackChannelResponseSchema.cs" company="APIMatic">
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
    /// AlertChannelsSlackChannelResponseSchema.
    /// </summary>
    public class AlertChannelsSlackChannelResponseSchema : AlertChannelsResponseSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsSlackChannelResponseSchema"/> class.
        /// </summary>
        public AlertChannelsSlackChannelResponseSchema()
        {
            this.Type = "SlackChannel";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertChannelsSlackChannelResponseSchema"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="data">data.</param>
        /// <param name="type">type.</param>
        /// <param name="isOrg">isOrg.</param>
        /// <param name="props">props.</param>
        public AlertChannelsSlackChannelResponseSchema(
            string name,
            double enabled,
            Models.Data11 data,
            string type = "SlackChannel",
            double? isOrg = 0,
            object props = null)
            : base(
                type)
        {
            this.Name = name;
            this.Enabled = enabled;
            this.Data = data;
            this.IsOrg = isOrg;
            this.Props = props;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public double Enabled { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data11 Data { get; set; }

        /// <summary>
        /// Gets or sets IsOrg.
        /// </summary>
        [JsonProperty("isOrg", NullValueHandling = NullValueHandling.Ignore)]
        public double? IsOrg { get; set; }

        /// <summary>
        /// Gets or sets Props.
        /// </summary>
        [JsonProperty("props", NullValueHandling = NullValueHandling.Ignore)]
        public object Props { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AlertChannelsSlackChannelResponseSchema : ({string.Join(", ", toStringOutput)})";
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

            return obj is AlertChannelsSlackChannelResponseSchema other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Enabled.Equals(other.Enabled) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.IsOrg == null && other.IsOrg == null) || (this.IsOrg?.Equals(other.IsOrg) == true)) &&
                ((this.Props == null && other.Props == null) || (this.Props?.Equals(other.Props) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Enabled = {this.Enabled}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.IsOrg = {(this.IsOrg == null ? "null" : this.IsOrg.ToString())}");
            toStringOutput.Add($"Props = {(this.Props == null ? "null" : this.Props.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}