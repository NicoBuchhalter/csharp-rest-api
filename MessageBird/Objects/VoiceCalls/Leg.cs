using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageBird.Objects.VoiceCalls
{

    public enum LegStatus
    {
        [EnumMember(Value = "starting")]
        Starting,
        [EnumMember(Value = "ringing")]
        Ringing,
        [EnumMember(Value = "ongoing")]
        Ongoing,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "no_answer")]
        NoAnswer,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "hangup")]
        Hangup
    };

    public enum LegDirection
    {
        [EnumMember(Value = "incoming")]
        Incoming,
        [EnumMember(Value = "outgoing")]
        Outgoing
    };

    public class Leg : IIdentifiable<string>
    {

        [JsonProperty("id")] 
        public string Id { get; set; }

        [JsonProperty("callId")] 
        public string callId { get; set; }

        [JsonProperty("source")] 
        public string source { get; set; }

        [JsonProperty("destination")] 
        public string destination { get; set; }        
         
        [JsonProperty("status")] 
        public LegStatus status { get; set; }

        [JsonProperty("direction")] 
        public LegDirection direction { get; set; }

        [JsonProperty("cost")] 
        public float cost { get; set; }

        [JsonProperty("currency")] 
        public string currency { get; set; }

        [JsonProperty("duration")] 
        public int duration { get; set; }

        [JsonProperty("createdAt")] 
        public DateTime? createdAt { get; set; }

        [JsonProperty("updatedAt")] 
        public DateTime? updatedAt { get; set; }

        [JsonProperty("answeredAt")] 
        public DateTime? answeredAt { get; set; }

        [JsonProperty("endedAt")] 
        public DateTime? endedAt { get; set; }
    }
}