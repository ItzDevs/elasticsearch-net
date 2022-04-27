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
	public partial class QueryStringQuery : QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "query_string";
		[JsonInclude]
		[JsonPropertyName("allow_leading_wildcard")]
		public bool? AllowLeadingWildcard { get; set; }

		[JsonInclude]
		[JsonPropertyName("analyze_wildcard")]
		public bool? AnalyzeWildcard { get; set; }

		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("default_field")]
		public Elastic.Clients.Elasticsearch.Field? DefaultField { get; set; }

		[JsonInclude]
		[JsonPropertyName("default_operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get; set; }

		[JsonInclude]
		[JsonPropertyName("enable_position_increments")]
		public bool? EnablePositionIncrements { get; set; }

		[JsonInclude]
		[JsonPropertyName("escape")]
		public bool? Escape { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Field>? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_max_expansions")]
		public int? FuzzyMaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_prefix_length")]
		public int? FuzzyPrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public string? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_determinized_states")]
		public int? MaxDeterminizedStates { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("phrase_slop")]
		public double? PhraseSlop { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("quote_analyzer")]
		public string? QuoteAnalyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("quote_field_suffix")]
		public string? QuoteFieldSuffix { get; set; }

		[JsonInclude]
		[JsonPropertyName("rewrite")]
		public string? Rewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("tie_breaker")]
		public double? TieBreaker { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_zone")]
		public string? TimeZone { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? Type { get; set; }
	}

	public sealed partial class QueryStringQueryDescriptor<TDocument> : SerializableDescriptorBase<QueryStringQueryDescriptor<TDocument>>
	{
		internal QueryStringQueryDescriptor(Action<QueryStringQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public QueryStringQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private bool? AllowLeadingWildcardValue { get; set; }

		private bool? AnalyzeWildcardValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? DefaultFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperatorValue { get; set; }

		private bool? EnablePositionIncrementsValue { get; set; }

		private bool? EscapeValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Field>? FieldsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private int? FuzzyMaxExpansionsValue { get; set; }

		private int? FuzzyPrefixLengthValue { get; set; }

		private string? FuzzyRewriteValue { get; set; }

		private bool? FuzzyTranspositionsValue { get; set; }

		private bool? LenientValue { get; set; }

		private int? MaxDeterminizedStatesValue { get; set; }

		private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

		private double? PhraseSlopValue { get; set; }

		private string QueryValue { get; set; }

		private string? QuoteAnalyzerValue { get; set; }

		private string? QuoteFieldSuffixValue { get; set; }

		private string? RewriteValue { get; set; }

		private double? TieBreakerValue { get; set; }

		private string? TimeZoneValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? TypeValue { get; set; }

		public QueryStringQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> AllowLeadingWildcard(bool? allowLeadingWildcard = true)
		{
			AllowLeadingWildcardValue = allowLeadingWildcard;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> AnalyzeWildcard(bool? analyzeWildcard = true)
		{
			AnalyzeWildcardValue = analyzeWildcard;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
		{
			AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> DefaultField(Elastic.Clients.Elasticsearch.Field? defaultField)
		{
			DefaultFieldValue = defaultField;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> DefaultField<TValue>(Expression<Func<TDocument, TValue>> defaultField)
		{
			DefaultFieldValue = defaultField;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator)
		{
			DefaultOperatorValue = defaultOperator;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> EnablePositionIncrements(bool? enablePositionIncrements = true)
		{
			EnablePositionIncrementsValue = enablePositionIncrements;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Escape(bool? escape = true)
		{
			EscapeValue = escape;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Fields(IEnumerable<Elastic.Clients.Elasticsearch.Field>? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> FuzzyMaxExpansions(int? fuzzyMaxExpansions)
		{
			FuzzyMaxExpansionsValue = fuzzyMaxExpansions;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> FuzzyPrefixLength(int? fuzzyPrefixLength)
		{
			FuzzyPrefixLengthValue = fuzzyPrefixLength;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite)
		{
			FuzzyRewriteValue = fuzzyRewrite;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true)
		{
			FuzzyTranspositionsValue = fuzzyTranspositions;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Lenient(bool? lenient = true)
		{
			LenientValue = lenient;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> MaxDeterminizedStates(int? maxDeterminizedStates)
		{
			MaxDeterminizedStatesValue = maxDeterminizedStates;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
		{
			MinimumShouldMatchValue = minimumShouldMatch;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> PhraseSlop(double? phraseSlop)
		{
			PhraseSlopValue = phraseSlop;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> QuoteAnalyzer(string? quoteAnalyzer)
		{
			QuoteAnalyzerValue = quoteAnalyzer;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> QuoteFieldSuffix(string? quoteFieldSuffix)
		{
			QuoteFieldSuffixValue = quoteFieldSuffix;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Rewrite(string? rewrite)
		{
			RewriteValue = rewrite;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> TieBreaker(double? tieBreaker)
		{
			TieBreakerValue = tieBreaker;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> TimeZone(string? timeZone)
		{
			TimeZoneValue = timeZone;
			return Self;
		}

		public QueryStringQueryDescriptor<TDocument> Type(Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? type)
		{
			TypeValue = type;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (AllowLeadingWildcardValue.HasValue)
			{
				writer.WritePropertyName("allow_leading_wildcard");
				writer.WriteBooleanValue(AllowLeadingWildcardValue.Value);
			}

			if (AnalyzeWildcardValue.HasValue)
			{
				writer.WritePropertyName("analyze_wildcard");
				writer.WriteBooleanValue(AnalyzeWildcardValue.Value);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (DefaultFieldValue is not null)
			{
				writer.WritePropertyName("default_field");
				JsonSerializer.Serialize(writer, DefaultFieldValue, options);
			}

			if (DefaultOperatorValue is not null)
			{
				writer.WritePropertyName("default_operator");
				JsonSerializer.Serialize(writer, DefaultOperatorValue, options);
			}

			if (EnablePositionIncrementsValue.HasValue)
			{
				writer.WritePropertyName("enable_position_increments");
				writer.WriteBooleanValue(EnablePositionIncrementsValue.Value);
			}

			if (EscapeValue.HasValue)
			{
				writer.WritePropertyName("escape");
				writer.WriteBooleanValue(EscapeValue.Value);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyMaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_max_expansions");
				writer.WriteNumberValue(FuzzyMaxExpansionsValue.Value);
			}

			if (FuzzyPrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_prefix_length");
				writer.WriteNumberValue(FuzzyPrefixLengthValue.Value);
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

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MaxDeterminizedStatesValue.HasValue)
			{
				writer.WritePropertyName("max_determinized_states");
				writer.WriteNumberValue(MaxDeterminizedStatesValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (PhraseSlopValue.HasValue)
			{
				writer.WritePropertyName("phrase_slop");
				writer.WriteNumberValue(PhraseSlopValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (!string.IsNullOrEmpty(QuoteAnalyzerValue))
			{
				writer.WritePropertyName("quote_analyzer");
				writer.WriteStringValue(QuoteAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(QuoteFieldSuffixValue))
			{
				writer.WritePropertyName("quote_field_suffix");
				writer.WriteStringValue(QuoteFieldSuffixValue);
			}

			if (RewriteValue is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, RewriteValue, options);
			}

			if (TieBreakerValue.HasValue)
			{
				writer.WritePropertyName("tie_breaker");
				writer.WriteNumberValue(TieBreakerValue.Value);
			}

			if (TimeZoneValue is not null)
			{
				writer.WritePropertyName("time_zone");
				JsonSerializer.Serialize(writer, TimeZoneValue, options);
			}

			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class QueryStringQueryDescriptor : SerializableDescriptorBase<QueryStringQueryDescriptor>
	{
		internal QueryStringQueryDescriptor(Action<QueryStringQueryDescriptor> configure) => configure.Invoke(this);
		public QueryStringQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private bool? AllowLeadingWildcardValue { get; set; }

		private bool? AnalyzeWildcardValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? DefaultFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperatorValue { get; set; }

		private bool? EnablePositionIncrementsValue { get; set; }

		private bool? EscapeValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Field>? FieldsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private int? FuzzyMaxExpansionsValue { get; set; }

		private int? FuzzyPrefixLengthValue { get; set; }

		private string? FuzzyRewriteValue { get; set; }

		private bool? FuzzyTranspositionsValue { get; set; }

		private bool? LenientValue { get; set; }

		private int? MaxDeterminizedStatesValue { get; set; }

		private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

		private double? PhraseSlopValue { get; set; }

		private string QueryValue { get; set; }

		private string? QuoteAnalyzerValue { get; set; }

		private string? QuoteFieldSuffixValue { get; set; }

		private string? RewriteValue { get; set; }

		private double? TieBreakerValue { get; set; }

		private string? TimeZoneValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? TypeValue { get; set; }

		public QueryStringQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public QueryStringQueryDescriptor AllowLeadingWildcard(bool? allowLeadingWildcard = true)
		{
			AllowLeadingWildcardValue = allowLeadingWildcard;
			return Self;
		}

		public QueryStringQueryDescriptor AnalyzeWildcard(bool? analyzeWildcard = true)
		{
			AnalyzeWildcardValue = analyzeWildcard;
			return Self;
		}

		public QueryStringQueryDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public QueryStringQueryDescriptor AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
		{
			AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
			return Self;
		}

		public QueryStringQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public QueryStringQueryDescriptor DefaultField(Elastic.Clients.Elasticsearch.Field? defaultField)
		{
			DefaultFieldValue = defaultField;
			return Self;
		}

		public QueryStringQueryDescriptor DefaultField<TDocument, TValue>(Expression<Func<TDocument, TValue>> defaultField)
		{
			DefaultFieldValue = defaultField;
			return Self;
		}

		public QueryStringQueryDescriptor DefaultField<TDocument>(Expression<Func<TDocument, object>> defaultField)
		{
			DefaultFieldValue = defaultField;
			return Self;
		}

		public QueryStringQueryDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator)
		{
			DefaultOperatorValue = defaultOperator;
			return Self;
		}

		public QueryStringQueryDescriptor EnablePositionIncrements(bool? enablePositionIncrements = true)
		{
			EnablePositionIncrementsValue = enablePositionIncrements;
			return Self;
		}

		public QueryStringQueryDescriptor Escape(bool? escape = true)
		{
			EscapeValue = escape;
			return Self;
		}

		public QueryStringQueryDescriptor Fields(IEnumerable<Elastic.Clients.Elasticsearch.Field>? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public QueryStringQueryDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public QueryStringQueryDescriptor FuzzyMaxExpansions(int? fuzzyMaxExpansions)
		{
			FuzzyMaxExpansionsValue = fuzzyMaxExpansions;
			return Self;
		}

		public QueryStringQueryDescriptor FuzzyPrefixLength(int? fuzzyPrefixLength)
		{
			FuzzyPrefixLengthValue = fuzzyPrefixLength;
			return Self;
		}

		public QueryStringQueryDescriptor FuzzyRewrite(string? fuzzyRewrite)
		{
			FuzzyRewriteValue = fuzzyRewrite;
			return Self;
		}

		public QueryStringQueryDescriptor FuzzyTranspositions(bool? fuzzyTranspositions = true)
		{
			FuzzyTranspositionsValue = fuzzyTranspositions;
			return Self;
		}

		public QueryStringQueryDescriptor Lenient(bool? lenient = true)
		{
			LenientValue = lenient;
			return Self;
		}

		public QueryStringQueryDescriptor MaxDeterminizedStates(int? maxDeterminizedStates)
		{
			MaxDeterminizedStatesValue = maxDeterminizedStates;
			return Self;
		}

		public QueryStringQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
		{
			MinimumShouldMatchValue = minimumShouldMatch;
			return Self;
		}

		public QueryStringQueryDescriptor PhraseSlop(double? phraseSlop)
		{
			PhraseSlopValue = phraseSlop;
			return Self;
		}

		public QueryStringQueryDescriptor Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public QueryStringQueryDescriptor QuoteAnalyzer(string? quoteAnalyzer)
		{
			QuoteAnalyzerValue = quoteAnalyzer;
			return Self;
		}

		public QueryStringQueryDescriptor QuoteFieldSuffix(string? quoteFieldSuffix)
		{
			QuoteFieldSuffixValue = quoteFieldSuffix;
			return Self;
		}

		public QueryStringQueryDescriptor Rewrite(string? rewrite)
		{
			RewriteValue = rewrite;
			return Self;
		}

		public QueryStringQueryDescriptor TieBreaker(double? tieBreaker)
		{
			TieBreakerValue = tieBreaker;
			return Self;
		}

		public QueryStringQueryDescriptor TimeZone(string? timeZone)
		{
			TimeZoneValue = timeZone;
			return Self;
		}

		public QueryStringQueryDescriptor Type(Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? type)
		{
			TypeValue = type;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (AllowLeadingWildcardValue.HasValue)
			{
				writer.WritePropertyName("allow_leading_wildcard");
				writer.WriteBooleanValue(AllowLeadingWildcardValue.Value);
			}

			if (AnalyzeWildcardValue.HasValue)
			{
				writer.WritePropertyName("analyze_wildcard");
				writer.WriteBooleanValue(AnalyzeWildcardValue.Value);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (DefaultFieldValue is not null)
			{
				writer.WritePropertyName("default_field");
				JsonSerializer.Serialize(writer, DefaultFieldValue, options);
			}

			if (DefaultOperatorValue is not null)
			{
				writer.WritePropertyName("default_operator");
				JsonSerializer.Serialize(writer, DefaultOperatorValue, options);
			}

			if (EnablePositionIncrementsValue.HasValue)
			{
				writer.WritePropertyName("enable_position_increments");
				writer.WriteBooleanValue(EnablePositionIncrementsValue.Value);
			}

			if (EscapeValue.HasValue)
			{
				writer.WritePropertyName("escape");
				writer.WriteBooleanValue(EscapeValue.Value);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyMaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_max_expansions");
				writer.WriteNumberValue(FuzzyMaxExpansionsValue.Value);
			}

			if (FuzzyPrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_prefix_length");
				writer.WriteNumberValue(FuzzyPrefixLengthValue.Value);
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

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MaxDeterminizedStatesValue.HasValue)
			{
				writer.WritePropertyName("max_determinized_states");
				writer.WriteNumberValue(MaxDeterminizedStatesValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (PhraseSlopValue.HasValue)
			{
				writer.WritePropertyName("phrase_slop");
				writer.WriteNumberValue(PhraseSlopValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (!string.IsNullOrEmpty(QuoteAnalyzerValue))
			{
				writer.WritePropertyName("quote_analyzer");
				writer.WriteStringValue(QuoteAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(QuoteFieldSuffixValue))
			{
				writer.WritePropertyName("quote_field_suffix");
				writer.WriteStringValue(QuoteFieldSuffixValue);
			}

			if (RewriteValue is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, RewriteValue, options);
			}

			if (TieBreakerValue.HasValue)
			{
				writer.WritePropertyName("tie_breaker");
				writer.WriteNumberValue(TieBreakerValue.Value);
			}

			if (TimeZoneValue is not null)
			{
				writer.WritePropertyName("time_zone");
				JsonSerializer.Serialize(writer, TimeZoneValue, options);
			}

			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}