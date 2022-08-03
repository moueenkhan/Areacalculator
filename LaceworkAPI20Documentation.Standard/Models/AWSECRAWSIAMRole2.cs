// <copyright file="AWSECRAWSIAMRole2.cs" company="APIMatic">
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
    /// AWSECRAWSIAMRole2.
    /// </summary>
    public class AWSECRAWSIAMRole2 : Data94
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSECRAWSIAMRole2"/> class.
        /// </summary>
        public AWSECRAWSIAMRole2()
        {
            this.RegistryType = "AWS_ECR";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSECRAWSIAMRole2"/> class.
        /// </summary>
        /// <param name="registryType">registryType.</param>
        /// <param name="crossAccountCredentials">crossAccountCredentials.</param>
        /// <param name="awsAuthType">awsAuthType.</param>
        /// <param name="registryDomain">registryDomain.</param>
        /// <param name="limitNumImg">limitNumImg.</param>
        /// <param name="limitByRep">limitByRep.</param>
        /// <param name="limitByTag">limitByTag.</param>
        /// <param name="limitByLabel">limitByLabel.</param>
        public AWSECRAWSIAMRole2(
            string registryType = "AWS_ECR",
            Models.CrossAccountCredentials4 crossAccountCredentials = null,
            Models.AuthenticationTypeEnum? awsAuthType = Models.AuthenticationTypeEnum.AWSIAM,
            string registryDomain = null,
            Models.LimitNumberOfImagesPerRepoEnum? limitNumImg = Models.LimitNumberOfImagesPerRepoEnum.Enum5,
            List<string> limitByRep = null,
            List<string> limitByTag = null,
            List<Models.LimitByLabelSOptional> limitByLabel = null)
            : base(
                registryType)
        {
            this.CrossAccountCredentials = crossAccountCredentials;
            this.AwsAuthType = awsAuthType;
            this.RegistryDomain = registryDomain;
            this.LimitNumImg = limitNumImg;
            this.LimitByRep = limitByRep;
            this.LimitByTag = limitByTag;
            this.LimitByLabel = limitByLabel;
        }

        /// <summary>
        /// Gets or sets CrossAccountCredentials.
        /// </summary>
        [JsonProperty("crossAccountCredentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CrossAccountCredentials4 CrossAccountCredentials { get; set; }

        /// <summary>
        /// Gets or sets AwsAuthType.
        /// </summary>
        [JsonProperty("awsAuthType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthenticationTypeEnum? AwsAuthType { get; set; }

        /// <summary>
        /// Gets or sets RegistryDomain.
        /// </summary>
        [JsonProperty("registryDomain", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistryDomain { get; set; }

        /// <summary>
        /// Gets or sets LimitNumImg.
        /// </summary>
        [JsonProperty("limitNumImg", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LimitNumberOfImagesPerRepoEnum? LimitNumImg { get; set; }

        /// <summary>
        /// Gets or sets LimitByRep.
        /// </summary>
        [JsonProperty("limitByRep", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LimitByRep { get; set; }

        /// <summary>
        /// Gets or sets LimitByTag.
        /// </summary>
        [JsonProperty("limitByTag", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LimitByTag { get; set; }

        /// <summary>
        /// Gets or sets LimitByLabel.
        /// </summary>
        [JsonProperty("limitByLabel", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LimitByLabelSOptional> LimitByLabel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AWSECRAWSIAMRole2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is AWSECRAWSIAMRole2 other &&
                ((this.CrossAccountCredentials == null && other.CrossAccountCredentials == null) || (this.CrossAccountCredentials?.Equals(other.CrossAccountCredentials) == true)) &&
                ((this.AwsAuthType == null && other.AwsAuthType == null) || (this.AwsAuthType?.Equals(other.AwsAuthType) == true)) &&
                ((this.RegistryDomain == null && other.RegistryDomain == null) || (this.RegistryDomain?.Equals(other.RegistryDomain) == true)) &&
                ((this.LimitNumImg == null && other.LimitNumImg == null) || (this.LimitNumImg?.Equals(other.LimitNumImg) == true)) &&
                ((this.LimitByRep == null && other.LimitByRep == null) || (this.LimitByRep?.Equals(other.LimitByRep) == true)) &&
                ((this.LimitByTag == null && other.LimitByTag == null) || (this.LimitByTag?.Equals(other.LimitByTag) == true)) &&
                ((this.LimitByLabel == null && other.LimitByLabel == null) || (this.LimitByLabel?.Equals(other.LimitByLabel) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CrossAccountCredentials = {(this.CrossAccountCredentials == null ? "null" : this.CrossAccountCredentials.ToString())}");
            toStringOutput.Add($"this.AwsAuthType = {(this.AwsAuthType == null ? "null" : this.AwsAuthType.ToString())}");
            toStringOutput.Add($"this.RegistryDomain = {(this.RegistryDomain == null ? "null" : this.RegistryDomain == string.Empty ? "" : this.RegistryDomain)}");
            toStringOutput.Add($"this.LimitNumImg = {(this.LimitNumImg == null ? "null" : this.LimitNumImg.ToString())}");
            toStringOutput.Add($"this.LimitByRep = {(this.LimitByRep == null ? "null" : $"[{string.Join(", ", this.LimitByRep)} ]")}");
            toStringOutput.Add($"this.LimitByTag = {(this.LimitByTag == null ? "null" : $"[{string.Join(", ", this.LimitByTag)} ]")}");
            toStringOutput.Add($"this.LimitByLabel = {(this.LimitByLabel == null ? "null" : $"[{string.Join(", ", this.LimitByLabel)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}