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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class MatchPhraseQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "match_phrase";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("slop")]
		public int? Slop { get; set; }

		[JsonInclude]
		[JsonPropertyName("zero_terms_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public sealed partial class MatchPhraseQueryDescriptor<T> : FieldNameQueryDescriptorBase<MatchPhraseQueryDescriptor<T>, T>
	{
		public MatchPhraseQueryDescriptor()
		{
		}

		internal MatchPhraseQueryDescriptor(Action<MatchPhraseQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal string? AnalyzerValue { get; private set; }

		internal string QueryValue { get; private set; }

		internal int? SlopValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; private set; }

		public MatchPhraseQueryDescriptor<T> Analyzer(string? analyzer) => Assign(analyzer, (a, v) => a.AnalyzerValue = v);
		public MatchPhraseQueryDescriptor<T> Query(string query) => Assign(query, (a, v) => a.QueryValue = v);
		public MatchPhraseQueryDescriptor<T> Slop(int? slop) => Assign(slop, (a, v) => a.SlopValue = v);
		public MatchPhraseQueryDescriptor<T> ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery) => Assign(zeroTermsQuery, (a, v) => a.ZeroTermsQueryValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WritePropertyName(settings.Inferrer.Field(_field));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (SlopValue.HasValue)
			{
				writer.WritePropertyName("slop");
				writer.WriteNumberValue(SlopValue.Value);
			}

			if (ZeroTermsQueryValue is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
			}

			writer.WriteEndObject();
		}
	}
}