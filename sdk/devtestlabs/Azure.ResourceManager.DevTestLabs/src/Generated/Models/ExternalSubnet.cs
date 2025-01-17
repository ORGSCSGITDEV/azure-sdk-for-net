// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Subnet information as returned by the Microsoft.Network API. </summary>
    public partial class ExternalSubnet
    {
        /// <summary> Initializes a new instance of ExternalSubnet. </summary>
        internal ExternalSubnet()
        {
        }

        /// <summary> Initializes a new instance of ExternalSubnet. </summary>
        /// <param name="id"> Gets or sets the identifier. </param>
        /// <param name="name"> Gets or sets the name. </param>
        internal ExternalSubnet(string id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary> Gets or sets the identifier. </summary>
        public string Id { get; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; }
    }
}
