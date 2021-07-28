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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public partial class IndicesCreateDescriptor : RequestDescriptorBase<IndicesCreateDescriptor, IndicesCreateRequestParameters, IIndicesCreateRequest>, IIndicesCreateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/{index}</summary>
        public IndicesCreateDescriptor(IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class DeleteIndicesDescriptor : RequestDescriptorBase<DeleteIndicesDescriptor, DeleteIndicesRequestParameters, IDeleteIndicesRequest>, IDeleteIndicesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/{index}</summary>
        public DeleteIndicesDescriptor(Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class IndicesDeleteDataStreamDescriptor : RequestDescriptorBase<IndicesDeleteDataStreamDescriptor, IndicesDeleteDataStreamRequestParameters, IIndicesDeleteDataStreamRequest>, IIndicesDeleteDataStreamRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDeleteDataStream;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_data_stream/{name}</summary>
        public IndicesDeleteDataStreamDescriptor(DataStreamName name) : base(r => r.Required("name", name))
		{
		}
	}

	public partial class IndicesRefreshDescriptor : RequestDescriptorBase<IndicesRefreshDescriptor, IndicesRefreshRequestParameters, IIndicesRefreshRequest>, IIndicesRefreshRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesRefresh;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_refresh</summary>
        public IndicesRefreshDescriptor() : base()
		{
		}

		///<summary>/{index}/_refresh</summary>
        public IndicesRefreshDescriptor(Indices index) : base(r => r.Optional("index", index))
		{
		}
	}
}