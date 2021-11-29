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
	public partial class MatchBoolPrefixQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "match_bool_prefix";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public string? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }
	}

	public sealed partial class MatchBoolPrefixQueryDescriptor<T> : FieldNameQueryDescriptorBase<MatchBoolPrefixQueryDescriptor<T>, T>
	{
		public MatchBoolPrefixQueryDescriptor()
		{
		}

		internal MatchBoolPrefixQueryDescriptor(Action<MatchBoolPrefixQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal string? AnalyzerValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; private set; }

		internal string? FuzzyRewriteValue { get; private set; }

		internal bool? FuzzyTranspositionsValue { get; private set; }

		internal int? MaxExpansionsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; private set; }

		internal int? PrefixLengthValue { get; private set; }

		internal string QueryValue { get; private set; }

		public MatchBoolPrefixQueryDescriptor<T> Analyzer(string? analyzer) => Assign(analyzer, (a, v) => a.AnalyzerValue = v);
		public MatchBoolPrefixQueryDescriptor<T> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness) => Assign(fuzziness, (a, v) => a.FuzzinessValue = v);
		public MatchBoolPrefixQueryDescriptor<T> FuzzyRewrite(string? fuzzyRewrite) => Assign(fuzzyRewrite, (a, v) => a.FuzzyRewriteValue = v);
		public MatchBoolPrefixQueryDescriptor<T> FuzzyTranspositions(bool? fuzzyTranspositions = true) => Assign(fuzzyTranspositions, (a, v) => a.FuzzyTranspositionsValue = v);
		public MatchBoolPrefixQueryDescriptor<T> MaxExpansions(int? maxExpansions) => Assign(maxExpansions, (a, v) => a.MaxExpansionsValue = v);
		public MatchBoolPrefixQueryDescriptor<T> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch) => Assign(minimumShouldMatch, (a, v) => a.MinimumShouldMatchValue = v);
		public MatchBoolPrefixQueryDescriptor<T> Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? op) => Assign(op, (a, v) => a.OperatorValue = v);
		public MatchBoolPrefixQueryDescriptor<T> PrefixLength(int? prefixLength) => Assign(prefixLength, (a, v) => a.PrefixLengthValue = v);
		public MatchBoolPrefixQueryDescriptor<T> Query(string query) => Assign(query, (a, v) => a.QueryValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WritePropertyName(settings.Inferrer.Field(_field));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyRewriteValue is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, FuzzyRewriteValue, options);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (OperatorValue is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, OperatorValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			writer.WriteEndObject();
		}
	}
}