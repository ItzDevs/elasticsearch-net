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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class WeightedAverageValue
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public double? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public ScriptBase? Script { get; set; }
	}

	public sealed partial class WeightedAverageValueDescriptor<TDocument> : SerializableDescriptorBase<WeightedAverageValueDescriptor<TDocument>>
	{
		internal WeightedAverageValueDescriptor(Action<WeightedAverageValueDescriptor<TDocument>> configure) => configure.Invoke(this);
		public WeightedAverageValueDescriptor() : base()
		{
		}

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private double? MissingValue { get; set; }

		public WeightedAverageValueDescriptor<TDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public WeightedAverageValueDescriptor<TDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public WeightedAverageValueDescriptor<TDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public WeightedAverageValueDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public WeightedAverageValueDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public WeightedAverageValueDescriptor<TDocument> Missing(double? missing)
		{
			MissingValue = missing;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(MissingValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class WeightedAverageValueDescriptor : SerializableDescriptorBase<WeightedAverageValueDescriptor>
	{
		internal WeightedAverageValueDescriptor(Action<WeightedAverageValueDescriptor> configure) => configure.Invoke(this);
		public WeightedAverageValueDescriptor() : base()
		{
		}

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private double? MissingValue { get; set; }

		public WeightedAverageValueDescriptor Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public WeightedAverageValueDescriptor Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public WeightedAverageValueDescriptor Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public WeightedAverageValueDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public WeightedAverageValueDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public WeightedAverageValueDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public WeightedAverageValueDescriptor Missing(double? missing)
		{
			MissingValue = missing;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(MissingValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}