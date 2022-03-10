// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a SqlTimeZone along with the instance operations that can be performed on it. </summary>
    public partial class SqlTimeZone : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlTimeZone"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string timeZoneId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlTimeZoneTimeZonesClientDiagnostics;
        private readonly TimeZonesRestOperations _sqlTimeZoneTimeZonesRestClient;
        private readonly SqlTimeZoneData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZone"/> class for mocking. </summary>
        protected SqlTimeZone()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlTimeZone"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlTimeZone(ArmClient client, SqlTimeZoneData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZone"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlTimeZone(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlTimeZoneTimeZonesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string sqlTimeZoneTimeZonesApiVersion);
            _sqlTimeZoneTimeZonesRestClient = new TimeZonesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sqlTimeZoneTimeZonesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/timeZones";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlTimeZoneData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a managed instance time zone.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// Operation Id: TimeZones_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlTimeZone>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZone.Get");
            scope.Start();
            try
            {
                var response = await _sqlTimeZoneTimeZonesRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZone(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed instance time zone.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// Operation Id: TimeZones_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlTimeZone> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZone.Get");
            scope.Start();
            try
            {
                var response = _sqlTimeZoneTimeZonesRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZone(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
