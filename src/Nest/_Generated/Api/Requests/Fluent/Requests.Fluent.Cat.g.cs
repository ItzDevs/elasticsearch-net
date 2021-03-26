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
	public class CatAliasesDescriptor : RequestDescriptorBase<CatAliasesDescriptor, CatAliasesRequestParameters, ICatAliasesRequest>, ICatAliasesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAliases;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatAllocationDescriptor : RequestDescriptorBase<CatAllocationDescriptor, CatAllocationRequestParameters, ICatAllocationRequest>, ICatAllocationRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAllocation;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatCountDescriptor : RequestDescriptorBase<CatCountDescriptor, CatCountRequestParameters, ICatCountRequest>, ICatCountRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatCount;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatFielddataDescriptor : RequestDescriptorBase<CatFielddataDescriptor, CatFielddataRequestParameters, ICatFielddataRequest>, ICatFielddataRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatFielddata;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatHealthDescriptor : RequestDescriptorBase<CatHealthDescriptor, CatHealthRequestParameters, ICatHealthRequest>, ICatHealthRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatHelpDescriptor : RequestDescriptorBase<CatHelpDescriptor, CatHelpRequestParameters, ICatHelpRequest>, ICatHelpRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHelp;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatIndicesDescriptor : RequestDescriptorBase<CatIndicesDescriptor, CatIndicesRequestParameters, ICatIndicesRequest>, ICatIndicesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatIndices;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatMasterDescriptor : RequestDescriptorBase<CatMasterDescriptor, CatMasterRequestParameters, ICatMasterRequest>, ICatMasterRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMaster;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatDataFrameAnalyticsDescriptor : RequestDescriptorBase<CatDataFrameAnalyticsDescriptor, CatDataFrameAnalyticsRequestParameters, ICatDataFrameAnalyticsRequest>, ICatDataFrameAnalyticsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatDatafeedsDescriptor : RequestDescriptorBase<CatDatafeedsDescriptor, CatDatafeedsRequestParameters, ICatDatafeedsRequest>, ICatDatafeedsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlDatafeeds;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatJobsDescriptor : RequestDescriptorBase<CatJobsDescriptor, CatJobsRequestParameters, ICatJobsRequest>, ICatJobsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlJobs;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatTrainedModelsDescriptor : RequestDescriptorBase<CatTrainedModelsDescriptor, CatTrainedModelsRequestParameters, ICatTrainedModelsRequest>, ICatTrainedModelsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlTrainedModels;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatNodeAttributesDescriptor : RequestDescriptorBase<CatNodeAttributesDescriptor, CatNodeAttributesRequestParameters, ICatNodeAttributesRequest>, ICatNodeAttributesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodeattrs;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatNodesDescriptor : RequestDescriptorBase<CatNodesDescriptor, CatNodesRequestParameters, ICatNodesRequest>, ICatNodesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodes;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatPendingTasksDescriptor : RequestDescriptorBase<CatPendingTasksDescriptor, CatPendingTasksRequestParameters, ICatPendingTasksRequest>, ICatPendingTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatPluginsDescriptor : RequestDescriptorBase<CatPluginsDescriptor, CatPluginsRequestParameters, ICatPluginsRequest>, ICatPluginsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPlugins;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatRecoveryDescriptor : RequestDescriptorBase<CatRecoveryDescriptor, CatRecoveryRequestParameters, ICatRecoveryRequest>, ICatRecoveryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRecovery;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatRepositoriesDescriptor : RequestDescriptorBase<CatRepositoriesDescriptor, CatRepositoriesRequestParameters, ICatRepositoriesRequest>, ICatRepositoriesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRepositories;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatSegmentsDescriptor : RequestDescriptorBase<CatSegmentsDescriptor, CatSegmentsRequestParameters, ICatSegmentsRequest>, ICatSegmentsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSegments;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatShardsDescriptor : RequestDescriptorBase<CatShardsDescriptor, CatShardsRequestParameters, ICatShardsRequest>, ICatShardsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatShards;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatSnapshotsDescriptor : RequestDescriptorBase<CatSnapshotsDescriptor, CatSnapshotsRequestParameters, ICatSnapshotsRequest>, ICatSnapshotsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSnapshots;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatTasksDescriptor : RequestDescriptorBase<CatTasksDescriptor, CatTasksRequestParameters, ICatTasksRequest>, ICatTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatTemplatesDescriptor : RequestDescriptorBase<CatTemplatesDescriptor, CatTemplatesRequestParameters, ICatTemplatesRequest>, ICatTemplatesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTemplates;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatThreadPoolDescriptor : RequestDescriptorBase<CatThreadPoolDescriptor, CatThreadPoolRequestParameters, ICatThreadPoolRequest>, ICatThreadPoolRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatThreadPool;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class CatTransformsDescriptor : RequestDescriptorBase<CatTransformsDescriptor, CatTransformsRequestParameters, ICatTransformsRequest>, ICatTransformsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTransforms;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}
}