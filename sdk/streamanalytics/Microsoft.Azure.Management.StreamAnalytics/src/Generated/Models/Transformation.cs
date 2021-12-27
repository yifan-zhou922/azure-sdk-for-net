// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A transformation object, containing all information associated with the
    /// named transformation. All transformations are contained under a
    /// streaming job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Transformation : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the Transformation class.
        /// </summary>
        public Transformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Transformation class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="streamingUnits">Specifies the number of streaming
        /// units that the streaming job uses.</param>
        /// <param name="validStreamingUnits">Specifies the valid streaming
        /// units a streaming job can scale to.</param>
        /// <param name="query">Specifies the query that will be run in the
        /// streaming job. You can learn more about the Stream Analytics Query
        /// Language (SAQL) here:
        /// https://msdn.microsoft.com/library/azure/dn834998 . Required on PUT
        /// (CreateOrReplace) requests.</param>
        /// <param name="etag">The current entity tag for the transformation.
        /// This is an opaque string. You can use it to detect whether the
        /// resource has changed between requests. You can also use it in the
        /// If-Match or If-None-Match headers for write operations for
        /// optimistic concurrency.</param>
        public Transformation(string id = default(string), string name = default(string), string type = default(string), int? streamingUnits = default(int?), IList<int?> validStreamingUnits = default(IList<int?>), string query = default(string), string etag = default(string))
            : base(id, name, type)
        {
            StreamingUnits = streamingUnits;
            ValidStreamingUnits = validStreamingUnits;
            Query = query;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the number of streaming units that the
        /// streaming job uses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.streamingUnits")]
        public int? StreamingUnits { get; set; }

        /// <summary>
        /// Gets or sets specifies the valid streaming units a streaming job
        /// can scale to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.validStreamingUnits")]
        public IList<int?> ValidStreamingUnits { get; set; }

        /// <summary>
        /// Gets or sets specifies the query that will be run in the streaming
        /// job. You can learn more about the Stream Analytics Query Language
        /// (SAQL) here: https://msdn.microsoft.com/library/azure/dn834998 .
        /// Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets the current entity tag for the transformation. This is an
        /// opaque string. You can use it to detect whether the resource has
        /// changed between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.etag")]
        public string Etag { get; private set; }

    }
}
