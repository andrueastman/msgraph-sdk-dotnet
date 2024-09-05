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
    public partial class Call : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The audioRoutingGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AudioRoutingGroup>? AudioRoutingGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AudioRoutingGroup>?>("audioRoutingGroups"); }
            set { BackingStore?.Set("audioRoutingGroups", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AudioRoutingGroup> AudioRoutingGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AudioRoutingGroup>>("audioRoutingGroups"); }
            set { BackingStore?.Set("audioRoutingGroups", value); }
        }
#endif
        /// <summary>The callback URL on which callbacks are delivered. Must be an HTTPS URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallbackUri
        {
            get { return BackingStore?.Get<string?>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
#nullable restore
#else
        public string CallbackUri
        {
            get { return BackingStore?.Get<string>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
#endif
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This identifier must be copied over from Microsoft.Graph.Call.CallChainId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallChainId
        {
            get { return BackingStore?.Get<string?>("callChainId"); }
            set { BackingStore?.Set("callChainId", value); }
        }
#nullable restore
#else
        public string CallChainId
        {
            get { return BackingStore?.Get<string>("callChainId"); }
            set { BackingStore?.Set("callChainId", value); }
        }
#endif
        /// <summary>Contains the optional features for the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CallOptions? CallOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallOptions?>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CallOptions CallOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallOptions>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
#endif
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CallRoute>? CallRoutes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CallRoute>?>("callRoutes"); }
            set { BackingStore?.Set("callRoutes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CallRoute> CallRoutes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CallRoute>>("callRoutes"); }
            set { BackingStore?.Set("callRoutes", value); }
        }
#endif
        /// <summary>The chat information. Required information for joining a meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ChatInfo? ChatInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatInfo?>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ChatInfo ChatInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatInfo>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#endif
        /// <summary>The contentSharingSessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ContentSharingSession>? ContentSharingSessions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ContentSharingSession>?>("contentSharingSessions"); }
            set { BackingStore?.Set("contentSharingSessions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ContentSharingSession> ContentSharingSessions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ContentSharingSession>>("contentSharingSessions"); }
            set { BackingStore?.Set("contentSharingSessions", value); }
        }
#endif
        /// <summary>The direction of the call. The possible values are incoming or outgoing. Read-only.</summary>
        public global::Microsoft.Graph.Models.CallDirection? Direction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallDirection?>("direction"); }
            set { BackingStore?.Set("direction", value); }
        }
        /// <summary>Call context associated with an incoming call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IncomingContext? IncomingContext
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IncomingContext?>("incomingContext"); }
            set { BackingStore?.Set("incomingContext", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IncomingContext IncomingContext
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IncomingContext>("incomingContext"); }
            set { BackingStore?.Set("incomingContext", value); }
        }
#endif
        /// <summary>The media configuration. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.MediaConfig? MediaConfig
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MediaConfig?>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.MediaConfig MediaConfig
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MediaConfig>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
#endif
        /// <summary>Read-only. The call media state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CallMediaState? MediaState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallMediaState?>("mediaState"); }
            set { BackingStore?.Set("mediaState", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CallMediaState MediaState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallMediaState>("mediaState"); }
            set { BackingStore?.Set("mediaState", value); }
        }
#endif
        /// <summary>The meeting information. Required information for meeting scenarios.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.MeetingInfo? MeetingInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MeetingInfo?>("meetingInfo"); }
            set { BackingStore?.Set("meetingInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.MeetingInfo MeetingInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MeetingInfo>("meetingInfo"); }
            set { BackingStore?.Set("meetingInfo", value); }
        }
#endif
        /// <summary>The myParticipantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MyParticipantId
        {
            get { return BackingStore?.Get<string?>("myParticipantId"); }
            set { BackingStore?.Set("myParticipantId", value); }
        }
#nullable restore
#else
        public string MyParticipantId
        {
            get { return BackingStore?.Get<string>("myParticipantId"); }
            set { BackingStore?.Set("myParticipantId", value); }
        }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CommsOperation>? Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CommsOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CommsOperation> Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CommsOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The participants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Participant>? Participants
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Participant>?>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Participant> Participants
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Participant>>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#endif
        /// <summary>The list of requested modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Modality?>? RequestedModalities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Modality?>?>("requestedModalities"); }
            set { BackingStore?.Set("requestedModalities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Modality?> RequestedModalities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Modality?>>("requestedModalities"); }
            set { BackingStore?.Set("requestedModalities", value); }
        }
#endif
        /// <summary>The result information. For example, the result can hold termination reason. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ResultInfo? ResultInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResultInfo?>("resultInfo"); }
            set { BackingStore?.Set("resultInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ResultInfo ResultInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResultInfo>("resultInfo"); }
            set { BackingStore?.Set("resultInfo", value); }
        }
#endif
        /// <summary>The originator of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ParticipantInfo? Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ParticipantInfo?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ParticipantInfo Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ParticipantInfo>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>The call state. Possible values are: incoming, establishing, ringing, established, hold, transferring, transferAccepted, redirecting, terminating, terminated. Read-only.</summary>
        public global::Microsoft.Graph.Models.CallState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The subject of the conversation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject
        {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject
        {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The targets of the call. Required information for creating peer to peer call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.InvitationParticipantInfo>? Targets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.InvitationParticipantInfo>?>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.InvitationParticipantInfo> Targets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.InvitationParticipantInfo>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The toneInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ToneInfo? ToneInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ToneInfo?>("toneInfo"); }
            set { BackingStore?.Set("toneInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ToneInfo ToneInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ToneInfo>("toneInfo"); }
            set { BackingStore?.Set("toneInfo", value); }
        }
#endif
        /// <summary>The transcription information for the call. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CallTranscriptionInfo? Transcription
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallTranscriptionInfo?>("transcription"); }
            set { BackingStore?.Set("transcription", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CallTranscriptionInfo Transcription
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CallTranscriptionInfo>("transcription"); }
            set { BackingStore?.Set("transcription", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Call"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Call CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Call();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audioRoutingGroups", n => { AudioRoutingGroups = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AudioRoutingGroup>(global::Microsoft.Graph.Models.AudioRoutingGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "callChainId", n => { CallChainId = n.GetStringValue(); } },
                { "callOptions", n => { CallOptions = n.GetObjectValue<global::Microsoft.Graph.Models.CallOptions>(global::Microsoft.Graph.Models.CallOptions.CreateFromDiscriminatorValue); } },
                { "callRoutes", n => { CallRoutes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CallRoute>(global::Microsoft.Graph.Models.CallRoute.CreateFromDiscriminatorValue)?.AsList(); } },
                { "callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                { "chatInfo", n => { ChatInfo = n.GetObjectValue<global::Microsoft.Graph.Models.ChatInfo>(global::Microsoft.Graph.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                { "contentSharingSessions", n => { ContentSharingSessions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ContentSharingSession>(global::Microsoft.Graph.Models.ContentSharingSession.CreateFromDiscriminatorValue)?.AsList(); } },
                { "direction", n => { Direction = n.GetEnumValue<global::Microsoft.Graph.Models.CallDirection>(); } },
                { "incomingContext", n => { IncomingContext = n.GetObjectValue<global::Microsoft.Graph.Models.IncomingContext>(global::Microsoft.Graph.Models.IncomingContext.CreateFromDiscriminatorValue); } },
                { "mediaConfig", n => { MediaConfig = n.GetObjectValue<global::Microsoft.Graph.Models.MediaConfig>(global::Microsoft.Graph.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                { "mediaState", n => { MediaState = n.GetObjectValue<global::Microsoft.Graph.Models.CallMediaState>(global::Microsoft.Graph.Models.CallMediaState.CreateFromDiscriminatorValue); } },
                { "meetingInfo", n => { MeetingInfo = n.GetObjectValue<global::Microsoft.Graph.Models.MeetingInfo>(global::Microsoft.Graph.Models.MeetingInfo.CreateFromDiscriminatorValue); } },
                { "myParticipantId", n => { MyParticipantId = n.GetStringValue(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CommsOperation>(global::Microsoft.Graph.Models.CommsOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "participants", n => { Participants = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Participant>(global::Microsoft.Graph.Models.Participant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requestedModalities", n => { RequestedModalities = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.Modality>()?.AsList(); } },
                { "resultInfo", n => { ResultInfo = n.GetObjectValue<global::Microsoft.Graph.Models.ResultInfo>(global::Microsoft.Graph.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                { "source", n => { Source = n.GetObjectValue<global::Microsoft.Graph.Models.ParticipantInfo>(global::Microsoft.Graph.Models.ParticipantInfo.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.CallState>(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "targets", n => { Targets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.InvitationParticipantInfo>(global::Microsoft.Graph.Models.InvitationParticipantInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "toneInfo", n => { ToneInfo = n.GetObjectValue<global::Microsoft.Graph.Models.ToneInfo>(global::Microsoft.Graph.Models.ToneInfo.CreateFromDiscriminatorValue); } },
                { "transcription", n => { Transcription = n.GetObjectValue<global::Microsoft.Graph.Models.CallTranscriptionInfo>(global::Microsoft.Graph.Models.CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AudioRoutingGroup>("audioRoutingGroups", AudioRoutingGroups);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ContentSharingSession>("contentSharingSessions", ContentSharingSessions);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CallDirection>("direction", Direction);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Participant>("participants", Participants);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.Modality>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ParticipantInfo>("source", Source);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
#pragma warning restore CS0618
