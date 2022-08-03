// <copyright file="Filters4.cs" company="APIMatic">
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
    /// Filters4.
    /// </summary>
    public class Filters4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filters4"/> class.
        /// </summary>
        public Filters4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filters4"/> class.
        /// </summary>
        /// <param name="expression">expression.</param>
        /// <param name="field">field.</param>
        /// <param name="mValue">value.</param>
        /// <param name="values">values.</param>
        public Filters4(
            Models.ExpressionEnum? expression = null,
            string field = null,
            string mValue = null,
            List<string> values = null)
        {
            this.Expression = expression;
            this.Field = field;
            this.MValue = mValue;
            this.Values = values;
        }

        /// <summary>
        /// Gets or sets Expression.
        /// </summary>
        [JsonProperty("expression", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExpressionEnum? Expression { get; set; }

        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets Values.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filters4 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Filters4 other &&
                ((this.Expression == null && other.Expression == null) || (this.Expression?.Equals(other.Expression) == true)) &&
                ((this.Field == null && other.Field == null) || (this.Field?.Equals(other.Field) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.Values == null && other.Values == null) || (this.Values?.Equals(other.Values) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Expression = {(this.Expression == null ? "null" : this.Expression.ToString())}");
            toStringOutput.Add($"this.Field = {(this.Field == null ? "null" : this.Field == string.Empty ? "" : this.Field)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
            toStringOutput.Add($"this.Values = {(this.Values == null ? "null" : $"[{string.Join(", ", this.Values)} ]")}");
        }
    }
}