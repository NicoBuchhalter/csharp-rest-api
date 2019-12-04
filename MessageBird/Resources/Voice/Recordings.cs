﻿using System;
using MessageBird.Exceptions;
using MessageBird.Objects.Voice;
using Newtonsoft.Json;

namespace MessageBird.Resources.Voice
{
    public class Recordings : RecordingsResource
    {
        public Recordings(Recording recording)
            : base("calls", recording)
        {
        }

        public override string Uri
        {
            get
            {
                return String.Format("{0}/{1}/legs/{2}/recordings/{3}", Name, ((Recording)Object).CallId, ((Recording)Object).LegId, Object.Id);
            }
        }

        public override void Deserialize(string resource)
        {
            try
            {
                Object = JsonConvert.DeserializeObject<RecordingResponse>(resource);
            }
            catch (JsonSerializationException e)
            {
                throw new ErrorException("Received response in an unexpected format!", e);
            }
        }
    }
}
