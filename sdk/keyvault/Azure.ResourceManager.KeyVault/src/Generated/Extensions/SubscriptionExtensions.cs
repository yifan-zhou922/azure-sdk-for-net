// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeletedVaults in the DeletedVault. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedVaults and their operations over a DeletedVault. </returns>
        public static DeletedVaultCollection GetDeletedVaults(this Subscription subscription)
        {
            return GetExtensionClient(subscription).GetDeletedVaults();
        }

        /// <summary> Gets a collection of DeletedManagedHsms in the DeletedManagedHsm. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedManagedHsms and their operations over a DeletedManagedHsm. </returns>
        public static DeletedManagedHsmCollection GetDeletedManagedHsms(this Subscription subscription)
        {
            return GetExtensionClient(subscription).GetDeletedManagedHsms();
        }

        /// <summary>
        /// The List operation gets information about the vaults associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// Operation Id: Vaults_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Vault" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Vault> GetVaultsAsync(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetVaultsAsync(top, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the vaults associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// Operation Id: Vaults_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Vault" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<Vault> GetVaults(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetVaults(top, cancellationToken);
        }

        /// <summary>
        /// Gets information about the deleted vaults in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// Operation Id: Vaults_ListDeleted
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedVault" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedVault> GetDeletedVaultsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedVaultsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets information about the deleted vaults in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// Operation Id: Vaults_ListDeleted
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedVault" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedVault> GetDeletedVaults(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedVaults(cancellationToken);
        }

        /// <summary>
        /// Checks that the vault name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// Operation Id: Vaults_CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResult>> CheckKeyVaultNameAvailabilityAsync(this Subscription subscription, VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(vaultName, nameof(vaultName));

            return await GetExtensionClient(subscription).CheckKeyVaultNameAvailabilityAsync(vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the vault name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// Operation Id: Vaults_CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public static Response<CheckNameAvailabilityResult> CheckKeyVaultNameAvailability(this Subscription subscription, VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(vaultName, nameof(vaultName));

            return GetExtensionClient(subscription).CheckKeyVaultNameAvailability(vaultName, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the managed HSM Pools associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// Operation Id: ManagedHsms_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedHsm> GetManagedHsmsAsync(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedHsmsAsync(top, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the managed HSM Pools associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// Operation Id: ManagedHsms_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedHsm> GetManagedHsms(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedHsms(top, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the deleted managed HSMs associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// Operation Id: ManagedHsms_ListDeleted
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedManagedHsm> GetDeletedManagedHsmsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedManagedHsmsAsync(cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the deleted managed HSMs associated with the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// Operation Id: ManagedHsms_ListDeleted
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedManagedHsm" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedManagedHsm> GetDeletedManagedHsms(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedManagedHsms(cancellationToken);
        }
    }
}
