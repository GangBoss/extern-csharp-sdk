﻿using System;
using KeApiOpenSdk.Models.JsonConverters;
using Newtonsoft.Json;

namespace KeApiOpenSdk.Models.DraftsBuilders.Builders
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class DraftsBuilderBuildErrorDocumentResult
    {
        public Guid DocumentId { get; set; }
        public string ErrorMessage { get; set; }
    }
}