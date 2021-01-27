// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Queues.Models
{
    /// <summary> the retention policy. </summary>
    public partial class QueueRetentionPolicy
    {

        /// <summary> Initializes a new instance of QueueRetentionPolicy. </summary>
        /// <param name="enabled"> Indicates whether a retention policy is enabled for the storage service. </param>
        /// <param name="days"> Indicates the number of days that metrics or logging or soft-deleted data should be retained. All data older than this value will be deleted. </param>
        internal QueueRetentionPolicy(bool enabled, int? days)
        {
            Enabled = enabled;
            Days = days;
        }

        /// <summary> Indicates whether a retention policy is enabled for the storage service. </summary>
        public bool Enabled { get; set; }
        /// <summary> Indicates the number of days that metrics or logging or soft-deleted data should be retained. All data older than this value will be deleted. </summary>
        public int? Days { get; set; }
    }
}