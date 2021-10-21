using Newtonsoft.Json;

using System.Collections.Generic;

namespace testWebClient.Model
{
    public class StorageAssurWare
    {
        [JsonConstructor]
        public StorageAssurWare(
            [JsonProperty("Data")] Data data,
            [JsonProperty("Description")] object description,
            [JsonProperty("Duration")] string duration,
            [JsonProperty("Exception")] object exception,
            [JsonProperty("Status")] int status,
            [JsonProperty("Tags")] List<object> tags
        )
        {
            this.Data = data;
            this.Description = description;
            this.Duration = duration;
            this.Exception = exception;
            this.Status = status;
            this.Tags = tags;
        }

        [JsonProperty("Data")]
        public Data Data { get; }

        [JsonProperty("Description")]
        public object Description { get; }

        [JsonProperty("Duration")]
        public string Duration { get; }

        [JsonProperty("Exception")]
        public object Exception { get; }

        [JsonProperty("Status")]
        public int Status { get; }

        [JsonProperty("Tags")]
        public IReadOnlyList<object> Tags { get; }
    }

}
