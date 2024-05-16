// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class Teamwork : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of deleted chats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeletedChat>? DeletedChats
        {
            get { return BackingStore?.Get<List<DeletedChat>?>("deletedChats"); }
            set { BackingStore?.Set("deletedChats", value); }
        }
#nullable restore
#else
        public List<DeletedChat> DeletedChats
        {
            get { return BackingStore?.Get<List<DeletedChat>>("deletedChats"); }
            set { BackingStore?.Set("deletedChats", value); }
        }
#endif
        /// <summary>The deleted team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeletedTeam>? DeletedTeams
        {
            get { return BackingStore?.Get<List<DeletedTeam>?>("deletedTeams"); }
            set { BackingStore?.Set("deletedTeams", value); }
        }
#nullable restore
#else
        public List<DeletedTeam> DeletedTeams
        {
            get { return BackingStore?.Get<List<DeletedTeam>>("deletedTeams"); }
            set { BackingStore?.Set("deletedTeams", value); }
        }
#endif
        /// <summary>Indicates whether Microsoft Teams is enabled for the organization.</summary>
        public bool? IsTeamsEnabled
        {
            get { return BackingStore?.Get<bool?>("isTeamsEnabled"); }
            set { BackingStore?.Set("isTeamsEnabled", value); }
        }
        /// <summary>Represents the region of the organization. &gt; The region property contains the organization&apos;s or the user&apos;s region. The property contains the user&apos;s region (if available) for users who have a valid multigeo license. For users without multigeo licenses, the region property contains the organization&apos;s region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region
        {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region
        {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>Represents tenant-wide settings for all Teams apps in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.TeamsAppSettings? TeamsAppSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TeamsAppSettings?>("teamsAppSettings"); }
            set { BackingStore?.Set("teamsAppSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.TeamsAppSettings TeamsAppSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TeamsAppSettings>("teamsAppSettings"); }
            set { BackingStore?.Set("teamsAppSettings", value); }
        }
#endif
        /// <summary>The workforceIntegrations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkforceIntegration>? WorkforceIntegrations
        {
            get { return BackingStore?.Get<List<WorkforceIntegration>?>("workforceIntegrations"); }
            set { BackingStore?.Set("workforceIntegrations", value); }
        }
#nullable restore
#else
        public List<WorkforceIntegration> WorkforceIntegrations
        {
            get { return BackingStore?.Get<List<WorkforceIntegration>>("workforceIntegrations"); }
            set { BackingStore?.Set("workforceIntegrations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Teamwork"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Teamwork CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Teamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deletedChats", n => { DeletedChats = n.GetCollectionOfObjectValues<DeletedChat>(DeletedChat.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deletedTeams", n => { DeletedTeams = n.GetCollectionOfObjectValues<DeletedTeam>(DeletedTeam.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isTeamsEnabled", n => { IsTeamsEnabled = n.GetBoolValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "teamsAppSettings", n => { TeamsAppSettings = n.GetObjectValue<Microsoft.Graph.Models.TeamsAppSettings>(Microsoft.Graph.Models.TeamsAppSettings.CreateFromDiscriminatorValue); } },
                { "workforceIntegrations", n => { WorkforceIntegrations = n.GetCollectionOfObjectValues<WorkforceIntegration>(WorkforceIntegration.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<DeletedChat>("deletedChats", DeletedChats);
            writer.WriteCollectionOfObjectValues<DeletedTeam>("deletedTeams", DeletedTeams);
            writer.WriteBoolValue("isTeamsEnabled", IsTeamsEnabled);
            writer.WriteStringValue("region", Region);
            writer.WriteObjectValue<Microsoft.Graph.Models.TeamsAppSettings>("teamsAppSettings", TeamsAppSettings);
            writer.WriteCollectionOfObjectValues<WorkforceIntegration>("workforceIntegrations", WorkforceIntegrations);
        }
    }
}
