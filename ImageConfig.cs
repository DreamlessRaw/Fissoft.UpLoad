using System;
using System.Collections.Generic;
using System.Text;

namespace Fissoft.UpLoad
{
    public class ImageConfig
    {
        public static ImageConfig Instance { get; set; }
        public string Host { get; set; }
        public string UploadUrl { get; set; }
        public string ApiKey { get; set; }
    }
}
