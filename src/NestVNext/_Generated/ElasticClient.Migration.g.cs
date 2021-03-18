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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest
{
	public class MigrationNamespace : NamespacedClientProxy
	{
		internal MigrationNamespace(ElasticClient client) : base(client)
		{
		}

		public DeprecationInfoResponse DeprecationInfo(IDeprecationInfoRequest request)
		{
			return DoRequest<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters);
		}

		public Task<DeprecationInfoResponse> DeprecationInfoAsync(IDeprecationInfoRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}