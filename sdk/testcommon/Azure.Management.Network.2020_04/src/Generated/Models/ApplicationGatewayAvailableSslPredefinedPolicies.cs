// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for ApplicationGatewayAvailableSslOptions API service call. </summary>
    public partial class ApplicationGatewayAvailableSslPredefinedPolicies
    {
        /// <summary> Initializes a new instance of ApplicationGatewayAvailableSslPredefinedPolicies. </summary>
        internal ApplicationGatewayAvailableSslPredefinedPolicies()
        {
            Value = new ChangeTrackingList<ApplicationGatewaySslPredefinedPolicy>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayAvailableSslPredefinedPolicies. </summary>
        /// <param name="value"> List of available Ssl predefined policy. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal ApplicationGatewayAvailableSslPredefinedPolicies(IReadOnlyList<ApplicationGatewaySslPredefinedPolicy> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of available Ssl predefined policy. </summary>
        public IReadOnlyList<ApplicationGatewaySslPredefinedPolicy> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}