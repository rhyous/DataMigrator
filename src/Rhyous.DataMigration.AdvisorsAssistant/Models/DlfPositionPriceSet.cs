﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class DlfPositionPriceSet
{
    public int IKeyProcess { get; set; }

    public int IKeySecurity { get; set; }

    public DateTime? DPrice { get; set; }

    public decimal NPrice { get; set; }

    public decimal NPoolFactor { get; set; }

    public decimal NPriceFactor { get; set; }

    public int IKeyPriceInAa { get; set; }

    public int IKeyDlffileCreated { get; set; }
}