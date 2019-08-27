﻿using System;
using KeApiOpenSdk.Models.Common;
using KeApiOpenSdk.Models.JsonConverters;
using Newtonsoft.Json;

namespace KeApiOpenSdk.Models.Events
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class EventsPage
    {
        public string FirstEventId { get; set; }

        [Obsolete("Should be removed in next releases. To get next event page use NextEventId as from parameter")]
        public string LastEventId { get; set; }

        public string NextEventId { get; set; }
        public int RequestedCount { get; set; }
        public int ReturnedCount { get; set; }
        public ApiEvent[] ApiEvents { get; set; }
        public Link[] Links { get; set; }
    }
}