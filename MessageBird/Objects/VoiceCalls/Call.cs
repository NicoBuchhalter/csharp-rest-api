using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageBird.Objects.VoiceCalls
{

    public enum CallStatus
    {
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "starting")]
        Starting,
        [EnumMember(Value = "ongoing")]
        Ongoing,
        [EnumMember(Value = "ended")]
        Ended 
    };

    public class Call : IIdentifiable<string>
    {

        [JsonProperty("id")] 
        public string Id { get; set; }

        [JsonProperty("status")] 
        public CallStatus status { get; set; }

        [JsonProperty("source")] 
        public string source { get; set; }

        [JsonProperty("destination")] 
        public string destination { get; set; }      
         
        [JsonProperty("webhook")] 
        public Webhook webhook { get; set; }

        [JsonProperty("duration")] 
        public int duration { get; set; }

        [JsonProperty("createdAt")] 
        public DateTime? createdAt { get; set; }

        [JsonProperty("updatedAt")] 
        public DateTime? updatedAt { get; set; }

        [JsonProperty("endedAt")] 
        public DateTime? endedAt { get; set; }
    }
}