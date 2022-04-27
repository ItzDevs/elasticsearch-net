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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class DataframeEvaluationMetrics
	{
		[JsonInclude]
		[JsonPropertyName("auc_roc")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationClassificationMetricsAucRoc? AucRoc { get; set; }

		[JsonInclude]
		[JsonPropertyName("precision")]
		public Dictionary<string, object>? Precision { get; set; }

		[JsonInclude]
		[JsonPropertyName("recall")]
		public Dictionary<string, object>? Recall { get; set; }
	}

	public sealed partial class DataframeEvaluationMetricsDescriptor : SerializableDescriptorBase<DataframeEvaluationMetricsDescriptor>
	{
		internal DataframeEvaluationMetricsDescriptor(Action<DataframeEvaluationMetricsDescriptor> configure) => configure.Invoke(this);
		public DataframeEvaluationMetricsDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationClassificationMetricsAucRoc? AucRocValue { get; set; }

		private DataframeEvaluationClassificationMetricsAucRocDescriptor AucRocDescriptor { get; set; }

		private Action<DataframeEvaluationClassificationMetricsAucRocDescriptor> AucRocDescriptorAction { get; set; }

		private Dictionary<string, object>? PrecisionValue { get; set; }

		private Dictionary<string, object>? RecallValue { get; set; }

		public DataframeEvaluationMetricsDescriptor AucRoc(Elastic.Clients.Elasticsearch.Ml.DataframeEvaluationClassificationMetricsAucRoc? aucRoc)
		{
			AucRocDescriptor = null;
			AucRocDescriptorAction = null;
			AucRocValue = aucRoc;
			return Self;
		}

		public DataframeEvaluationMetricsDescriptor AucRoc(DataframeEvaluationClassificationMetricsAucRocDescriptor descriptor)
		{
			AucRocValue = null;
			AucRocDescriptorAction = null;
			AucRocDescriptor = descriptor;
			return Self;
		}

		public DataframeEvaluationMetricsDescriptor AucRoc(Action<DataframeEvaluationClassificationMetricsAucRocDescriptor> configure)
		{
			AucRocValue = null;
			AucRocDescriptorAction = null;
			AucRocDescriptorAction = configure;
			return Self;
		}

		public DataframeEvaluationMetricsDescriptor Precision(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			PrecisionValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public DataframeEvaluationMetricsDescriptor Recall(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			RecallValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AucRocDescriptor is not null)
			{
				writer.WritePropertyName("auc_roc");
				JsonSerializer.Serialize(writer, AucRocDescriptor, options);
			}
			else if (AucRocDescriptorAction is not null)
			{
				writer.WritePropertyName("auc_roc");
				JsonSerializer.Serialize(writer, new DataframeEvaluationClassificationMetricsAucRocDescriptor(AucRocDescriptorAction), options);
			}
			else if (AucRocValue is not null)
			{
				writer.WritePropertyName("auc_roc");
				JsonSerializer.Serialize(writer, AucRocValue, options);
			}

			if (PrecisionValue is not null)
			{
				writer.WritePropertyName("precision");
				JsonSerializer.Serialize(writer, PrecisionValue, options);
			}

			if (RecallValue is not null)
			{
				writer.WritePropertyName("recall");
				JsonSerializer.Serialize(writer, RecallValue, options);
			}

			writer.WriteEndObject();
		}
	}
}