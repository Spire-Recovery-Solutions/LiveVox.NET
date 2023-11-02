using RestSharp;

namespace LiveVox.NET.Models.Base;

public interface ILiveVoxRequest
{
    string? Category { get; set; }
    string? Resource { get; set; }
    Method RequestType { get; set; }
}