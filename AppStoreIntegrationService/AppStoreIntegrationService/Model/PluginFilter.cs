﻿using System.Collections.Generic;

namespace AppStoreIntegrationService.Model
{
	public class PluginFilter
	{
		public string Query { get; set; }
		public string StudioVersion { get; set; }
		public string SortOrder { get; set; }
		public enum SortType
		{
			None,
			DownloadCount,
			ReviewCount,
			TopRated,
			LastUpdated,
			NewlyAdded
		}
		public SortType SortBy { get; set; }
		public string Price { get; set; }
		public List<int> CategoryId { get; set; }
	}
}
