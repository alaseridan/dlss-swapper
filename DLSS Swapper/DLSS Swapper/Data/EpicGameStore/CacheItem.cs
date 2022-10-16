﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DLSS_Swapper.Data.EpicGameStore
{
    internal class CacheItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; } = String.Empty;

        [JsonPropertyName("keyImages")]
        public CacheItemKeyImage[] KeyImages { get; set; } = new CacheItemKeyImage[0];


        internal class CacheItemKeyImage
        {
            [JsonPropertyName("type")]
            public string Type { get; set; } = String.Empty;

            [JsonPropertyName("url")]
            public string Url { get; set; } = String.Empty;

            [JsonPropertyName("width")]
            public int Width { get; set; }

            [JsonPropertyName("height")]
            public int Height { get; set; }

            [JsonPropertyName("size")]
            public int Size { get; set; }

            [JsonPropertyName("uploadedDate")]
            public string UploadedDate { get; set; } = String.Empty;

            [JsonPropertyName("md5")]
            public string MD5 { get; set; } = String.Empty;
        }
    }
}
