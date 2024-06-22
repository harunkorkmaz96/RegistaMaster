﻿using Microsoft.AspNetCore.Mvc.Rendering;
using RegistaMaster.Domain.Enums;

namespace RegistaMaster.Domain.DTOModels.Entities.ActionModels;

public class ActionDTO
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public int ResponsibleId { get; set; }
    public int RequestId { get; set; }
    public DateTime OpeningDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime CompleteDate { get; set; }
    public DateTime? CreatedOn { get; set; }
    public ActionStatus ActionStatus{ get; set; }
    public RequestStatus RequestStatus { get; set; }
    public ActionPriorityStatus ActionPriorityStatus { get; set; }
    public string Description { get; set; }
    public int  LastModifiedBy { get; set; }
    public string Color { get; set; }
    public int  CreatedBy { get; set; }
    public  List<SelectListItem> ResponsibleHelperModelList { get; set; }
}
