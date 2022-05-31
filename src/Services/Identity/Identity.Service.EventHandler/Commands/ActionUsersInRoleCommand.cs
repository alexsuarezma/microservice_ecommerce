using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static Identity.Common.Enums;

namespace Identity.Service.EventHandler.Commands
{
    public class ActionUsersInRoleCommand : INotification
    {
        [Required]
        public string roleId { get; set; }
        [Required]
        public List<string> userId { get; set; }
        public AgregateRemoveAction action { get; set; }
    }
}
