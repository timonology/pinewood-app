﻿using PinewoodAssessment.Domain.Common;

namespace PinewoodAssessment.Domain.Entities;

public class User : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}