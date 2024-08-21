// <auto-generated/>
using Microsoft.Graph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \servicePrincipals\{servicePrincipal-id}\homeRealmDiscoveryPolicies\{homeRealmDiscoveryPolicy-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class HomeRealmDiscoveryPolicyItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of servicePrincipal entities.</summary>
        public global::Microsoft.Graph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.Item.HomeRealmDiscoveryPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HomeRealmDiscoveryPolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/homeRealmDiscoveryPolicies/{homeRealmDiscoveryPolicy%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.Item.HomeRealmDiscoveryPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HomeRealmDiscoveryPolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/homeRealmDiscoveryPolicies/{homeRealmDiscoveryPolicy%2Did}", rawUrl)
        {
        }
    }
}
