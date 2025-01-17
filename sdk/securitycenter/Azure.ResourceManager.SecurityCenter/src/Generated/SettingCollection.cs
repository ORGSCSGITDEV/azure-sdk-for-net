// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SettingResource" /> and their operations.
    /// Each <see cref="SettingResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SettingCollection" /> instance call the GetSettings method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SettingCollection : ArmCollection, IEnumerable<SettingResource>, IAsyncEnumerable<SettingResource>
    {
        private readonly ClientDiagnostics _settingClientDiagnostics;
        private readonly SettingsRestOperations _settingRestClient;

        /// <summary> Initializes a new instance of the <see cref="SettingCollection"/> class for mocking. </summary>
        protected SettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _settingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SettingResource.ResourceType, out string settingApiVersion);
            _settingRestClient = new SettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, settingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// updating settings about different configurations in Microsoft Defender for Cloud
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}
        /// Operation Id: Settings_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="data"> Setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SettingName settingName, SettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _settingRestClient.UpdateAsync(Id.SubscriptionId, settingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SettingResource>(Response.FromValue(new SettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// updating settings about different configurations in Microsoft Defender for Cloud
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}
        /// Operation Id: Settings_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="data"> Setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SettingResource> CreateOrUpdate(WaitUntil waitUntil, SettingName settingName, SettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _settingRestClient.Update(Id.SubscriptionId, settingName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SettingResource>(Response.FromValue(new SettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings of different configurations in Microsoft Defender for Cloud
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}
        /// Operation Id: Settings_Get
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SettingResource>> GetAsync(SettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _settingRestClient.GetAsync(Id.SubscriptionId, settingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings of different configurations in Microsoft Defender for Cloud
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}
        /// Operation Id: Settings_Get
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SettingResource> Get(SettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.Get");
            scope.Start();
            try
            {
                var response = _settingRestClient.Get(Id.SubscriptionId, settingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings about different configurations in Microsoft Defender for Cloud
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings
        /// Operation Id: Settings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SettingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _settingRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SettingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _settingRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Settings about different configurations in Microsoft Defender for Cloud
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings
        /// Operation Id: Settings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SettingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _settingRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SettingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _settingRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}
        /// Operation Id: Settings_Get
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _settingRestClient.GetAsync(Id.SubscriptionId, settingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}
        /// Operation Id: Settings_Get
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _settingClientDiagnostics.CreateScope("SettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _settingRestClient.Get(Id.SubscriptionId, settingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SettingResource> IEnumerable<SettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SettingResource> IAsyncEnumerable<SettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
