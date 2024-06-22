using RegistaMaster.Domain.Enums;
using System.ComponentModel;

namespace RegistaMaster.Domain.DTOModels.Entities.RequestModels;

public class RequestTicketCreateDTO
{
    public NotificationTypeCNC TicketType{ get; set; }
    public NotificationTypeCNC NotificationTypeCNC { get; set; }
    public string TicketTitle { get; set; }
    public string TicketContent { get; set; }
    public string? Image { get; set; }
    public string PageURL { get; set; }
}
