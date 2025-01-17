// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> The response from the List Cache SKUs operation. </summary>
    internal partial class ResourceSkusResult
    {
        /// <summary> Initializes a new instance of ResourceSkusResult. </summary>
        internal ResourceSkusResult()
        {
            Value = new ChangeTrackingList<ResourceSku>();
        }

        /// <summary> Initializes a new instance of ResourceSkusResult. </summary>
        /// <param name="nextLink"> The URI to fetch the next page of Cache SKUs. </param>
        /// <param name="value"> The list of SKUs available for the subscription. </param>
        internal ResourceSkusResult(string nextLink, IReadOnlyList<ResourceSku> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The URI to fetch the next page of Cache SKUs. </summary>
        public string NextLink { get; }
        /// <summary> The list of SKUs available for the subscription. </summary>
        public IReadOnlyList<ResourceSku> Value { get; }
    }
}
