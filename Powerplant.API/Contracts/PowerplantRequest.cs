﻿using Newtonsoft.Json;
using Powerplant.Domain.Enums;
using Powerplant.Domain.Models;
using System.Text.Json.Serialization;

namespace Powerplant.API.Contracts
{
    public class PowerplantRequest
    {
        [JsonPropertyName("powerplants")]
        public List<Powerplant> PowerPlants { get; set; }

        [JsonPropertyName("load")]
        public decimal Load { get; set; }

        [JsonPropertyName("fuels")]
        public FuelInfo FuelInfo { get; set; }
    }

    public class Powerplant
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public PowerplantType Type { get; set; }
        [JsonPropertyName("efficiency")]
        public decimal Efficiency { get; set; }
        [JsonPropertyName("pmin")]
        public decimal Pmin { get; set; }
        [JsonPropertyName("pmax")]
        public decimal Pmax { get; set; }
    }

    public class FuelInfo
    {
        [JsonPropertyName("gas(euro/MWh)")]
        public decimal GasEuroPerMWh { get; set; }
        [JsonPropertyName("kerosine(euro/MWh)")]
        public decimal KerosineEuroPerMWh { get; set; }
        [JsonPropertyName("co2(euro/ton)")]
        public decimal Co2EuroPerTon { get; set; }
        [JsonPropertyName("wind(%)")]
        public decimal WindEfficiencyPercent { get; set; }
    }
}
