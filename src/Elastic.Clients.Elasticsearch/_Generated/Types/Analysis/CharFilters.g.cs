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
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis;
public partial class CharFilters : IsADictionary<string, ICharFilter>
{
	public CharFilters()
	{
	}

	public CharFilters(IDictionary<string, ICharFilter> container) : base(container)
	{
	}

	public void Add(string name, ICharFilter charFilter) => BackingDictionary.Add(Sanitize(name), charFilter);
	public bool TryGetCharFilter(string name, [NotNullWhen(returnValue: true)] out ICharFilter charFilter) => BackingDictionary.TryGetValue(Sanitize(name), out charFilter);
	public bool TryGetCharFilter<T>(string name, [NotNullWhen(returnValue: true)] out T? charFilter)
		where T : class, ICharFilter
	{
		if (BackingDictionary.TryGetValue(Sanitize(name), out var matchedValue) && matchedValue is T finalValue)
		{
			charFilter = finalValue;
			return true;
		}

		charFilter = null;
		return false;
	}
}

public sealed partial class CharFiltersDescriptor : IsADictionaryDescriptor<CharFiltersDescriptor, CharFilters, string, ICharFilter>
{
	public CharFiltersDescriptor() : base(new CharFilters())
	{
	}

	public CharFiltersDescriptor(CharFilters charFilters) : base(charFilters ?? new CharFilters())
	{
	}

	public CharFiltersDescriptor HtmlStrip(string charFilterName) => AssignVariant<HtmlStripCharFilterDescriptor, HtmlStripCharFilter>(charFilterName, null);
	public CharFiltersDescriptor HtmlStrip(string charFilterName, Action<HtmlStripCharFilterDescriptor> configure) => AssignVariant<HtmlStripCharFilterDescriptor, HtmlStripCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor HtmlStrip(string charFilterName, HtmlStripCharFilter htmlStripCharFilter) => AssignVariant(charFilterName, htmlStripCharFilter);
	public CharFiltersDescriptor IcuNormalization(string charFilterName) => AssignVariant<IcuNormalizationCharFilterDescriptor, IcuNormalizationCharFilter>(charFilterName, null);
	public CharFiltersDescriptor IcuNormalization(string charFilterName, Action<IcuNormalizationCharFilterDescriptor> configure) => AssignVariant<IcuNormalizationCharFilterDescriptor, IcuNormalizationCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor IcuNormalization(string charFilterName, IcuNormalizationCharFilter icuNormalizationCharFilter) => AssignVariant(charFilterName, icuNormalizationCharFilter);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName) => AssignVariant<KuromojiIterationMarkCharFilterDescriptor, KuromojiIterationMarkCharFilter>(charFilterName, null);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName, Action<KuromojiIterationMarkCharFilterDescriptor> configure) => AssignVariant<KuromojiIterationMarkCharFilterDescriptor, KuromojiIterationMarkCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName, KuromojiIterationMarkCharFilter kuromojiIterationMarkCharFilter) => AssignVariant(charFilterName, kuromojiIterationMarkCharFilter);
	public CharFiltersDescriptor Mapping(string charFilterName) => AssignVariant<MappingCharFilterDescriptor, MappingCharFilter>(charFilterName, null);
	public CharFiltersDescriptor Mapping(string charFilterName, Action<MappingCharFilterDescriptor> configure) => AssignVariant<MappingCharFilterDescriptor, MappingCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor Mapping(string charFilterName, MappingCharFilter mappingCharFilter) => AssignVariant(charFilterName, mappingCharFilter);
	public CharFiltersDescriptor PatternReplace(string charFilterName) => AssignVariant<PatternReplaceCharFilterDescriptor, PatternReplaceCharFilter>(charFilterName, null);
	public CharFiltersDescriptor PatternReplace(string charFilterName, Action<PatternReplaceCharFilterDescriptor> configure) => AssignVariant<PatternReplaceCharFilterDescriptor, PatternReplaceCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor PatternReplace(string charFilterName, PatternReplaceCharFilter patternReplaceCharFilter) => AssignVariant(charFilterName, patternReplaceCharFilter);
}

internal sealed partial class CharFilterInterfaceConverter : JsonConverter<ICharFilter>
{
	public override ICharFilter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var copiedReader = reader;
		string? type = null;
		using var jsonDoc = JsonDocument.ParseValue(ref copiedReader);
		if (jsonDoc is not null && jsonDoc.RootElement.TryGetProperty("type", out var readType) && readType.ValueKind == JsonValueKind.String)
		{
			type = readType.ToString();
		}

		switch (type)
		{
			case "kuromoji_iteration_mark":
				return JsonSerializer.Deserialize<KuromojiIterationMarkCharFilter>(ref reader, options);
			case "icu_normalizer":
				return JsonSerializer.Deserialize<IcuNormalizationCharFilter>(ref reader, options);
			case "pattern_replace":
				return JsonSerializer.Deserialize<PatternReplaceCharFilter>(ref reader, options);
			case "mapping":
				return JsonSerializer.Deserialize<MappingCharFilter>(ref reader, options);
			case "html_strip":
				return JsonSerializer.Deserialize<HtmlStripCharFilter>(ref reader, options);
			default:
				ThrowHelper.ThrowUnknownTaggedUnionVariantJsonException(type, typeof(ICharFilter));
				return null;
		}
	}

	public override void Write(Utf8JsonWriter writer, ICharFilter value, JsonSerializerOptions options)
	{
		if (value is null)
		{
			writer.WriteNullValue();
			return;
		}

		switch (value.Type)
		{
			case "kuromoji_iteration_mark":
				JsonSerializer.Serialize(writer, value, typeof(KuromojiIterationMarkCharFilter), options);
				return;
			case "icu_normalizer":
				JsonSerializer.Serialize(writer, value, typeof(IcuNormalizationCharFilter), options);
				return;
			case "pattern_replace":
				JsonSerializer.Serialize(writer, value, typeof(PatternReplaceCharFilter), options);
				return;
			case "mapping":
				JsonSerializer.Serialize(writer, value, typeof(MappingCharFilter), options);
				return;
			case "html_strip":
				JsonSerializer.Serialize(writer, value, typeof(HtmlStripCharFilter), options);
				return;
			default:
				var type = value.GetType();
				JsonSerializer.Serialize(writer, value, type, options);
				return;
		}
	}
}

[JsonConverter(typeof(CharFilterInterfaceConverter))]
public partial interface ICharFilter
{
	public string Type { get; }
}