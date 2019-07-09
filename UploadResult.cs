using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fissoft.UpLoad
{
    public class UploadResult
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
        [JsonProperty("format")]
        public string FormatUrl { get; set; }
        [JsonProperty("raw")]
        public string RawUrl { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
