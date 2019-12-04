using MessageBird.Objects.VoiceCalls;

namespace MessageBird.Resources.VoiceCalls
{
    public class CallLists : CallBaseLists<Objects.VoiceCalls.Call>
    {
        public CallLists()
            : base("calls", new CallList())
        { }
    }
}


