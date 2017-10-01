namespace SalesMaster.Data.Entities
{
    #region Using
    using Newtonsoft.Json;
    #endregion Using

    public class Sale
    {
        [JsonProperty(PropertyName = "i")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "stn")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "n")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "cc")]
        public string CountryCode { get; set; }

        [JsonProperty(PropertyName = "c")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
