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
	public partial class DataDescription
	{
		[JsonInclude]
		[JsonPropertyName("field_delimiter")]
		public string? FieldDelimiter { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_field")]
		public Elastic.Clients.Elasticsearch.Field? TimeField { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_format")]
		public string? TimeFormat { get; set; }
	}

	public sealed partial class DataDescriptionDescriptor<TDocument> : SerializableDescriptorBase<DataDescriptionDescriptor<TDocument>>
	{
		internal DataDescriptionDescriptor(Action<DataDescriptionDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DataDescriptionDescriptor() : base()
		{
		}

		private string? FieldDelimiterValue { get; set; }

		private string? FormatValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TimeFieldValue { get; set; }

		private string? TimeFormatValue { get; set; }

		public DataDescriptionDescriptor<TDocument> FieldDelimiter(string? fieldDelimiter)
		{
			FieldDelimiterValue = fieldDelimiter;
			return Self;
		}

		public DataDescriptionDescriptor<TDocument> Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public DataDescriptionDescriptor<TDocument> TimeField(Elastic.Clients.Elasticsearch.Field? timeField)
		{
			TimeFieldValue = timeField;
			return Self;
		}

		public DataDescriptionDescriptor<TDocument> TimeField<TValue>(Expression<Func<TDocument, TValue>> timeField)
		{
			TimeFieldValue = timeField;
			return Self;
		}

		public DataDescriptionDescriptor<TDocument> TimeFormat(string? timeFormat)
		{
			TimeFormatValue = timeFormat;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(FieldDelimiterValue))
			{
				writer.WritePropertyName("field_delimiter");
				writer.WriteStringValue(FieldDelimiterValue);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (TimeFieldValue is not null)
			{
				writer.WritePropertyName("time_field");
				JsonSerializer.Serialize(writer, TimeFieldValue, options);
			}

			if (!string.IsNullOrEmpty(TimeFormatValue))
			{
				writer.WritePropertyName("time_format");
				writer.WriteStringValue(TimeFormatValue);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class DataDescriptionDescriptor : SerializableDescriptorBase<DataDescriptionDescriptor>
	{
		internal DataDescriptionDescriptor(Action<DataDescriptionDescriptor> configure) => configure.Invoke(this);
		public DataDescriptionDescriptor() : base()
		{
		}

		private string? FieldDelimiterValue { get; set; }

		private string? FormatValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TimeFieldValue { get; set; }

		private string? TimeFormatValue { get; set; }

		public DataDescriptionDescriptor FieldDelimiter(string? fieldDelimiter)
		{
			FieldDelimiterValue = fieldDelimiter;
			return Self;
		}

		public DataDescriptionDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public DataDescriptionDescriptor TimeField(Elastic.Clients.Elasticsearch.Field? timeField)
		{
			TimeFieldValue = timeField;
			return Self;
		}

		public DataDescriptionDescriptor TimeField<TDocument, TValue>(Expression<Func<TDocument, TValue>> timeField)
		{
			TimeFieldValue = timeField;
			return Self;
		}

		public DataDescriptionDescriptor TimeField<TDocument>(Expression<Func<TDocument, object>> timeField)
		{
			TimeFieldValue = timeField;
			return Self;
		}

		public DataDescriptionDescriptor TimeFormat(string? timeFormat)
		{
			TimeFormatValue = timeFormat;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(FieldDelimiterValue))
			{
				writer.WritePropertyName("field_delimiter");
				writer.WriteStringValue(FieldDelimiterValue);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (TimeFieldValue is not null)
			{
				writer.WritePropertyName("time_field");
				JsonSerializer.Serialize(writer, TimeFieldValue, options);
			}

			if (!string.IsNullOrEmpty(TimeFormatValue))
			{
				writer.WritePropertyName("time_format");
				writer.WriteStringValue(TimeFormatValue);
			}

			writer.WriteEndObject();
		}
	}
}