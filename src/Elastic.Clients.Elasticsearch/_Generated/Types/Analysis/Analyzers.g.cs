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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class Analyzers : IsADictionaryBase<string, IAnalyzer>
	{
		public Analyzers()
		{
		}

		public Analyzers(IDictionary<string, IAnalyzer> container) : base(container)
		{
		}

		public void Add(string name, IAnalyzer analyzers) => BackingDictionary.Add(name, analyzers);
	}

	internal sealed partial class AnalyzerInterfaceConverter
	{
		private static IAnalyzer DeserializeVariant(string type, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			switch (type)
			{
				case "dutch":
					return JsonSerializer.Deserialize<DutchAnalyzer>(ref reader, options);
				case "snowball":
					return JsonSerializer.Deserialize<SnowballAnalyzer>(ref reader, options);
				case "kuromoji":
					return JsonSerializer.Deserialize<KuromojiAnalyzer>(ref reader, options);
				case "icu_analyzer":
					return JsonSerializer.Deserialize<IcuAnalyzer>(ref reader, options);
				case "whitespace":
					return JsonSerializer.Deserialize<WhitespaceAnalyzer>(ref reader, options);
				case "stop":
					return JsonSerializer.Deserialize<StopAnalyzer>(ref reader, options);
				case "standard":
					return JsonSerializer.Deserialize<StandardAnalyzer>(ref reader, options);
				case "simple":
					return JsonSerializer.Deserialize<SimpleAnalyzer>(ref reader, options);
				case "pattern":
					return JsonSerializer.Deserialize<PatternAnalyzer>(ref reader, options);
				case "nori":
					return JsonSerializer.Deserialize<NoriAnalyzer>(ref reader, options);
				case "language":
					return JsonSerializer.Deserialize<LanguageAnalyzer>(ref reader, options);
				case "keyword":
					return JsonSerializer.Deserialize<KeywordAnalyzer>(ref reader, options);
				case "fingerprint":
					return JsonSerializer.Deserialize<FingerprintAnalyzer>(ref reader, options);
				case "custom":
					return JsonSerializer.Deserialize<CustomAnalyzer>(ref reader, options);
				default:
					throw new JsonException("Encounted an unknown variant type which could not be deserialised.");
			}
		}
	}

	public partial interface IAnalyzer
	{
		public string Type { get; }
	}
}