﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiscordUnity2.Models
{
    public class PayloadModel : PayloadModel<JObject>
    {
        public PayloadModel<T> As<T>() => new PayloadModel<T> { Op = Op, Data = Data.ToObject<T>(DiscordUnity.JsonSerializer) };
    }

    public class PayloadModel<T>
    {
        public int Op;
        [JsonProperty("d")]
        public T Data;
        [JsonProperty("s")]
        public int? Sequence;
        [JsonProperty("t")]
        public string Event;
    }
}
