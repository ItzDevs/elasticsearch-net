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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	[JsonConverter(typeof(DataStreamHealthStatusConverter))]
	public enum DataStreamHealthStatus
	{
		Yellow,
		Red,
		Green
	}

	public class DataStreamHealthStatusConverter : JsonConverter<DataStreamHealthStatus>
	{
		public override DataStreamHealthStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "yellow":
					return DataStreamHealthStatus.Yellow;
				case "red":
					return DataStreamHealthStatus.Red;
				case "green":
					return DataStreamHealthStatus.Green;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, DataStreamHealthStatus value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case DataStreamHealthStatus.Yellow:
					writer.WriteStringValue("yellow");
					return;
				case DataStreamHealthStatus.Red:
					writer.WriteStringValue("red");
					return;
				case DataStreamHealthStatus.Green:
					writer.WriteStringValue("green");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexCheckOnStartupConverter))]
	public enum IndexCheckOnStartup
	{
		True,
		False,
		Checksum
	}

	public class IndexCheckOnStartupConverter : JsonConverter<IndexCheckOnStartup>
	{
		public override IndexCheckOnStartup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "true":
					return IndexCheckOnStartup.True;
				case "false":
					return IndexCheckOnStartup.False;
				case "checksum":
					return IndexCheckOnStartup.Checksum;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexCheckOnStartup value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexCheckOnStartup.True:
					writer.WriteStringValue("true");
					return;
				case IndexCheckOnStartup.False:
					writer.WriteStringValue("false");
					return;
				case IndexCheckOnStartup.Checksum:
					writer.WriteStringValue("checksum");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexRoutingAllocationOptionsConverter))]
	public enum IndexRoutingAllocationOptions
	{
		Primaries,
		None,
		NewPrimaries,
		All
	}

	public class IndexRoutingAllocationOptionsConverter : JsonConverter<IndexRoutingAllocationOptions>
	{
		public override IndexRoutingAllocationOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "primaries":
					return IndexRoutingAllocationOptions.Primaries;
				case "none":
					return IndexRoutingAllocationOptions.None;
				case "new_primaries":
					return IndexRoutingAllocationOptions.NewPrimaries;
				case "all":
					return IndexRoutingAllocationOptions.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexRoutingAllocationOptions value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexRoutingAllocationOptions.Primaries:
					writer.WriteStringValue("primaries");
					return;
				case IndexRoutingAllocationOptions.None:
					writer.WriteStringValue("none");
					return;
				case IndexRoutingAllocationOptions.NewPrimaries:
					writer.WriteStringValue("new_primaries");
					return;
				case IndexRoutingAllocationOptions.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexRoutingRebalanceOptionsConverter))]
	public enum IndexRoutingRebalanceOptions
	{
		Replicas,
		Primaries,
		None,
		All
	}

	public class IndexRoutingRebalanceOptionsConverter : JsonConverter<IndexRoutingRebalanceOptions>
	{
		public override IndexRoutingRebalanceOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "replicas":
					return IndexRoutingRebalanceOptions.Replicas;
				case "primaries":
					return IndexRoutingRebalanceOptions.Primaries;
				case "none":
					return IndexRoutingRebalanceOptions.None;
				case "all":
					return IndexRoutingRebalanceOptions.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexRoutingRebalanceOptions value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexRoutingRebalanceOptions.Replicas:
					writer.WriteStringValue("replicas");
					return;
				case IndexRoutingRebalanceOptions.Primaries:
					writer.WriteStringValue("primaries");
					return;
				case IndexRoutingRebalanceOptions.None:
					writer.WriteStringValue("none");
					return;
				case IndexRoutingRebalanceOptions.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(NumericFielddataFormatConverter))]
	public enum NumericFielddataFormat
	{
		Disabled,
		Array
	}

	public class NumericFielddataFormatConverter : JsonConverter<NumericFielddataFormat>
	{
		public override NumericFielddataFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "disabled":
					return NumericFielddataFormat.Disabled;
				case "array":
					return NumericFielddataFormat.Array;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, NumericFielddataFormat value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case NumericFielddataFormat.Disabled:
					writer.WriteStringValue("disabled");
					return;
				case NumericFielddataFormat.Array:
					writer.WriteStringValue("array");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(StringFielddataFormatConverter))]
	public enum StringFielddataFormat
	{
		PagedBytes,
		Disabled
	}

	public class StringFielddataFormatConverter : JsonConverter<StringFielddataFormat>
	{
		public override StringFielddataFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "paged_bytes":
					return StringFielddataFormat.PagedBytes;
				case "disabled":
					return StringFielddataFormat.Disabled;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, StringFielddataFormat value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case StringFielddataFormat.PagedBytes:
					writer.WriteStringValue("paged_bytes");
					return;
				case StringFielddataFormat.Disabled:
					writer.WriteStringValue("disabled");
					return;
			}

			writer.WriteNullValue();
		}
	}
}