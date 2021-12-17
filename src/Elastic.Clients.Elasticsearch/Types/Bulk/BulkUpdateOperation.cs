// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

namespace Elastic.Clients.Elasticsearch;

public sealed class BulkUpdateOperation<TDocument, TPartialDocument> : BulkUpdateOperationBase
{
	public BulkUpdateOperation(Id id) => Id = id;

	public BulkUpdateOperation(TDocument idFrom, bool useIdFromAsUpsert = false)
	{
		IdFrom = idFrom;
		if (useIdFromAsUpsert)
			Upsert = idFrom;
	}

	public BulkUpdateOperation(TDocument idFrom, TPartialDocument update, bool useIdFromAsUpsert = false)
	{
		IdFrom = idFrom;
		if (useIdFromAsUpsert)
			Upsert = idFrom;
		Doc = update;
	}

	[JsonPropertyName("pipeline")]
	public string? Pipeline { get; set; }

	[JsonPropertyName("dynamic_templates")]
	public Dictionary<string, string>? DynamicTemplates { get; set; }

	[JsonIgnore]
	public TPartialDocument Doc { get; set; }

	[JsonIgnore]
	public TDocument IdFrom { get; set; }

	[JsonIgnore]
	public ScriptBase Script { get; set; }

	[JsonIgnore]
	public bool? ScriptedUpsert { get; set; }

	[JsonIgnore]
	public bool? DocAsUpsert { get; set; }

	[JsonIgnore]
	public TDocument Upsert { get; set; }

	protected override string Operation => "update";

	protected override void BeforeSerialize(IElasticsearchClientSettings settings)
	{
		//if (Id is null && IdFrom is not null)
		//	Id = settings.Inferrer.Id<TDocument>(IdFrom);

		//if (Index is null)
		//	Index = settings.Inferrer.IndexName<TDocument>();
	}

	protected override void WriteOperation(Utf8JsonWriter writer, JsonSerializerOptions options = null) => JsonSerializer.Serialize(writer, this, options);

	protected override object GetBody() => new BulkUpdateBody<TDocument, TPartialDocument> {
		PartialUpdate = Doc,
		Script = Script,
		Upsert = Upsert,
		DocAsUpsert = DocAsUpsert,
		ScriptedUpsert = ScriptedUpsert,
		IfPrimaryTerm = IfPrimaryTerm,
		IfSequenceNumber = IfSequenceNumber,
		//Source = Source
	};

	protected override Id GetIdForOperation(Inferrer inferrer) =>
		Id ?? new Id(new[] { IdFrom, Upsert }.FirstOrDefault(o => o != null));

	protected override Routing GetRoutingForOperation(Inferrer inferrer)
	{
		if (Routing != null)
			return Routing;

		if (IdFrom != null)
			return new Routing(IdFrom);

		if (Upsert != null)
			return new Routing(Upsert);

		return null;
	}
}

public static class BulkUpdateOperation
{
	public static BulkUpdateOperationWithPartial<TPartial> WithPartial<TPartial>(Id id, TPartial partialDocument) => new(id, partialDocument);

	public static BulkUpdateOperationWithPartial<TPartial> WithPartial<TPartial>(Id id, IndexName index, TPartial partialDocument) => new(id, index, partialDocument);

	public static BulkUpdateOperationWithScript WithScript(Id id, IndexName index, ScriptBase script) => new(id, index, script);
}
