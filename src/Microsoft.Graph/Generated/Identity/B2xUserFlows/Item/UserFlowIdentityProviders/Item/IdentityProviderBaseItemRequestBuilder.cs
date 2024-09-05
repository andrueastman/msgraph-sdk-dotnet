// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \identity\b2xUserFlows\{b2xIdentityUserFlow-id}\userFlowIdentityProviders\{identityProviderBase-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class IdentityProviderBaseItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of identityContainer entities.</summary>
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.Item.IdentityProviderBaseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderBaseItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}/userFlowIdentityProviders/{identityProviderBase%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.Item.IdentityProviderBaseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderBaseItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}/userFlowIdentityProviders/{identityProviderBase%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
