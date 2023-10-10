// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public class MediaStream : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Codec name used to encode audio for transmission on the network. Possible values are: unknown, invalid, cn, pcma, pcmu, amrWide, g722, g7221, g7221c, g729, multiChannelAudio, muchv2, opus, satin, satinFullband, rtAudio8, rtAudio16, silk, silkNarrow, silkWide, siren, xmsRta, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.CallRecords.AudioCodec? AudioCodec {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallRecords.AudioCodec?>("audioCodec"); }
            set { BackingStore?.Set("audioCodec", value); }
        }
        /// <summary>Average Network Mean Opinion Score degradation for stream. Represents how much the network loss and jitter has impacted the quality of received audio.</summary>
        public float? AverageAudioDegradation {
            get { return BackingStore?.Get<float?>("averageAudioDegradation"); }
            set { BackingStore?.Set("averageAudioDegradation", value); }
        }
        /// <summary>Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as &apos;PT1S&apos;, where &apos;P&apos; is the duration designator, &apos;T&apos; is the time designator, and &apos;S&apos; is the second designator.</summary>
        public TimeSpan? AverageAudioNetworkJitter {
            get { return BackingStore?.Get<TimeSpan?>("averageAudioNetworkJitter"); }
            set { BackingStore?.Set("averageAudioNetworkJitter", value); }
        }
        /// <summary>Average estimated bandwidth available between two endpoints in bits per second.</summary>
        public long? AverageBandwidthEstimate {
            get { return BackingStore?.Get<long?>("averageBandwidthEstimate"); }
            set { BackingStore?.Set("averageBandwidthEstimate", value); }
        }
        /// <summary>Average duration of the received freezing time in the video stream.</summary>
        public TimeSpan? AverageFreezeDuration {
            get { return BackingStore?.Get<TimeSpan?>("averageFreezeDuration"); }
            set { BackingStore?.Set("averageFreezeDuration", value); }
        }
        /// <summary>Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as &apos;PT1S&apos;, where &apos;P&apos; is the duration designator, &apos;T&apos; is the time designator, and &apos;S&apos; is the second designator.</summary>
        public TimeSpan? AverageJitter {
            get { return BackingStore?.Get<TimeSpan?>("averageJitter"); }
            set { BackingStore?.Set("averageJitter", value); }
        }
        /// <summary>Average packet loss rate for stream.</summary>
        public float? AveragePacketLossRate {
            get { return BackingStore?.Get<float?>("averagePacketLossRate"); }
            set { BackingStore?.Set("averagePacketLossRate", value); }
        }
        /// <summary>Ratio of the number of audio frames with samples generated by packet loss concealment to the total number of audio frames.</summary>
        public float? AverageRatioOfConcealedSamples {
            get { return BackingStore?.Get<float?>("averageRatioOfConcealedSamples"); }
            set { BackingStore?.Set("averageRatioOfConcealedSamples", value); }
        }
        /// <summary>Average frames per second received for all video streams computed over the duration of the session.</summary>
        public float? AverageReceivedFrameRate {
            get { return BackingStore?.Get<float?>("averageReceivedFrameRate"); }
            set { BackingStore?.Set("averageReceivedFrameRate", value); }
        }
        /// <summary>Average network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as &apos;PT1S&apos;, where &apos;P&apos; is the duration designator, &apos;T&apos; is the time designator, and &apos;S&apos; is the second designator.</summary>
        public TimeSpan? AverageRoundTripTime {
            get { return BackingStore?.Get<TimeSpan?>("averageRoundTripTime"); }
            set { BackingStore?.Set("averageRoundTripTime", value); }
        }
        /// <summary>Average percentage of video frames lost as displayed to the user.</summary>
        public float? AverageVideoFrameLossPercentage {
            get { return BackingStore?.Get<float?>("averageVideoFrameLossPercentage"); }
            set { BackingStore?.Set("averageVideoFrameLossPercentage", value); }
        }
        /// <summary>Average frames per second received for a video stream, computed over the duration of the session.</summary>
        public float? AverageVideoFrameRate {
            get { return BackingStore?.Get<float?>("averageVideoFrameRate"); }
            set { BackingStore?.Set("averageVideoFrameRate", value); }
        }
        /// <summary>Average fraction of packets lost, as specified in [RFC 3550][], computed over the duration of the session.</summary>
        public float? AverageVideoPacketLossRate {
            get { return BackingStore?.Get<float?>("averageVideoPacketLossRate"); }
            set { BackingStore?.Set("averageVideoPacketLossRate", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>UTC time when the stream ended. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. This field is only available for streams that use the SIP protocol.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Indicates whether the forward error correction (FEC) was used at some point during the session. The default value is null.</summary>
        public bool? IsAudioForwardErrorCorrectionUsed {
            get { return BackingStore?.Get<bool?>("isAudioForwardErrorCorrectionUsed"); }
            set { BackingStore?.Set("isAudioForwardErrorCorrectionUsed", value); }
        }
        /// <summary>Fraction of the call where frame rate is less than 7.5 frames per second.</summary>
        public float? LowFrameRateRatio {
            get { return BackingStore?.Get<float?>("lowFrameRateRatio"); }
            set { BackingStore?.Set("lowFrameRateRatio", value); }
        }
        /// <summary>Fraction of the call that the client is running less than 70% expected video processing capability.</summary>
        public float? LowVideoProcessingCapabilityRatio {
            get { return BackingStore?.Get<float?>("lowVideoProcessingCapabilityRatio"); }
            set { BackingStore?.Set("lowVideoProcessingCapabilityRatio", value); }
        }
        /// <summary>Maximum of audio network jitter computed over each of the 20 second windows during the session, denoted in [ISO 8601][] format. For example, 1 second is denoted as &apos;PT1S&apos;, where &apos;P&apos; is the duration designator, &apos;T&apos; is the time designator, and &apos;S&apos; is the second designator.</summary>
        public TimeSpan? MaxAudioNetworkJitter {
            get { return BackingStore?.Get<TimeSpan?>("maxAudioNetworkJitter"); }
            set { BackingStore?.Set("maxAudioNetworkJitter", value); }
        }
        /// <summary>Maximum jitter for the stream computed as specified in RFC 3550, denoted in [ISO 8601][] format. For example, 1 second is denoted as &apos;PT1S&apos;, where &apos;P&apos; is the duration designator, &apos;T&apos; is the time designator, and &apos;S&apos; is the second designator.</summary>
        public TimeSpan? MaxJitter {
            get { return BackingStore?.Get<TimeSpan?>("maxJitter"); }
            set { BackingStore?.Set("maxJitter", value); }
        }
        /// <summary>Maximum packet loss rate for the stream.</summary>
        public float? MaxPacketLossRate {
            get { return BackingStore?.Get<float?>("maxPacketLossRate"); }
            set { BackingStore?.Set("maxPacketLossRate", value); }
        }
        /// <summary>Maximum ratio of packets concealed by the healer.</summary>
        public float? MaxRatioOfConcealedSamples {
            get { return BackingStore?.Get<float?>("maxRatioOfConcealedSamples"); }
            set { BackingStore?.Set("maxRatioOfConcealedSamples", value); }
        }
        /// <summary>Maximum network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as &apos;PT1S&apos;, where &apos;P&apos; is the duration designator, &apos;T&apos; is the time designator, and &apos;S&apos; is the second designator.</summary>
        public TimeSpan? MaxRoundTripTime {
            get { return BackingStore?.Get<TimeSpan?>("maxRoundTripTime"); }
            set { BackingStore?.Set("maxRoundTripTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Packet count for the stream.</summary>
        public long? PacketUtilization {
            get { return BackingStore?.Get<long?>("packetUtilization"); }
            set { BackingStore?.Set("packetUtilization", value); }
        }
        /// <summary>Packet loss rate after FEC has been applied aggregated across all video streams and codecs.</summary>
        public float? PostForwardErrorCorrectionPacketLossRate {
            get { return BackingStore?.Get<float?>("postForwardErrorCorrectionPacketLossRate"); }
            set { BackingStore?.Set("postForwardErrorCorrectionPacketLossRate", value); }
        }
        /// <summary>Average duration of the received freezing time in the video stream represented in root mean square.</summary>
        public TimeSpan? RmsFreezeDuration {
            get { return BackingStore?.Get<TimeSpan?>("rmsFreezeDuration"); }
            set { BackingStore?.Set("rmsFreezeDuration", value); }
        }
        /// <summary>UTC time when the stream started. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. This field is only available for streams that use the SIP protocol.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The streamDirection property</summary>
        public MediaStreamDirection? StreamDirection {
            get { return BackingStore?.Get<MediaStreamDirection?>("streamDirection"); }
            set { BackingStore?.Set("streamDirection", value); }
        }
        /// <summary>Unique identifier for the stream.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StreamId {
            get { return BackingStore?.Get<string?>("streamId"); }
            set { BackingStore?.Set("streamId", value); }
        }
#nullable restore
#else
        public string StreamId {
            get { return BackingStore?.Get<string>("streamId"); }
            set { BackingStore?.Set("streamId", value); }
        }
#endif
        /// <summary>Codec name used to encode video for transmission on the network. Possible values are: unknown, invalid, av1, h263, h264, h264s, h264uc, h265, rtvc1, rtVideo, xrtvc1, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.CallRecords.VideoCodec? VideoCodec {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallRecords.VideoCodec?>("videoCodec"); }
            set { BackingStore?.Set("videoCodec", value); }
        }
        /// <summary>True if the media stream bypassed the Mediation Server and went straight between client and PSTN Gateway/PBX, false otherwise.</summary>
        public bool? WasMediaBypassed {
            get { return BackingStore?.Get<bool?>("wasMediaBypassed"); }
            set { BackingStore?.Set("wasMediaBypassed", value); }
        }
        /// <summary>
        /// Instantiates a new mediaStream and sets the default values.
        /// </summary>
        public MediaStream() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MediaStream CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaStream();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"audioCodec", n => { AudioCodec = n.GetEnumValue<AudioCodec>(); } },
                {"averageAudioDegradation", n => { AverageAudioDegradation = n.GetFloatValue(); } },
                {"averageAudioNetworkJitter", n => { AverageAudioNetworkJitter = n.GetTimeSpanValue(); } },
                {"averageBandwidthEstimate", n => { AverageBandwidthEstimate = n.GetLongValue(); } },
                {"averageFreezeDuration", n => { AverageFreezeDuration = n.GetTimeSpanValue(); } },
                {"averageJitter", n => { AverageJitter = n.GetTimeSpanValue(); } },
                {"averagePacketLossRate", n => { AveragePacketLossRate = n.GetFloatValue(); } },
                {"averageRatioOfConcealedSamples", n => { AverageRatioOfConcealedSamples = n.GetFloatValue(); } },
                {"averageReceivedFrameRate", n => { AverageReceivedFrameRate = n.GetFloatValue(); } },
                {"averageRoundTripTime", n => { AverageRoundTripTime = n.GetTimeSpanValue(); } },
                {"averageVideoFrameLossPercentage", n => { AverageVideoFrameLossPercentage = n.GetFloatValue(); } },
                {"averageVideoFrameRate", n => { AverageVideoFrameRate = n.GetFloatValue(); } },
                {"averageVideoPacketLossRate", n => { AverageVideoPacketLossRate = n.GetFloatValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"isAudioForwardErrorCorrectionUsed", n => { IsAudioForwardErrorCorrectionUsed = n.GetBoolValue(); } },
                {"lowFrameRateRatio", n => { LowFrameRateRatio = n.GetFloatValue(); } },
                {"lowVideoProcessingCapabilityRatio", n => { LowVideoProcessingCapabilityRatio = n.GetFloatValue(); } },
                {"maxAudioNetworkJitter", n => { MaxAudioNetworkJitter = n.GetTimeSpanValue(); } },
                {"maxJitter", n => { MaxJitter = n.GetTimeSpanValue(); } },
                {"maxPacketLossRate", n => { MaxPacketLossRate = n.GetFloatValue(); } },
                {"maxRatioOfConcealedSamples", n => { MaxRatioOfConcealedSamples = n.GetFloatValue(); } },
                {"maxRoundTripTime", n => { MaxRoundTripTime = n.GetTimeSpanValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"packetUtilization", n => { PacketUtilization = n.GetLongValue(); } },
                {"postForwardErrorCorrectionPacketLossRate", n => { PostForwardErrorCorrectionPacketLossRate = n.GetFloatValue(); } },
                {"rmsFreezeDuration", n => { RmsFreezeDuration = n.GetTimeSpanValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"streamDirection", n => { StreamDirection = n.GetEnumValue<MediaStreamDirection>(); } },
                {"streamId", n => { StreamId = n.GetStringValue(); } },
                {"videoCodec", n => { VideoCodec = n.GetEnumValue<VideoCodec>(); } },
                {"wasMediaBypassed", n => { WasMediaBypassed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AudioCodec>("audioCodec", AudioCodec);
            writer.WriteFloatValue("averageAudioDegradation", AverageAudioDegradation);
            writer.WriteTimeSpanValue("averageAudioNetworkJitter", AverageAudioNetworkJitter);
            writer.WriteLongValue("averageBandwidthEstimate", AverageBandwidthEstimate);
            writer.WriteTimeSpanValue("averageFreezeDuration", AverageFreezeDuration);
            writer.WriteTimeSpanValue("averageJitter", AverageJitter);
            writer.WriteFloatValue("averagePacketLossRate", AveragePacketLossRate);
            writer.WriteFloatValue("averageRatioOfConcealedSamples", AverageRatioOfConcealedSamples);
            writer.WriteFloatValue("averageReceivedFrameRate", AverageReceivedFrameRate);
            writer.WriteTimeSpanValue("averageRoundTripTime", AverageRoundTripTime);
            writer.WriteFloatValue("averageVideoFrameLossPercentage", AverageVideoFrameLossPercentage);
            writer.WriteFloatValue("averageVideoFrameRate", AverageVideoFrameRate);
            writer.WriteFloatValue("averageVideoPacketLossRate", AverageVideoPacketLossRate);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteBoolValue("isAudioForwardErrorCorrectionUsed", IsAudioForwardErrorCorrectionUsed);
            writer.WriteFloatValue("lowFrameRateRatio", LowFrameRateRatio);
            writer.WriteFloatValue("lowVideoProcessingCapabilityRatio", LowVideoProcessingCapabilityRatio);
            writer.WriteTimeSpanValue("maxAudioNetworkJitter", MaxAudioNetworkJitter);
            writer.WriteTimeSpanValue("maxJitter", MaxJitter);
            writer.WriteFloatValue("maxPacketLossRate", MaxPacketLossRate);
            writer.WriteFloatValue("maxRatioOfConcealedSamples", MaxRatioOfConcealedSamples);
            writer.WriteTimeSpanValue("maxRoundTripTime", MaxRoundTripTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("packetUtilization", PacketUtilization);
            writer.WriteFloatValue("postForwardErrorCorrectionPacketLossRate", PostForwardErrorCorrectionPacketLossRate);
            writer.WriteTimeSpanValue("rmsFreezeDuration", RmsFreezeDuration);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<MediaStreamDirection>("streamDirection", StreamDirection);
            writer.WriteStringValue("streamId", StreamId);
            writer.WriteEnumValue<VideoCodec>("videoCodec", VideoCodec);
            writer.WriteBoolValue("wasMediaBypassed", WasMediaBypassed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
