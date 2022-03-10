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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a User along with the instance operations that can be performed on it. </summary>
    public partial class User : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="User"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier()
        {
            var resourceId = $"/providers/Microsoft.Web/publishingUsers/web";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _userClientDiagnostics;
        private readonly WebSiteManagementRestOperations _userRestClient;
        private readonly UserData _data;

        /// <summary> Initializes a new instance of the <see cref="User"/> class for mocking. </summary>
        protected User()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "User"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal User(ArmClient client, UserData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="User"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal User(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _userClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string userApiVersion);
            _userRestClient = new WebSiteManagementRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, userApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/publishingUsers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual UserData Data
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
        /// Description for Gets publishing user
        /// Request Path: /providers/Microsoft.Web/publishingUsers/web
        /// Operation Id: GetPublishingUser
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<User>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _userClientDiagnostics.CreateScope("User.Get");
            scope.Start();
            try
            {
                var response = await _userRestClient.GetPublishingUserAsync(cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new User(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets publishing user
        /// Request Path: /providers/Microsoft.Web/publishingUsers/web
        /// Operation Id: GetPublishingUser
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<User> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _userClientDiagnostics.CreateScope("User.Get");
            scope.Start();
            try
            {
                var response = _userRestClient.GetPublishingUser(cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new User(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates publishing user
        /// Request Path: /providers/Microsoft.Web/publishingUsers/web
        /// Operation Id: UpdatePublishingUser
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="userDetails"> Details of publishing user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDetails"/> is null. </exception>
        public virtual async Task<ArmOperation<User>> CreateOrUpdateAsync(bool waitForCompletion, UserData userDetails, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userDetails, nameof(userDetails));

            using var scope = _userClientDiagnostics.CreateScope("User.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _userRestClient.UpdatePublishingUserAsync(userDetails, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<User>(Response.FromValue(new User(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Description for Updates publishing user
        /// Request Path: /providers/Microsoft.Web/publishingUsers/web
        /// Operation Id: UpdatePublishingUser
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="userDetails"> Details of publishing user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDetails"/> is null. </exception>
        public virtual ArmOperation<User> CreateOrUpdate(bool waitForCompletion, UserData userDetails, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userDetails, nameof(userDetails));

            using var scope = _userClientDiagnostics.CreateScope("User.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _userRestClient.UpdatePublishingUser(userDetails, cancellationToken);
                var operation = new AppServiceArmOperation<User>(Response.FromValue(new User(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
