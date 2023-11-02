﻿using System.Text.Json.Serialization;

namespace ShiftsLogger.Lonchanick.Models;

public class Shift
{
    public Guid Id { get; set; }
    public DateTime Check { get; set; }
    public CheckType CheckTypeField {get; set;} 
    public Guid WorkerId { get; set; }

    [JsonIgnore]
    public virtual Worker Worker { get; set; }
}

public enum CheckType{
    CheckIn,
    CheckOut
}