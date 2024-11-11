namespace AuthDep.Models;

public class InfoAccessTokenModel
{
    public IDictionary<string, object> Headers { get; set; }

    public IDictionary<string, object> Payload { get; set; }

    public string OriginalPayload { get; set; }
}