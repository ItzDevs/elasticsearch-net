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
namespace Elastic.Clients.Elasticsearch.IndexManagement.Analyze
{
	public partial class AnalyzeDetail
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Analyze.AnalyzerDetail? Analyzer { get; init; }

		[JsonInclude]
		[JsonPropertyName("charfilters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.Analyze.CharFilterDetail>? Charfilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("custom_analyzer")]
		public bool CustomAnalyzer { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenfilters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.Analyze.TokenDetail>? Tokenfilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Analyze.TokenDetail? Tokenizer { get; init; }
	}

	public partial class AnalyzerDetail
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public string Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokens")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.Analyze.ExplainAnalyzeToken> Tokens { get; init; }
	}

	public partial class AnalyzeToken
	{
		[JsonInclude]
		[JsonPropertyName("end_offset")]
		public object EndOffset { get; init; }

		[JsonInclude]
		[JsonPropertyName("position")]
		public object Position { get; init; }

		[JsonInclude]
		[JsonPropertyName("position_length")]
		public object? PositionLength { get; init; }

		[JsonInclude]
		[JsonPropertyName("start_offset")]
		public object StartOffset { get; init; }

		[JsonInclude]
		[JsonPropertyName("token")]
		public string Token { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type { get; init; }
	}

	public partial class CharFilterDetail
	{
		[JsonInclude]
		[JsonPropertyName("filtered_text")]
		public IReadOnlyCollection<string> FilteredText { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public string Name { get; init; }
	}

	public partial class ExplainAnalyzeToken
	{
		[JsonInclude]
		[JsonPropertyName("bytes")]
		public string Bytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("end_offset")]
		public object EndOffset { get; init; }

		[JsonInclude]
		[JsonPropertyName("keyword")]
		public bool? Keyword { get; init; }

		[JsonInclude]
		[JsonPropertyName("position")]
		public object Position { get; init; }

		[JsonInclude]
		[JsonPropertyName("positionLength")]
		public object Positionlength { get; init; }

		[JsonInclude]
		[JsonPropertyName("start_offset")]
		public object StartOffset { get; init; }

		[JsonInclude]
		[JsonPropertyName("termFrequency")]
		public object Termfrequency { get; init; }

		[JsonInclude]
		[JsonPropertyName("token")]
		public string Token { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type { get; init; }
	}

	public partial class TokenDetail
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public string Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokens")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.Analyze.ExplainAnalyzeToken> Tokens { get; init; }
	}
}