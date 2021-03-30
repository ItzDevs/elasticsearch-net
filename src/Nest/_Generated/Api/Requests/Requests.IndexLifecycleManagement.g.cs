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

using System;
using System.Text.Json.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest
{
	[JsonInterfaceConverter(typeof(InterfaceConverter<IDeleteLifecycleRequest, DeleteLifecycleRequest>))]
	public interface IDeleteLifecycleRequest : IRequest<DeleteLifecycleRequestParameters>
	{
	}

	public class DeleteLifecycleRequest : PlainRequestBase<DeleteLifecycleRequestParameters>, IDeleteLifecycleRequest
	{
		protected IDeleteLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementDeleteLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_ilm/policy/{policy}</summary>
        public DeleteLifecycleRequest(Name policy) : base(r => r.Optional("policy", policy))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IExplainLifecycleRequest, ExplainLifecycleRequest>))]
	public interface IExplainLifecycleRequest : IRequest<ExplainLifecycleRequestParameters>
	{
	}

	public class ExplainLifecycleRequest : PlainRequestBase<ExplainLifecycleRequestParameters>, IExplainLifecycleRequest
	{
		protected IExplainLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/{index}/_ilm/explain</summary>
        public ExplainLifecycleRequest(IndexName index) : base(r => r.Required("index", index))
		{
		}

		[JsonIgnore]
		public bool? OnlyErrors { get => Q<bool?>("only_errors"); set => Q("only_errors", value); }

		[JsonIgnore]
		public bool? OnlyManaged { get => Q<bool?>("only_managed"); set => Q("only_managed", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetLifecycleRequest, GetLifecycleRequest>))]
	public interface IGetLifecycleRequest : IRequest<GetLifecycleRequestParameters>
	{
	}

	public class GetLifecycleRequest : PlainRequestBase<GetLifecycleRequestParameters>, IGetLifecycleRequest
	{
		protected IGetLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_ilm/policy/{policy}</summary>
        public GetLifecycleRequest(Name policy) : base(r => r.Optional("policy", policy))
		{
		}

		///<summary>/_ilm/policy</summary>
        public GetLifecycleRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetIlmStatusRequest, GetIlmStatusRequest>))]
	public interface IGetIlmStatusRequest : IRequest<GetIlmStatusRequestParameters>
	{
	}

	public class GetIlmStatusRequest : PlainRequestBase<GetIlmStatusRequestParameters>, IGetIlmStatusRequest
	{
		protected IGetIlmStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_ilm/status</summary>
        public GetIlmStatusRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IMoveToStepRequest, MoveToStepRequest>))]
	public interface IMoveToStepRequest : IRequest<MoveToStepRequestParameters>
	{
	}

	public class MoveToStepRequest : PlainRequestBase<MoveToStepRequestParameters>, IMoveToStepRequest
	{
		protected IMoveToStepRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementMoveToStep;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => CurrentStep is null && NextStep is null;
		///<summary>/_ilm/move/{index}</summary>
        public MoveToStepRequest(IndexName index) : base(r => r.Required("index", index))
		{
		}

		[JsonPropertyName("current_step")]
		public StepKey? CurrentStep
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("next_step")]
		public StepKey? NextStep
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IPutLifecycleRequest, PutLifecycleRequest>))]
	public interface IPutLifecycleRequest : IRequest<PutLifecycleRequestParameters>
	{
	}

	public class PutLifecycleRequest : PlainRequestBase<PutLifecycleRequestParameters>, IPutLifecycleRequest
	{
		protected IPutLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Policy is null;
		///<summary>/_ilm/policy/{policy}</summary>
        public PutLifecycleRequest(Name policy) : base(r => r.Optional("policy", policy))
		{
		}

		[JsonPropertyName("policy")]
		public Policy? Policy
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IRemovePolicyRequest, RemovePolicyRequest>))]
	public interface IRemovePolicyRequest : IRequest<RemovePolicyRequestParameters>
	{
	}

	public class RemovePolicyRequest : PlainRequestBase<RemovePolicyRequestParameters>, IRemovePolicyRequest
	{
		protected IRemovePolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRemovePolicy;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/{index}/_ilm/remove</summary>
        public RemovePolicyRequest(IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IRetryIlmRequest, RetryIlmRequest>))]
	public interface IRetryIlmRequest : IRequest<RetryIlmRequestParameters>
	{
	}

	public class RetryIlmRequest : PlainRequestBase<RetryIlmRequestParameters>, IRetryIlmRequest
	{
		protected IRetryIlmRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/{index}/_ilm/retry</summary>
        public RetryIlmRequest(IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStartIlmRequest, StartIlmRequest>))]
	public interface IStartIlmRequest : IRequest<StartIlmRequestParameters>
	{
	}

	public class StartIlmRequest : PlainRequestBase<StartIlmRequestParameters>, IStartIlmRequest
	{
		protected IStartIlmRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_ilm/start</summary>
        public StartIlmRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStopIlmRequest, StopIlmRequest>))]
	public interface IStopIlmRequest : IRequest<StopIlmRequestParameters>
	{
	}

	public class StopIlmRequest : PlainRequestBase<StopIlmRequestParameters>, IStopIlmRequest
	{
		protected IStopIlmRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_ilm/stop</summary>
        public StopIlmRequest() : base()
		{
		}
	}
}