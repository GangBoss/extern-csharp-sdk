﻿using KeApiOpenSdk.Models.JsonConverters;
using Newtonsoft.Json;

namespace KeApiOpenSdk.Models.DraftsBuilders.DocumentFiles.Data
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public abstract class DraftsBuilderDocumentFileData
    {
    }
}