namespace Project2015To2017.Definition
{
    public sealed class PackageConfiguration
    {
        public string Id { get; internal set; }
        public string Version { get; internal set; }
        public string Authors { get; internal set; }
        public string Description { get; internal set; }
        public string Copyright { get; internal set; }
        public string LicenseUrl { get; internal set; }
        public string ProjectUrl { get; internal set; }
        public string IconUrl { get; internal set; }
        public string Tags { get; internal set; }
        public string ReleaseNotes { get; internal set; }
        public bool RequiresLicenseAcceptance { get; internal set; }
    }
}
