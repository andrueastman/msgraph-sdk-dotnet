// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class PasswordProfile : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>true if the user must change their password on the next sign-in; otherwise false.</summary>
        public bool? ForceChangePasswordNextSignIn
        {
            get { return BackingStore?.Get<bool?>("forceChangePasswordNextSignIn"); }
            set { BackingStore?.Set("forceChangePasswordNextSignIn", value); }
        }
        /// <summary>If true, at next sign-in, the user must perform a multifactor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multifactor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.</summary>
        public bool? ForceChangePasswordNextSignInWithMfa
        {
            get { return BackingStore?.Get<bool?>("forceChangePasswordNextSignInWithMfa"); }
            set { BackingStore?.Set("forceChangePasswordNextSignInWithMfa", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next sign-in. The password must satisfy minimum requirements as specified by the user&apos;s passwordPolicies property. By default, a strong password is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password
        {
            get { return BackingStore?.Get<string?>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#nullable restore
#else
        public string Password
        {
            get { return BackingStore?.Get<string>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.PasswordProfile"/> and sets the default values.
        /// </summary>
        public PasswordProfile()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PasswordProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.PasswordProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.PasswordProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "forceChangePasswordNextSignIn", n => { ForceChangePasswordNextSignIn = n.GetBoolValue(); } },
                { "forceChangePasswordNextSignInWithMfa", n => { ForceChangePasswordNextSignInWithMfa = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "password", n => { Password = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("forceChangePasswordNextSignIn", ForceChangePasswordNextSignIn);
            writer.WriteBoolValue("forceChangePasswordNextSignInWithMfa", ForceChangePasswordNextSignInWithMfa);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("password", Password);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
