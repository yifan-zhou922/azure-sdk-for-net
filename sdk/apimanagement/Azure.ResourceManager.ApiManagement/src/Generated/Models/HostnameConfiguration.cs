// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Custom hostname configuration. </summary>
    public partial class HostnameConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HostnameConfiguration"/>. </summary>
        /// <param name="hostnameType"> Hostname type. </param>
        /// <param name="hostName"> Hostname to configure on the Api Management service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public HostnameConfiguration(HostnameType hostnameType, string hostName)
        {
            Argument.AssertNotNull(hostName, nameof(hostName));

            HostnameType = hostnameType;
            HostName = hostName;
        }

        /// <summary> Initializes a new instance of <see cref="HostnameConfiguration"/>. </summary>
        /// <param name="hostnameType"> Hostname type. </param>
        /// <param name="hostName"> Hostname to configure on the Api Management service. </param>
        /// <param name="keyVaultSecretUri"> Url to the KeyVault Secret containing the Ssl Certificate. If absolute Url containing version is provided, auto-update of ssl certificate will not work. This requires Api Management service to be configured with aka.ms/apimmsi. The secret should be of type *application/x-pkcs12*. </param>
        /// <param name="identityClientId"> System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate. </param>
        /// <param name="encodedCertificate"> Base64 Encoded certificate. </param>
        /// <param name="certificatePassword"> Certificate Password. </param>
        /// <param name="isDefaultSslBindingEnabled"> Specify true to setup the certificate associated with this Hostname as the Default SSL Certificate. If a client does not send the SNI header, then this will be the certificate that will be challenged. The property is useful if a service has multiple custom hostname enabled and it needs to decide on the default ssl certificate. The setting only applied to Proxy Hostname Type. </param>
        /// <param name="isClientCertificateNegotiationEnabled"> Specify true to always negotiate client certificate on the hostname. Default Value is false. </param>
        /// <param name="certificate"> Certificate information. </param>
        /// <param name="certificateSource"> Certificate Source. </param>
        /// <param name="certificateStatus"> Certificate Status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HostnameConfiguration(HostnameType hostnameType, string hostName, Uri keyVaultSecretUri, string identityClientId, string encodedCertificate, string certificatePassword, bool? isDefaultSslBindingEnabled, bool? isClientCertificateNegotiationEnabled, CertificateInformation certificate, CertificateSource? certificateSource, CertificateStatus? certificateStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HostnameType = hostnameType;
            HostName = hostName;
            KeyVaultSecretUri = keyVaultSecretUri;
            IdentityClientId = identityClientId;
            EncodedCertificate = encodedCertificate;
            CertificatePassword = certificatePassword;
            IsDefaultSslBindingEnabled = isDefaultSslBindingEnabled;
            IsClientCertificateNegotiationEnabled = isClientCertificateNegotiationEnabled;
            Certificate = certificate;
            CertificateSource = certificateSource;
            CertificateStatus = certificateStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HostnameConfiguration"/> for deserialization. </summary>
        internal HostnameConfiguration()
        {
        }

        /// <summary> Hostname type. </summary>
        public HostnameType HostnameType { get; set; }
        /// <summary> Hostname to configure on the Api Management service. </summary>
        public string HostName { get; set; }
        /// <summary> Url to the KeyVault Secret containing the Ssl Certificate. If absolute Url containing version is provided, auto-update of ssl certificate will not work. This requires Api Management service to be configured with aka.ms/apimmsi. The secret should be of type *application/x-pkcs12*. </summary>
        public Uri KeyVaultSecretUri { get; set; }
        /// <summary> System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate. </summary>
        public string IdentityClientId { get; set; }
        /// <summary> Base64 Encoded certificate. </summary>
        public string EncodedCertificate { get; set; }
        /// <summary> Certificate Password. </summary>
        public string CertificatePassword { get; set; }
        /// <summary> Specify true to setup the certificate associated with this Hostname as the Default SSL Certificate. If a client does not send the SNI header, then this will be the certificate that will be challenged. The property is useful if a service has multiple custom hostname enabled and it needs to decide on the default ssl certificate. The setting only applied to Proxy Hostname Type. </summary>
        public bool? IsDefaultSslBindingEnabled { get; set; }
        /// <summary> Specify true to always negotiate client certificate on the hostname. Default Value is false. </summary>
        public bool? IsClientCertificateNegotiationEnabled { get; set; }
        /// <summary> Certificate information. </summary>
        public CertificateInformation Certificate { get; set; }
        /// <summary> Certificate Source. </summary>
        public CertificateSource? CertificateSource { get; set; }
        /// <summary> Certificate Status. </summary>
        public CertificateStatus? CertificateStatus { get; set; }
    }
}
