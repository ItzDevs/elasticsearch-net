// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.Stats
{
	public partial class ClusterJvmVersion
	{
		[JsonInclude]
		[JsonPropertyName("bundled_jdk")]
		public bool BundledJdk { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("using_bundled_jdk")]
		public bool UsingBundledJdk { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public string Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("vm_name")]
		public string VmName { get; init; }

		[JsonInclude]
		[JsonPropertyName("vm_vendor")]
		public string VmVendor { get; init; }

		[JsonInclude]
		[JsonPropertyName("vm_version")]
		public string VmVersion { get; init; }
	}
}