// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The license type. Possible values are &apos;LicenseIncluded&apos; (regular price inclusive of a new SQL license) and &apos;BasePrice&apos; (discounted AHB price for bringing your own SQL licenses). </summary>
    public readonly partial struct ManagedInstanceLicenseType : IEquatable<ManagedInstanceLicenseType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ManagedInstanceLicenseType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedInstanceLicenseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LicenseIncludedValue = "LicenseIncluded";
        private const string BasePriceValue = "BasePrice";

        /// <summary> LicenseIncluded. </summary>
        public static ManagedInstanceLicenseType LicenseIncluded { get; } = new ManagedInstanceLicenseType(LicenseIncludedValue);
        /// <summary> BasePrice. </summary>
        public static ManagedInstanceLicenseType BasePrice { get; } = new ManagedInstanceLicenseType(BasePriceValue);
        /// <summary> Determines if two <see cref="ManagedInstanceLicenseType"/> values are the same. </summary>
        public static bool operator ==(ManagedInstanceLicenseType left, ManagedInstanceLicenseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedInstanceLicenseType"/> values are not the same. </summary>
        public static bool operator !=(ManagedInstanceLicenseType left, ManagedInstanceLicenseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedInstanceLicenseType"/>. </summary>
        public static implicit operator ManagedInstanceLicenseType(string value) => new ManagedInstanceLicenseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedInstanceLicenseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedInstanceLicenseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}