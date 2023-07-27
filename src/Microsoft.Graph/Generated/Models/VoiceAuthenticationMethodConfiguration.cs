using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class VoiceAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable {
        /// <summary>A collection of groups that are enabled to use the authentication method. Expanded by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodTarget>? IncludeTargets {
            get { return BackingStore?.Get<List<AuthenticationMethodTarget>?>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#nullable restore
#else
        public List<AuthenticationMethodTarget> IncludeTargets {
            get { return BackingStore?.Get<List<AuthenticationMethodTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#endif
        /// <summary>true if users can register office phones, otherwise, false.</summary>
        public bool? IsOfficePhoneAllowed {
            get { return BackingStore?.Get<bool?>("isOfficePhoneAllowed"); }
            set { BackingStore?.Set("isOfficePhoneAllowed", value); }
        }
        /// <summary>
        /// Instantiates a new voiceAuthenticationMethodConfiguration and sets the default values.
        /// </summary>
        public VoiceAuthenticationMethodConfiguration() : base() {
            OdataType = "#microsoft.graph.voiceAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VoiceAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VoiceAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodTarget>(AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isOfficePhoneAllowed", n => { IsOfficePhoneAllowed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteBoolValue("isOfficePhoneAllowed", IsOfficePhoneAllowed);
        }
    }
}