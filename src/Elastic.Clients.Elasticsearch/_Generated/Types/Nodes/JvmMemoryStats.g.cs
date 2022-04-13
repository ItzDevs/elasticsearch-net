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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public partial class JvmMemoryStats
	{
		[JsonInclude]
		[JsonPropertyName("heap_committed_in_bytes")]
		public long? HeapCommittedInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("heap_max_in_bytes")]
		public long? HeapMaxInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("heap_used_in_bytes")]
		public long? HeapUsedInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("heap_used_percent")]
		public long? HeapUsedPercent { get; init; }

		[JsonInclude]
		[JsonPropertyName("non_heap_committed_in_bytes")]
		public long? NonHeapCommittedInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("non_heap_used_in_bytes")]
		public long? NonHeapUsedInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("pools")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Pool>? Pools { get; init; }
	}
}