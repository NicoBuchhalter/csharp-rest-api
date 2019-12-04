using System;
using MessageBird.Net;
using MessageBird.Objects;
using Newtonsoft.Json;

namespace MessageBird.Resources.VoiceCalls
{
    public class CallsResource : Resource
    {
        public static string CallBaseUrl = "https://voice.messagebird.com";

        public CallsResource(string name, IIdentifiable<string> attachedObject) :
            base(name, attachedObject)
        {
            //
        }

        public override string BaseUrl
        {
            get
            {
                return CallBaseUrl;
            }
        }
        public override string Serialize()
        {
            var requestObject = ((Objects.VoiceCalls.VoiceCallFlow)Object).ToRequestObject();

            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            return JsonConvert.SerializeObject(requestObject, settings);
        }
    }
}