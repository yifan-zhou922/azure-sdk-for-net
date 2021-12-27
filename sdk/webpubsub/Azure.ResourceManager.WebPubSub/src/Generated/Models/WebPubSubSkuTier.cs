// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary>
    /// Optional tier of this particular SKU. &apos;Standard&apos; or &apos;Free&apos;. 
    /// 
    /// `Basic` is deprecated, use `Standard` instead.
    /// </summary>
    public readonly partial struct WebPubSubSkuTier : IEquatable<WebPubSubSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebPubSubSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebPubSubSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Free. </summary>
        public static WebPubSubSkuTier Free { get; } = new WebPubSubSkuTier(FreeValue);
        /// <summary> Basic. </summary>
        public static WebPubSubSkuTier Basic { get; } = new WebPubSubSkuTier(BasicValue);
        /// <summary> Standard. </summary>
        public static WebPubSubSkuTier Standard { get; } = new WebPubSubSkuTier(StandardValue);
        /// <summary> Premium. </summary>
        public static WebPubSubSkuTier Premium { get; } = new WebPubSubSkuTier(PremiumValue);
        /// <summary> Determines if two <see cref="WebPubSubSkuTier"/> values are the same. </summary>
        public static bool operator ==(WebPubSubSkuTier left, WebPubSubSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebPubSubSkuTier"/> values are not the same. </summary>
        public static bool operator !=(WebPubSubSkuTier left, WebPubSubSkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebPubSubSkuTier"/>. </summary>
        public static implicit operator WebPubSubSkuTier(string value) => new WebPubSubSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebPubSubSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebPubSubSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
