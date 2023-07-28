using System;
using EstimateTracker.Data.Interfaces;

namespace EstimateTracker.Data.Models;

public class DataItemBase:IDataItem
{
    public string Id { get; set; } = "";
}

