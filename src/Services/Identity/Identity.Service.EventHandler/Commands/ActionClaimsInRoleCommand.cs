using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static Identity.Common.Enums;

namespace Identity.Service.EventHandler.Commands
{
    public class ActionClaimsInRoleCommand : INotification
    {
        [Required]
        public string roleId{ get; set; }
        [Required]
        public List<string> claimsId  { get; set; }
        public AgregateRemoveAction action { get; set; }
    }
}
