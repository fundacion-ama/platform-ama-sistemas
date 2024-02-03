﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using FundacionAMA.Domain.Shared.Entities;
using System;
using System.Collections.Generic;

namespace FundacionAMA.Domain.Entities;

public partial class Volunteer: BaseEntity
{

    public int PersonId { get; set; }

    public string Gender { get; set; }

    public string Address { get; set; }

    public string Status { get; set; }

    public bool Availability { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int ActivityTypeId { get; set; }

    public virtual ActivityType ActivityType { get; set; }

    public virtual ICollection<BrigadeVoluntareer> BrigadeVoluntareers { get; set; } = new List<BrigadeVoluntareer>();

    public virtual Person Person { get; set; }
}