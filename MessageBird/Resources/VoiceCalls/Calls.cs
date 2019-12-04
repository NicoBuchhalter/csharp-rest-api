using MessageBird.Net;

namespace MessageBird.Resources.VoiceCalls
{
    public class Calls : CallsResource
    {
        public Calls(Objects.VoiceCalls.Call call) : base("calls", call) { }
        public Calls() : this(new Objects.VoiceCalls.Call()) { }
    }
}