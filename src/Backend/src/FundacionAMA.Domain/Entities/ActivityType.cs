﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using FundacionAMA.Domain.Shared.Entities;
using System;
using System.Collections.Generic;

namespace FundacionAMA.Domain.Entities;

public partial class ActivityType: BaseEntity<int>
{
 

    public int? CompanyId { get; set; }

    public string Name { get; set; }

    public string Status { get; set; }
    public virtual ICollection<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
}