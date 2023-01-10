using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Models
{
    public class NotificationDto
    {
        public DateTime NotificationDate { get; set; }
        public string NotificationMessage { get; set; }
        public NotificationType NotificationType { get; set; }
    }
}