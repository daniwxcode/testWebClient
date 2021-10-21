using Newtonsoft.Json;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace testWebClient.Model
{

    public class Root
    {
        [JsonConstructor]
        public Root(
            [JsonProperty("Entries")] Entries entries,
            [JsonProperty("Status")] int status,
            [JsonProperty("TotalDuration")] string totalDuration
        )
        {
            this.Entries = entries;
            this.Status = status;
            this.TotalDuration = totalDuration;
        }

        [JsonProperty("Entries")]
        public Entries Entries { get; }

        [JsonProperty("Status")]
        public int Status { get; }

        [JsonProperty("TotalDuration")]
        public string TotalDuration { get; }
    }

}
