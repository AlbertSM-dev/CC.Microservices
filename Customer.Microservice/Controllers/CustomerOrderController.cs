using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Models.Models;

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        public readonly IPublishEndpoint publishEndpoint;

        public CustomerOrderController(IPublishEndpoint publishEndpoint)
        {
            this.publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task<IActionResult> Notify(NotificationDto notificationDto)
        {
            await publishEndpoint.Publish<INotificationCreated>(new
            {
                NotificationDate = notificationDto.NotificationDate,
                NotificationMessage = notificationDto.NotificationMessage,
                NotificationType = notificationDto.NotificationType
            });

            return Ok();
        }
    }
}
