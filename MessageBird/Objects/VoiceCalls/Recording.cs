using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageBird.Objects.VoiceCalls
{

    public enum RecordingType
    {
        [EnumMember(Value = "ivr")]
        Ivr,
        [EnumMember(Value = "transfer")]
        Transfer,
        [EnumMember(Value = "call")]
        Call
    };

    public enum RecordingStatus
    {
        [EnumMember(Value = "initialised")]
        Initialised,
        [EnumMember(Value = "recording")]
        Recording,
        [EnumMember(Value = "done")]
        Done,
        [EnumMember(Value = "failed")]
        Failed 
    };

    public enum RecordingFormat
    {
        [EnumMember(Value = "wav")]
        Wav
    };

    public class RecordingLinks
    {
        [JsonProperty("self")] 
        public string self { get; set; }

        [JsonProperty("file")] 
        public string file { get; set; }
    }

    public class Recording : IIdentifiable<string>
    {

        [JsonProperty("id")] 
        public string Id { get; set; }

        [JsonProperty("format")] 
        public RecordingFormat format { get; set; }

        [JsonProperty("type")] 
        public RecordingType type { get; set; }

        [JsonProperty("legId")] 
        public string legId { get; set; }      
         
        [JsonProperty("status")] 
        public RecordingStatus status { get; set; }

        [JsonProperty("duration")] 
        public int duration { get; set; }

        [JsonProperty("createdAt")] 
        public DateTime? createdAt { get; set; }

        [JsonProperty("updatedAt")] 
        public DateTime? updatedAt { get; set; }

        [JsonProperty("_links")] 
        public RecordingLinks links { get; set; }
    }
}