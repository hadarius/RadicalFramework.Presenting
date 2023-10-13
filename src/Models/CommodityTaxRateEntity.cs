﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace Radical.Presenting.Components;

public class CommodityTaxRateEntity
{
    public string? Row { get; set; }

    [JsonPropertyName("word")]
    public string? CommodityTaxRate { get; set; }
}
