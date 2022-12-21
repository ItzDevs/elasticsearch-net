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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Core.Search;
public sealed partial class RescoreQuery
{
	[JsonInclude]
	[JsonPropertyName("query_weight")]
	public double? QueryWeight { get; set; }

	[JsonInclude]
	[JsonPropertyName("rescore_query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query Query { get; set; }

	[JsonInclude]
	[JsonPropertyName("rescore_query_weight")]
	public double? RescoreQueryWeight { get; set; }

	[JsonInclude]
	[JsonPropertyName("score_mode")]
	public Elastic.Clients.Elasticsearch.Core.Search.ScoreMode? ScoreMode { get; set; }
}

public sealed partial class RescoreQueryDescriptor<TDocument> : SerializableDescriptor<RescoreQueryDescriptor<TDocument>>
{
	internal RescoreQueryDescriptor(Action<RescoreQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public RescoreQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query QueryValue { get; set; }

	private QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }

	private double? QueryWeightValue { get; set; }

	private double? RescoreQueryWeightValue { get; set; }

	private Elastic.Clients.Elasticsearch.Core.Search.ScoreMode? ScoreModeValue { get; set; }

	public RescoreQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public RescoreQueryDescriptor<TDocument> Query(QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public RescoreQueryDescriptor<TDocument> Query(Action<QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public RescoreQueryDescriptor<TDocument> QueryWeight(double? queryWeight)
	{
		QueryWeightValue = queryWeight;
		return Self;
	}

	public RescoreQueryDescriptor<TDocument> RescoreQueryWeight(double? rescoreQueryWeight)
	{
		RescoreQueryWeightValue = rescoreQueryWeight;
		return Self;
	}

	public RescoreQueryDescriptor<TDocument> ScoreMode(Elastic.Clients.Elasticsearch.Core.Search.ScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("rescore_query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("rescore_query");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("rescore_query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (QueryWeightValue.HasValue)
		{
			writer.WritePropertyName("query_weight");
			writer.WriteNumberValue(QueryWeightValue.Value);
		}

		if (RescoreQueryWeightValue.HasValue)
		{
			writer.WritePropertyName("rescore_query_weight");
			writer.WriteNumberValue(RescoreQueryWeightValue.Value);
		}

		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RescoreQueryDescriptor : SerializableDescriptor<RescoreQueryDescriptor>
{
	internal RescoreQueryDescriptor(Action<RescoreQueryDescriptor> configure) => configure.Invoke(this);
	public RescoreQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query QueryValue { get; set; }

	private QueryDsl.QueryDescriptor QueryDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }

	private double? QueryWeightValue { get; set; }

	private double? RescoreQueryWeightValue { get; set; }

	private Elastic.Clients.Elasticsearch.Core.Search.ScoreMode? ScoreModeValue { get; set; }

	public RescoreQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public RescoreQueryDescriptor Query(QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public RescoreQueryDescriptor Query(Action<QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public RescoreQueryDescriptor QueryWeight(double? queryWeight)
	{
		QueryWeightValue = queryWeight;
		return Self;
	}

	public RescoreQueryDescriptor RescoreQueryWeight(double? rescoreQueryWeight)
	{
		RescoreQueryWeightValue = rescoreQueryWeight;
		return Self;
	}

	public RescoreQueryDescriptor ScoreMode(Elastic.Clients.Elasticsearch.Core.Search.ScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("rescore_query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("rescore_query");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("rescore_query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (QueryWeightValue.HasValue)
		{
			writer.WritePropertyName("query_weight");
			writer.WriteNumberValue(QueryWeightValue.Value);
		}

		if (RescoreQueryWeightValue.HasValue)
		{
			writer.WritePropertyName("rescore_query_weight");
			writer.WriteNumberValue(RescoreQueryWeightValue.Value);
		}

		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WriteEndObject();
	}
}