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
using System;

namespace Nest
{
    internal static class ApiUrlsLookups
    {
        internal static ApiUrls ClusterHealth = new ApiUrls(new[]{"/_cluster/health", "/_cluster/health/{index}"});
        internal static ApiUrls NoNamespaceDelete = new ApiUrls(new[]{"/{index}/_doc/{id}"});
        internal static ApiUrls NoNamespaceExists = new ApiUrls(new[]{"/{index}/_doc/{id}"});
        internal static ApiUrls NoNamespaceGet = new ApiUrls(new[]{"/{index}/_doc/{id}"});
        internal static ApiUrls NoNamespaceIndex = new ApiUrls(new[]{"/{index}/_doc/{id}", "/{index}/_doc"});
        internal static ApiUrls IndicesCreate = new ApiUrls(new[]{"/{index}"});
        internal static ApiUrls IndicesDelete = new ApiUrls(new[]{"/{index}"});
        internal static ApiUrls IndicesRefresh = new ApiUrls(new[]{"/_refresh", "/{index}/_refresh"});
        internal static ApiUrls NoNamespacePing = new ApiUrls(new[]{"/"});
        internal static ApiUrls NoNamespaceSearch = new ApiUrls(new[]{"/_search", "/{index}/_search"});
    }
}