// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class AppConsentRequest : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the app for which consent is requested. Required. Supports $filter (eq only) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName
        {
            get { return BackingStore?.Get<string?>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#nullable restore
#else
        public string AppDisplayName
        {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#endif
        /// <summary>The identifier of the application. Required. Supports $filter (eq only) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>A list of pending scopes waiting for approval. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AppConsentRequestScope>? PendingScopes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AppConsentRequestScope>?>("pendingScopes"); }
            set { BackingStore?.Set("pendingScopes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AppConsentRequestScope> PendingScopes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AppConsentRequestScope>>("pendingScopes"); }
            set { BackingStore?.Set("pendingScopes", value); }
        }
#endif
        /// <summary>A list of pending user consent requests. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.UserConsentRequest>? UserConsentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserConsentRequest>?>("userConsentRequests"); }
            set { BackingStore?.Set("userConsentRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.UserConsentRequest> UserConsentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserConsentRequest>>("userConsentRequests"); }
            set { BackingStore?.Set("userConsentRequests", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AppConsentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AppConsentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AppConsentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "pendingScopes", n => { PendingScopes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AppConsentRequestScope>(global::Microsoft.Graph.Models.AppConsentRequestScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userConsentRequests", n => { UserConsentRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.UserConsentRequest>(global::Microsoft.Graph.Models.UserConsentRequest.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AppConsentRequestScope>("pendingScopes", PendingScopes);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.UserConsentRequest>("userConsentRequests", UserConsentRequests);
        }
    }
}
