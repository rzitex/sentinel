﻿namespace Sentinel.FileMonitor
{
    using System.Globalization;

    using Sentinel.Interfaces.Providers;

    public class FileMonitoringProviderSettings : IFileMonitoringProviderSettings
    {
        public FileMonitoringProviderSettings()
        {
        }

        public FileMonitoringProviderSettings(
            IProviderInfo info,
            string providerName,
            string fileName,
            int refreshPeriod,
            bool loadExistingContent)
        {
            Info = info;
            Name = providerName;
            FileName = fileName;
            RefreshPeriod = refreshPeriod;
            LoadExistingContent = loadExistingContent;
        }

        public string FileName { get; set; }

        /// <summary>
        /// Gets the reference back to the provider this setting is appropriate to.
        /// </summary>
        public IProviderInfo Info { get; set; }

        public bool LoadExistingContent { get; set; }

        public string MessageDecoder { get; set; }

        public string Name { get; set; }

        public int RefreshPeriod { get; set; }

        public string Summary
            => string.Format(CultureInfo.InvariantCulture, "Monitor the file {0} for new log entries", FileName);

        public void Update(string fileName, int refreshPeriod, bool loadExistingContent)
        {
            FileName = fileName;
            RefreshPeriod = refreshPeriod;
            LoadExistingContent = loadExistingContent;
        }
    }
}