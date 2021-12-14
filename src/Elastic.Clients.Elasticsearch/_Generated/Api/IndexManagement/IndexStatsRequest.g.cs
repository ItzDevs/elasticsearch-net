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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexStatsRequestParameters : RequestParameters<IndexStatsRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("completion_fields"); set => Q("completion_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? ForbidClosedIndices { get => Q<bool?>("forbid_closed_indices"); set => Q("forbid_closed_indices", value); }

		[JsonIgnore]
		public IEnumerable<string>? Groups { get => Q<IEnumerable<string>?>("groups"); set => Q("groups", value); }

		[JsonIgnore]
		public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

		[JsonIgnore]
		public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }
	}

	public partial class IndexStatsRequest : PlainRequestBase<IndexStatsRequestParameters>
	{
		public IndexStatsRequest()
		{
		}

		public IndexStatsRequest(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public IndexStatsRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		public IndexStatsRequest(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("completion_fields"); set => Q("completion_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? ForbidClosedIndices { get => Q<bool?>("forbid_closed_indices"); set => Q("forbid_closed_indices", value); }

		[JsonIgnore]
		public IEnumerable<string>? Groups { get => Q<IEnumerable<string>?>("groups"); set => Q("groups", value); }

		[JsonIgnore]
		public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

		[JsonIgnore]
		public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }
	}

	public sealed partial class IndexStatsRequestDescriptor<T> : RequestDescriptorBase<IndexStatsRequestDescriptor<T>, IndexStatsRequestParameters>
	{
		public IndexStatsRequestDescriptor()
		{
		}

		public IndexStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public IndexStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		public IndexStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
		{
		}

		internal IndexStatsRequestDescriptor(Action<IndexStatsRequestDescriptor<T>> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IndexStatsRequestDescriptor<T> CompletionFields(Elastic.Clients.Elasticsearch.Fields? completionFields) => Qs("completion_fields", completionFields);
		public IndexStatsRequestDescriptor<T> ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexStatsRequestDescriptor<T> FielddataFields(Elastic.Clients.Elasticsearch.Fields? fielddataFields) => Qs("fielddata_fields", fielddataFields);
		public IndexStatsRequestDescriptor<T> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
		public IndexStatsRequestDescriptor<T> ForbidClosedIndices(bool? forbidClosedIndices) => Qs("forbid_closed_indices", forbidClosedIndices);
		public IndexStatsRequestDescriptor<T> Groups(IEnumerable<string>? groups) => Qs("groups", groups);
		public IndexStatsRequestDescriptor<T> IncludeSegmentFileSizes(bool? includeSegmentFileSizes) => Qs("include_segment_file_sizes", includeSegmentFileSizes);
		public IndexStatsRequestDescriptor<T> IncludeUnloadedSegments(bool? includeUnloadedSegments) => Qs("include_unloaded_segments", includeUnloadedSegments);
		public IndexStatsRequestDescriptor<T> Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}