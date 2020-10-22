// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> Instances of AvailabilityData represent the result of executing an availability test. </summary>
    public partial class AvailabilityData : MonitorDomain
    {
        /// <summary> Initializes a new instance of AvailabilityData. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="id"> Identifier of a test run. Use it to correlate steps of test run and telemetry generated by the service. </param>
        /// <param name="name"> Name of the test that these availability results represent. </param>
        /// <param name="duration"> Duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Success flag. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="name"/>, or <paramref name="duration"/> is null. </exception>
        public AvailabilityData(int version, string id, string name, string duration, bool success) : base(version)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (duration == null)
            {
                throw new ArgumentNullException(nameof(duration));
            }

            Id = id;
            Name = name;
            Duration = duration;
            Success = success;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Identifier of a test run. Use it to correlate steps of test run and telemetry generated by the service. </summary>
        public string Id { get; }
        /// <summary> Name of the test that these availability results represent. </summary>
        public string Name { get; }
        /// <summary> Duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </summary>
        public string Duration { get; }
        /// <summary> Success flag. </summary>
        public bool Success { get; }
        /// <summary> Name of the location where the test was run from. </summary>
        public string RunLocation { get; set; }
        /// <summary> Diagnostic message for the result. </summary>
        public string Message { get; set; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}