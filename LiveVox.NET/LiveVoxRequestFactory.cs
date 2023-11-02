using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Session;

namespace LiveVox.NET
{
    public static class LiveVoxRequestFactory
    {
        public static class Session
        {
            public static ILiveVoxRequest IsSessionValid(string sessionId)
            {
                return new IsSessionValidRequest(sessionId);
            }
        }
    }
}
