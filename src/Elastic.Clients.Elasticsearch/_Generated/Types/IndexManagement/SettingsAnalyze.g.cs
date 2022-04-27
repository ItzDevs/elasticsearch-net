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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class SettingsAnalyze
	{
		[JsonInclude]
		[JsonPropertyName("max_token_count")]
		public int? MaxTokenCount { get; set; }
	}

	public sealed partial class SettingsAnalyzeDescriptor : SerializableDescriptorBase<SettingsAnalyzeDescriptor>
	{
		internal SettingsAnalyzeDescriptor(Action<SettingsAnalyzeDescriptor> configure) => configure.Invoke(this);
		public SettingsAnalyzeDescriptor() : base()
		{
		}

		private int? MaxTokenCountValue { get; set; }

		public SettingsAnalyzeDescriptor MaxTokenCount(int? maxTokenCount)
		{
			MaxTokenCountValue = maxTokenCount;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MaxTokenCountValue.HasValue)
			{
				writer.WritePropertyName("max_token_count");
				writer.WriteNumberValue(MaxTokenCountValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}