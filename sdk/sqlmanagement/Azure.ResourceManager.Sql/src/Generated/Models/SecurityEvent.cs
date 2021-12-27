// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A security event. </summary>
    public partial class SecurityEvent : Resource
    {
        /// <summary> Initializes a new instance of SecurityEvent. </summary>
        public SecurityEvent()
        {
        }

        /// <summary> Initializes a new instance of SecurityEvent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="eventTime"> The time when the security event occurred. </param>
        /// <param name="securityEventType"> The type of the security event. </param>
        /// <param name="subscription"> The subscription name. </param>
        /// <param name="server"> The server name. </param>
        /// <param name="database"> The database name. </param>
        /// <param name="clientIp"> The IP address of the client who executed the statement. </param>
        /// <param name="applicationName"> The application used to execute the statement. </param>
        /// <param name="principalName"> The principal user who executed the statement. </param>
        /// <param name="securityEventSqlInjectionAdditionalProperties"> The sql injection additional properties, populated only if the type of the security event is sql injection. </param>
        internal SecurityEvent(ResourceIdentifier id, string name, ResourceType type, DateTimeOffset? eventTime, SecurityEventType? securityEventType, string subscription, string server, string database, string clientIp, string applicationName, string principalName, SecurityEventSqlInjectionAdditionalProperties securityEventSqlInjectionAdditionalProperties) : base(id, name, type)
        {
            EventTime = eventTime;
            SecurityEventType = securityEventType;
            Subscription = subscription;
            Server = server;
            Database = database;
            ClientIp = clientIp;
            ApplicationName = applicationName;
            PrincipalName = principalName;
            SecurityEventSqlInjectionAdditionalProperties = securityEventSqlInjectionAdditionalProperties;
        }

        /// <summary> The time when the security event occurred. </summary>
        public DateTimeOffset? EventTime { get; }
        /// <summary> The type of the security event. </summary>
        public SecurityEventType? SecurityEventType { get; }
        /// <summary> The subscription name. </summary>
        public string Subscription { get; }
        /// <summary> The server name. </summary>
        public string Server { get; }
        /// <summary> The database name. </summary>
        public string Database { get; }
        /// <summary> The IP address of the client who executed the statement. </summary>
        public string ClientIp { get; }
        /// <summary> The application used to execute the statement. </summary>
        public string ApplicationName { get; }
        /// <summary> The principal user who executed the statement. </summary>
        public string PrincipalName { get; }
        /// <summary> The sql injection additional properties, populated only if the type of the security event is sql injection. </summary>
        public SecurityEventSqlInjectionAdditionalProperties SecurityEventSqlInjectionAdditionalProperties { get; }
    }
}
