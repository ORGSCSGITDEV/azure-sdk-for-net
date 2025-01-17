// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache encryption settings. </summary>
    public partial class CacheEncryptionSettings
    {
        /// <summary> Initializes a new instance of CacheEncryptionSettings. </summary>
        public CacheEncryptionSettings()
        {
        }

        /// <summary> Initializes a new instance of CacheEncryptionSettings. </summary>
        /// <param name="keyEncryptionKey"> Specifies the location of the key encryption key in Key Vault. </param>
        /// <param name="rotationToLatestKeyVersionEnabled"> Specifies whether the service will automatically rotate to the newest version of the key in the Key Vault. </param>
        internal CacheEncryptionSettings(KeyVaultKeyReference keyEncryptionKey, bool? rotationToLatestKeyVersionEnabled)
        {
            KeyEncryptionKey = keyEncryptionKey;
            RotationToLatestKeyVersionEnabled = rotationToLatestKeyVersionEnabled;
        }

        /// <summary> Specifies the location of the key encryption key in Key Vault. </summary>
        public KeyVaultKeyReference KeyEncryptionKey { get; set; }
        /// <summary> Specifies whether the service will automatically rotate to the newest version of the key in the Key Vault. </summary>
        public bool? RotationToLatestKeyVersionEnabled { get; set; }
    }
}
