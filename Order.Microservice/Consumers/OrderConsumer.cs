using MassTransit;
using Shared.Models;
using Shared.Models.Models;
using System.Text.Json;

namespace Order.Microservice.Consumers
{
    public class OrderConsumer : IConsumer<INotificationCreated>
    {
        public async Task Consume(ConsumeContext<INotificationCreated> context)
        {
            var serializedMessage = JsonSerializer.Serialize(context.Message, new JsonSerializerOptions { });

            Console.WriteLine($"NotificationCreated event consumed. Message: {serializedMessage}");
        }
    }
}
