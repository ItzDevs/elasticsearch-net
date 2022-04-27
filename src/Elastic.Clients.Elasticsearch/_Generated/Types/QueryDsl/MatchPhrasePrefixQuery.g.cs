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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	internal sealed class MatchPhrasePrefixQueryConverter : FieldNameQueryConverterBase<MatchPhrasePrefixQuery>
	{
		internal override MatchPhrasePrefixQuery ReadInternal(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new MatchPhrasePrefixQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "analyzer")
					{
						variant.Analyzer = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "max_expansions")
					{
						variant.MaxExpansions = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "query")
					{
						variant.Query = JsonSerializer.Deserialize<string>(ref reader, options);
						continue;
					}

					if (property == "slop")
					{
						variant.Slop = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "zero_terms_query")
					{
						variant.ZeroTermsQuery = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery?>(ref reader, options);
						continue;
					}

					if (property == "_name")
					{
						variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "boost")
					{
						variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			return variant;
		}

		internal override void WriteInternal(Utf8JsonWriter writer, MatchPhrasePrefixQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.Analyzer))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(value.Analyzer);
			}

			if (value.MaxExpansions.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(value.MaxExpansions.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(value.Query);
			if (value.Slop.HasValue)
			{
				writer.WritePropertyName("slop");
				writer.WriteNumberValue(value.Slop.Value);
			}

			if (value.ZeroTermsQuery is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, value.ZeroTermsQuery, options);
			}

			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(MatchPhrasePrefixQueryConverter))]
	public partial class MatchPhrasePrefixQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "match_phrase_prefix";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

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

	public sealed partial class MatchPhrasePrefixQueryDescriptor<TDocument> : SerializableDescriptorBase<MatchPhrasePrefixQueryDescriptor<TDocument>>
	{
		internal MatchPhrasePrefixQueryDescriptor(Action<MatchPhrasePrefixQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MatchPhrasePrefixQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private int? MaxExpansionsValue { get; set; }

		private string QueryValue { get; set; }

		private int? SlopValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

		public MatchPhrasePrefixQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions)
		{
			MaxExpansionsValue = maxExpansions;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> Slop(int? slop)
		{
			SlopValue = slop;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor<TDocument> ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
		{
			ZeroTermsQueryValue = zeroTermsQuery;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
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
			writer.WriteEndObject();
		}
	}

	public sealed partial class MatchPhrasePrefixQueryDescriptor : SerializableDescriptorBase<MatchPhrasePrefixQueryDescriptor>
	{
		internal MatchPhrasePrefixQueryDescriptor(Action<MatchPhrasePrefixQueryDescriptor> configure) => configure.Invoke(this);
		public MatchPhrasePrefixQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private int? MaxExpansionsValue { get; set; }

		private string QueryValue { get; set; }

		private int? SlopValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

		public MatchPhrasePrefixQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor MaxExpansions(int? maxExpansions)
		{
			MaxExpansionsValue = maxExpansions;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor Slop(int? slop)
		{
			SlopValue = slop;
			return Self;
		}

		public MatchPhrasePrefixQueryDescriptor ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
		{
			ZeroTermsQueryValue = zeroTermsQuery;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
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
			writer.WriteEndObject();
		}
	}
}