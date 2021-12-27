// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the UrlPath condition for the delivery rule. </summary>
    public partial class DeliveryRuleUrlPathCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleUrlPathCondition. </summary>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleUrlPathCondition(UrlPathMatchConditionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = MatchVariable.UrlPath;
        }

        /// <summary> Initializes a new instance of DeliveryRuleUrlPathCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        internal DeliveryRuleUrlPathCondition(MatchVariable name, UrlPathMatchConditionParameters parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public UrlPathMatchConditionParameters Parameters { get; set; }
    }
}
