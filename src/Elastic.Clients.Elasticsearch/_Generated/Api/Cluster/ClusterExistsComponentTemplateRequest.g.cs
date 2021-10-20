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
	public class ClusterExistsComponentTemplateRequestParameters : RequestParameters<ClusterExistsComponentTemplateRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
	}

	[InterfaceConverterAttribute(typeof(ClusterExistsComponentTemplateRequestDescriptorConverter<ClusterExistsComponentTemplateRequest>))]
	public partial interface IClusterExistsComponentTemplateRequest : IRequest<ClusterExistsComponentTemplateRequestParameters>
	{
	}

	public partial class ClusterExistsComponentTemplateRequest : PlainRequestBase<ClusterExistsComponentTemplateRequestParameters>, IClusterExistsComponentTemplateRequest
	{
		public ClusterExistsComponentTemplateRequest(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterExistsComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
	}

	public partial class ClusterExistsComponentTemplateRequestDescriptor : RequestDescriptorBase<ClusterExistsComponentTemplateRequestDescriptor, ClusterExistsComponentTemplateRequestParameters, IClusterExistsComponentTemplateRequest>, IClusterExistsComponentTemplateRequest
	{
		///<summary>/_component_template/{name}</summary>
        public ClusterExistsComponentTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterExistsComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		public ClusterExistsComponentTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterExistsComponentTemplateRequestDescriptor Local(bool? local) => Qs("local", local);
	}

	internal sealed class ClusterExistsComponentTemplateRequestDescriptorConverter<TReadAs> : JsonConverter<IClusterExistsComponentTemplateRequest> where TReadAs : class, IClusterExistsComponentTemplateRequest
	{
		public override IClusterExistsComponentTemplateRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize<TReadAs>(ref reader, options);
		public override void Write(Utf8JsonWriter writer, IClusterExistsComponentTemplateRequest value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}