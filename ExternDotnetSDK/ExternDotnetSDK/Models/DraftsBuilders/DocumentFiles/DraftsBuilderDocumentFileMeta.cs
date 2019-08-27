﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using KeApiOpenSdk.Models.Common;
using KeApiOpenSdk.Models.DraftsBuilders.DocumentFiles.Data;
using KeApiOpenSdk.Models.JsonConverters;
using Newtonsoft.Json;

namespace KeApiOpenSdk.Models.DraftsBuilders.DocumentFiles
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class DraftsBuilderDocumentFileMeta
    {
        [Required]
        [DataMember]
        public string FileName { get; set; }

        [Required]
        [DataMember]
        public Urn BuilderType { get; set; }

        [Required]
        [DataMember]
        public DraftsBuilderDocumentFileData BuilderData { get; set; }
    }
}