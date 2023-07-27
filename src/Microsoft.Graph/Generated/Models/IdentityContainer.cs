using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class IdentityContainer : Entity, IParsable {
        /// <summary>Represents entry point for API connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityApiConnector>? ApiConnectors {
            get { return BackingStore?.Get<List<IdentityApiConnector>?>("apiConnectors"); }
            set { BackingStore?.Set("apiConnectors", value); }
        }
#nullable restore
#else
        public List<IdentityApiConnector> ApiConnectors {
            get { return BackingStore?.Get<List<IdentityApiConnector>>("apiConnectors"); }
            set { BackingStore?.Set("apiConnectors", value); }
        }
#endif
        /// <summary>Represents entry point for B2X/self-service sign-up identity userflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<B2xIdentityUserFlow>? B2xUserFlows {
            get { return BackingStore?.Get<List<B2xIdentityUserFlow>?>("b2xUserFlows"); }
            set { BackingStore?.Set("b2xUserFlows", value); }
        }
#nullable restore
#else
        public List<B2xIdentityUserFlow> B2xUserFlows {
            get { return BackingStore?.Get<List<B2xIdentityUserFlow>>("b2xUserFlows"); }
            set { BackingStore?.Set("b2xUserFlows", value); }
        }
#endif
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessRoot? ConditionalAccess {
            get { return BackingStore?.Get<ConditionalAccessRoot?>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#nullable restore
#else
        public ConditionalAccessRoot ConditionalAccess {
            get { return BackingStore?.Get<ConditionalAccessRoot>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#endif
        /// <summary>The identityProviders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>?>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#nullable restore
#else
        public List<IdentityProviderBase> IdentityProviders {
            get { return BackingStore?.Get<List<IdentityProviderBase>>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#endif
        /// <summary>Represents entry point for identity userflow attributes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityUserFlowAttribute>? UserFlowAttributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>?>("userFlowAttributes"); }
            set { BackingStore?.Set("userFlowAttributes", value); }
        }
#nullable restore
#else
        public List<IdentityUserFlowAttribute> UserFlowAttributes {
            get { return BackingStore?.Get<List<IdentityUserFlowAttribute>>("userFlowAttributes"); }
            set { BackingStore?.Set("userFlowAttributes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IdentityContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apiConnectors", n => { ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"b2xUserFlows", n => { B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccess", n => { ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                {"identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userFlowAttributes", n => { UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
        }
    }
}