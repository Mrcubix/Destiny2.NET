namespace API.Entities.Config
{
    public class DestinyManifest
    {
        public string Version { get; set; }
        public string MobileAssetContentPath { get; set; }
        public GearAssetDataBaseDefinition[] MobileGearAssetDataBases { get; set; }
        public Dictionary<string, string> MobileWorldContentPaths { get; set; }
        public Dictionary<string, string> JsonWorldContentPaths { get; set; }
        public Dictionary<string, object> JsonWorldComponentContentPaths { get; set; }
        public string MobileClanBannerDatabasePath { get; set; }
        public Dictionary<string, string> MobileGearCDN { get; set; }
        public ImagePyramidEntry[] iconImagePyramidInfo { get; set; }
    }
}