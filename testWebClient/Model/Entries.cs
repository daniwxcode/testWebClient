using Newtonsoft.Json;

namespace testWebClient.Model
{
    public class Entries
    {
        [JsonConstructor]
        public Entries(
            [JsonProperty("Endpoint")] Endpoint endpoint,
            [JsonProperty("Key Vault")] KeyVault keyVault,
            [JsonProperty("Emails (O365)")] EmailsO365 emailsO365,
            [JsonProperty("Database (MongoDB)")] DatabaseMongoDB databaseMongoDB,
            [JsonProperty("Storage (Extranet)")] StorageExtranet storageExtranet,
            [JsonProperty("Storage (AssurWare)")] StorageAssurWare storageAssurWare,
            [JsonProperty("Storage (Health data)")] StorageHealthData storageHealthData,
            [JsonProperty("Storage (Public assets)")] StoragePublicAssets storagePublicAssets,
            [JsonProperty("Storage (Application assets)")] StorageApplicationAssets storageApplicationAssets,
            [JsonProperty("Storage (SFTP Docevent)")] StorageSFTPDocevent storageSFTPDocevent
        )
        {
            this.Endpoint = endpoint;
            this.KeyVault = keyVault;
            this.EmailsO365 = emailsO365;
            this.DatabaseMongoDB = databaseMongoDB;
            this.StorageExtranet = storageExtranet;
            this.StorageAssurWare = storageAssurWare;
            this.StorageHealthData = storageHealthData;
            this.StoragePublicAssets = storagePublicAssets;
            this.StorageApplicationAssets = storageApplicationAssets;
            this.StorageSFTPDocevent = storageSFTPDocevent;
        }

        [JsonProperty("Endpoint")]
        public Endpoint Endpoint { get; }

        [JsonProperty("Key Vault")]
        public KeyVault KeyVault { get; }

        [JsonProperty("Emails (O365)")]
        public EmailsO365 EmailsO365 { get; }

        [JsonProperty("Database (MongoDB)")]
        public DatabaseMongoDB DatabaseMongoDB { get; }

        [JsonProperty("Storage (Extranet)")]
        public StorageExtranet StorageExtranet { get; }

        [JsonProperty("Storage (AssurWare)")]
        public StorageAssurWare StorageAssurWare { get; }

        [JsonProperty("Storage (Health data)")]
        public StorageHealthData StorageHealthData { get; }

        [JsonProperty("Storage (Public assets)")]
        public StoragePublicAssets StoragePublicAssets { get; }

        [JsonProperty("Storage (Application assets)")]
        public StorageApplicationAssets StorageApplicationAssets { get; }

        [JsonProperty("Storage (SFTP Docevent)")]
        public StorageSFTPDocevent StorageSFTPDocevent { get; }
    }

}
