// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The Resource Name. </summary>
    public partial class ResourceName
    {
        /// <summary> Initializes a new instance of ResourceName. </summary>
        internal ResourceName()
        {
        }

        /// <summary> Initializes a new instance of ResourceName. </summary>
        /// <param name="value"> The name of the resource. </param>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        internal ResourceName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> The name of the resource. </summary>
        public string Value { get; }
        /// <summary> The localized name of the resource. </summary>
        public string LocalizedValue { get; }
    }
}