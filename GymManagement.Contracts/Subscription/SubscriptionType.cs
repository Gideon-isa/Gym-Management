using System.Text.Json.Serialization;

namespace GymManagement.Contracts.Subscription
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubscriptionType
    {
        Free,
        Starter,
        Pro
    }
}
