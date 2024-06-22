﻿namespace RegistaMaster.Domain.DTOModels.EmailModels;

public class EmailSendDTO
{
    public string Name { get; set; }
    public string To { get; set; }
    public List<string> CCes{ get; set; }
    public string Body { get; set; }
    public string Subject { get; set; }
    public string AttachmentURL { get; set; }
}
