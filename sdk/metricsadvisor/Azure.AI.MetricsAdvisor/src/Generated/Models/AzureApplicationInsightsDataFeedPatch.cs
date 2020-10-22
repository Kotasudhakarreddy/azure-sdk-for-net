// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureApplicationInsightsDataFeedPatch. </summary>
    internal partial class AzureApplicationInsightsDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureApplicationInsightsDataFeedPatch. </summary>
        public AzureApplicationInsightsDataFeedPatch()
        {
            DataSourceType = DataFeedDetailPatchDataSourceType.AzureApplicationInsights;
        }

        public AzureApplicationInsightsParameter DataSourceParameter { get; set; }
    }
}