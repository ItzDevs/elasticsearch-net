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
	public partial class FuzzyQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "fuzzy";
		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("rewrite")]
		public string? Rewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("transpositions")]
		public bool? Transpositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("value")]
		public object Value { get; set; }
	}

	public sealed partial class FuzzyQueryDescriptor<T> : FieldNameQueryDescriptorBase<FuzzyQueryDescriptor<T>, T>
	{
		public FuzzyQueryDescriptor()
		{
		}

		internal FuzzyQueryDescriptor(Action<FuzzyQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal int? MaxExpansionsValue { get; private set; }

		internal int? PrefixLengthValue { get; private set; }

		internal string? RewriteValue { get; private set; }

		internal bool? TranspositionsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; private set; }

		internal object ValueValue { get; private set; }

		public FuzzyQueryDescriptor<T> MaxExpansions(int? maxExpansions) => Assign(maxExpansions, (a, v) => a.MaxExpansionsValue = v);
		public FuzzyQueryDescriptor<T> PrefixLength(int? prefixLength) => Assign(prefixLength, (a, v) => a.PrefixLengthValue = v);
		public FuzzyQueryDescriptor<T> Rewrite(string? rewrite) => Assign(rewrite, (a, v) => a.RewriteValue = v);
		public FuzzyQueryDescriptor<T> Transpositions(bool? transpositions = true) => Assign(transpositions, (a, v) => a.TranspositionsValue = v);
		public FuzzyQueryDescriptor<T> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness) => Assign(fuzziness, (a, v) => a.FuzzinessValue = v);
		public FuzzyQueryDescriptor<T> Value(object value) => Assign(value, (a, v) => a.ValueValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WritePropertyName(settings.Inferrer.Field(_field));
			writer.WriteStartObject();
			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			if (RewriteValue is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, RewriteValue, options);
			}

			if (TranspositionsValue.HasValue)
			{
				writer.WritePropertyName("transpositions");
				writer.WriteBooleanValue(TranspositionsValue.Value);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueValue, options);
			writer.WriteEndObject();
		}
	}
}