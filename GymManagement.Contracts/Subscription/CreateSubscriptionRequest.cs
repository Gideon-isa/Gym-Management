namespace GymManagement.Contracts.Subscription
{
    public record class CreateSubscriptionRequest(SubscriptionType SubscriptionType, Guid AdminId)
    {
    }
}
