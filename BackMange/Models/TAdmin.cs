﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BackMange.Models;

public partial class TAdmin
{
    public int FadminId { get; set; }

    public string FadminNo { get; set; }

    public string FfullName { get; set; }

    public string Femail { get; set; }

    public string FadmPassword { get; set; }

    public string FmobilePhone { get; set; }

    public int FadminLevel { get; set; }

    public byte FstatusId { get; set; }

    public DateTime? FcreatedAt { get; set; }

    public DateTime? FupdatedAt { get; set; }

    public virtual TAdminStatus Fstatus { get; set; }
}