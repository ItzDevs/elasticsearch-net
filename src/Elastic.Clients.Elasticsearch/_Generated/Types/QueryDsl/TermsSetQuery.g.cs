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
	internal sealed class TermsSetQueryConverter : FieldNameQueryConverterBase<TermsSetQuery>
	{
		internal override TermsSetQuery ReadInternal(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new TermsSetQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "minimum_should_match_field")
					{
						variant.MinimumShouldMatchField = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						continue;
					}

					if (property == "minimum_should_match_script")
					{
						variant.MinimumShouldMatchScript = JsonSerializer.Deserialize<ScriptBase?>(ref reader, options);
						continue;
					}

					if (property == "terms")
					{
						variant.Terms = JsonSerializer.Deserialize<IEnumerable<string>>(ref reader, options);
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

		internal override void WriteInternal(Utf8JsonWriter writer, TermsSetQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.MinimumShouldMatchField is not null)
			{
				writer.WritePropertyName("minimum_should_match_field");
				JsonSerializer.Serialize(writer, value.MinimumShouldMatchField, options);
			}

			if (value.MinimumShouldMatchScript is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, value.MinimumShouldMatchScript, options);
			}

			writer.WritePropertyName("terms");
			JsonSerializer.Serialize(writer, value.Terms, options);
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

	[JsonConverter(typeof(TermsSetQueryConverter))]
	public partial class TermsSetQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "terms_set";
		[JsonInclude]
		[JsonPropertyName("minimum_should_match_field")]
		public Elastic.Clients.Elasticsearch.Field? MinimumShouldMatchField { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match_script")]
		public ScriptBase? MinimumShouldMatchScript { get; set; }

		[JsonInclude]
		[JsonPropertyName("terms")]
		public IEnumerable<string> Terms { get; set; }
	}

	public sealed partial class TermsSetQueryDescriptor<TDocument> : SerializableDescriptorBase<TermsSetQueryDescriptor<TDocument>>
	{
		internal TermsSetQueryDescriptor(Action<TermsSetQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public TermsSetQueryDescriptor() : base()
		{
		}

		private ScriptBase? MinimumShouldMatchScriptValue { get; set; }

		private ScriptDescriptor MinimumShouldMatchScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> MinimumShouldMatchScriptDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? MinimumShouldMatchFieldValue { get; set; }

		private IEnumerable<string> TermsValue { get; set; }

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchScript(ScriptBase? minimumShouldMatchScript)
		{
			MinimumShouldMatchScriptDescriptor = null;
			MinimumShouldMatchScriptDescriptorAction = null;
			MinimumShouldMatchScriptValue = minimumShouldMatchScript;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchScript(ScriptDescriptor descriptor)
		{
			MinimumShouldMatchScriptValue = null;
			MinimumShouldMatchScriptDescriptorAction = null;
			MinimumShouldMatchScriptDescriptor = descriptor;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchScript(Action<ScriptDescriptor> configure)
		{
			MinimumShouldMatchScriptValue = null;
			MinimumShouldMatchScriptDescriptorAction = null;
			MinimumShouldMatchScriptDescriptorAction = configure;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchField(Elastic.Clients.Elasticsearch.Field? minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchField<TValue>(Expression<Func<TDocument, TValue>> minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Terms(IEnumerable<string> terms)
		{
			TermsValue = terms;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (MinimumShouldMatchScriptDescriptor is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, MinimumShouldMatchScriptDescriptor, options);
			}
			else if (MinimumShouldMatchScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(MinimumShouldMatchScriptDescriptorAction), options);
			}
			else if (MinimumShouldMatchScriptValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, MinimumShouldMatchScriptValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (MinimumShouldMatchFieldValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_field");
				JsonSerializer.Serialize(writer, MinimumShouldMatchFieldValue, options);
			}

			writer.WritePropertyName("terms");
			JsonSerializer.Serialize(writer, TermsValue, options);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}

	public sealed partial class TermsSetQueryDescriptor : SerializableDescriptorBase<TermsSetQueryDescriptor>
	{
		internal TermsSetQueryDescriptor(Action<TermsSetQueryDescriptor> configure) => configure.Invoke(this);
		public TermsSetQueryDescriptor() : base()
		{
		}

		private ScriptBase? MinimumShouldMatchScriptValue { get; set; }

		private ScriptDescriptor MinimumShouldMatchScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> MinimumShouldMatchScriptDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? MinimumShouldMatchFieldValue { get; set; }

		private IEnumerable<string> TermsValue { get; set; }

		public TermsSetQueryDescriptor MinimumShouldMatchScript(ScriptBase? minimumShouldMatchScript)
		{
			MinimumShouldMatchScriptDescriptor = null;
			MinimumShouldMatchScriptDescriptorAction = null;
			MinimumShouldMatchScriptValue = minimumShouldMatchScript;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchScript(ScriptDescriptor descriptor)
		{
			MinimumShouldMatchScriptValue = null;
			MinimumShouldMatchScriptDescriptorAction = null;
			MinimumShouldMatchScriptDescriptor = descriptor;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchScript(Action<ScriptDescriptor> configure)
		{
			MinimumShouldMatchScriptValue = null;
			MinimumShouldMatchScriptDescriptorAction = null;
			MinimumShouldMatchScriptDescriptorAction = configure;
			return Self;
		}

		public TermsSetQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public TermsSetQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TermsSetQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchField(Elastic.Clients.Elasticsearch.Field? minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchField<TDocument, TValue>(Expression<Func<TDocument, TValue>> minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchField<TDocument>(Expression<Func<TDocument, object>> minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor Terms(IEnumerable<string> terms)
		{
			TermsValue = terms;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (MinimumShouldMatchScriptDescriptor is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, MinimumShouldMatchScriptDescriptor, options);
			}
			else if (MinimumShouldMatchScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(MinimumShouldMatchScriptDescriptorAction), options);
			}
			else if (MinimumShouldMatchScriptValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, MinimumShouldMatchScriptValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (MinimumShouldMatchFieldValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_field");
				JsonSerializer.Serialize(writer, MinimumShouldMatchFieldValue, options);
			}

			writer.WritePropertyName("terms");
			JsonSerializer.Serialize(writer, TermsValue, options);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}
}