using System.Text.Json.Serialization;

namespace LoginPageAndSmartID
{
    public class AuthenticationResponse
    {
        [JsonPropertyName("sessionID")]
        public string SessionId { get; set; }
    }
}