using LiveVox.NET.Models;
using LiveVox.NET.Models.Base;

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
