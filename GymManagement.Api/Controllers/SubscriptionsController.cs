using GymManagement.Application.Services;
using GymManagement.Contracts.Subscription;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscriptionsController : ControllerBase
	{
		private readonly ISubscriptionService _subscriptionService;

		public SubscriptionsController(ISubscriptionService subscriptionService)
		{
			_subscriptionService = subscriptionService;
		}

		[HttpPost]
		public IActionResult CreateSubscription(CreateSubscriptionRequest request)
		{
			var subscriptionId = _subscriptionService.CreateSubscription(request.SubscriptionType.ToString(), request.AdminId);
			var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);
			return Ok(response);
		}
	}
}
