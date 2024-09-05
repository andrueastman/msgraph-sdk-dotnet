// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class CommunicationsIdentitySet : global::Microsoft.Graph.Models.IdentitySet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The application instance associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? ApplicationInstance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("applicationInstance"); }
            set { BackingStore?.Set("applicationInstance", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity ApplicationInstance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("applicationInstance"); }
            set { BackingStore?.Set("applicationInstance", value); }
        }
#endif
        /// <summary>An identity the participant would like to present itself as to the other participants in the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? AssertedIdentity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("assertedIdentity"); }
            set { BackingStore?.Set("assertedIdentity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity AssertedIdentity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("assertedIdentity"); }
            set { BackingStore?.Set("assertedIdentity", value); }
        }
#endif
        /// <summary>The Azure Communication Services user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? AzureCommunicationServicesUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("azureCommunicationServicesUser"); }
            set { BackingStore?.Set("azureCommunicationServicesUser", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity AzureCommunicationServicesUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("azureCommunicationServicesUser"); }
            set { BackingStore?.Set("azureCommunicationServicesUser", value); }
        }
#endif
        /// <summary>The encrypted user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? Encrypted
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("encrypted"); }
            set { BackingStore?.Set("encrypted", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity Encrypted
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("encrypted"); }
            set { BackingStore?.Set("encrypted", value); }
        }
#endif
        /// <summary>Type of endpoint that the participant uses. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.EndpointType? EndpointType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EndpointType?>("endpointType"); }
            set { BackingStore?.Set("endpointType", value); }
        }
        /// <summary>The guest user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? Guest
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("guest"); }
            set { BackingStore?.Set("guest", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity Guest
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("guest"); }
            set { BackingStore?.Set("guest", value); }
        }
#endif
        /// <summary>The Skype for Business on-premises user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? OnPremises
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("onPremises"); }
            set { BackingStore?.Set("onPremises", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity OnPremises
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("onPremises"); }
            set { BackingStore?.Set("onPremises", value); }
        }
#endif
        /// <summary>The phone user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? Phone
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity Phone
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.CommunicationsIdentitySet"/> and sets the default values.
        /// </summary>
        public CommunicationsIdentitySet() : base()
        {
            OdataType = "#microsoft.graph.communicationsIdentitySet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CommunicationsIdentitySet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CommunicationsIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CommunicationsIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicationInstance", n => { ApplicationInstance = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                { "assertedIdentity", n => { AssertedIdentity = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                { "azureCommunicationServicesUser", n => { AzureCommunicationServicesUser = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                { "encrypted", n => { Encrypted = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                { "endpointType", n => { EndpointType = n.GetEnumValue<global::Microsoft.Graph.Models.EndpointType>(); } },
                { "guest", n => { Guest = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                { "onPremises", n => { OnPremises = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
                { "phone", n => { Phone = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("applicationInstance", ApplicationInstance);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("assertedIdentity", AssertedIdentity);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("azureCommunicationServicesUser", AzureCommunicationServicesUser);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("encrypted", Encrypted);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("guest", Guest);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("onPremises", OnPremises);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("phone", Phone);
        }
    }
}
#pragma warning restore CS0618
