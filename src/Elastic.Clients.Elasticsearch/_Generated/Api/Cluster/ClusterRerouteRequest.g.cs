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
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public class ClusterRerouteRequestParameters : RequestParameters<ClusterRerouteRequestParameters>
	{
		[JsonIgnore]
		public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Metrics? Metric { get => Q<Elastic.Clients.Elasticsearch.Metrics?>("metric"); set => Q("metric", value); }

		[JsonIgnore]
		public bool? RetryFailed { get => Q<bool?>("retry_failed"); set => Q("retry_failed", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	[InterfaceConverterAttribute(typeof(ClusterRerouteRequestDescriptorConverter<ClusterRerouteRequest>))]
	public partial interface IClusterRerouteRequest : IRequest<ClusterRerouteRequestParameters>
	{
		IEnumerable<Cluster.Reroute.ICommand>? Commands { get; set; }
	}

	public partial class ClusterRerouteRequest : PlainRequestBase<ClusterRerouteRequestParameters>, IClusterRerouteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Metrics? Metric { get => Q<Elastic.Clients.Elasticsearch.Metrics?>("metric"); set => Q("metric", value); }

		[JsonIgnore]
		public bool? RetryFailed { get => Q<bool?>("retry_failed"); set => Q("retry_failed", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonInclude]
		[JsonPropertyName("commands")]
		public IEnumerable<Cluster.Reroute.ICommand>? Commands { get; set; }
	}

	public partial class ClusterRerouteRequestDescriptor : RequestDescriptorBase<ClusterRerouteRequestDescriptor, ClusterRerouteRequestParameters, IClusterRerouteRequest>, IClusterRerouteRequest
	{
		///<summary>/_cluster/reroute</summary>
        public ClusterRerouteRequestDescriptor() : base()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		IEnumerable<Cluster.Reroute.ICommand>? IClusterRerouteRequest.Commands { get; set; }

		public ClusterRerouteRequestDescriptor Commands(IEnumerable<Cluster.Reroute.ICommand>? commands) => Assign(commands, (a, v) => a.Commands = v);
		public ClusterRerouteRequestDescriptor DryRun(bool? dryRun) => Qs("dry_run", dryRun);
		public ClusterRerouteRequestDescriptor Explain(bool? explain) => Qs("explain", explain);
		public ClusterRerouteRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Metrics? metric) => Qs("metric", metric);
		public ClusterRerouteRequestDescriptor RetryFailed(bool? retryFailed) => Qs("retry_failed", retryFailed);
		public ClusterRerouteRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterRerouteRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
	}

	internal sealed class ClusterRerouteRequestDescriptorConverter<TReadAs> : JsonConverter<IClusterRerouteRequest> where TReadAs : class, IClusterRerouteRequest
	{
		public override IClusterRerouteRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize<TReadAs>(ref reader, options);
		public override void Write(Utf8JsonWriter writer, IClusterRerouteRequest value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.Commands is not null)
			{
				writer.WritePropertyName("commands");
				JsonSerializer.Serialize(writer, value.Commands, options);
			}

			writer.WriteEndObject();
		}
	}
}