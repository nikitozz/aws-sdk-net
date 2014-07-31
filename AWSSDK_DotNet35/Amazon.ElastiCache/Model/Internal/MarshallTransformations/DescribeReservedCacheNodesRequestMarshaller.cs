/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeReservedCacheNodes Request Marshaller
    /// </summary>       
    public class DescribeReservedCacheNodesRequestMarshaller : IMarshaller<IRequest, DescribeReservedCacheNodesRequest>
    {
        public IRequest Marshall(DescribeReservedCacheNodesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "DescribeReservedCacheNodes");
            request.Parameters.Add("Version", "2014-07-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCacheNodeType())
                {
                    request.Parameters.Add("CacheNodeType", StringUtils.FromString(publicRequest.CacheNodeType));
                }
                if(publicRequest.IsSetDuration())
                {
                    request.Parameters.Add("Duration", StringUtils.FromString(publicRequest.Duration));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetOfferingType())
                {
                    request.Parameters.Add("OfferingType", StringUtils.FromString(publicRequest.OfferingType));
                }
                if(publicRequest.IsSetProductDescription())
                {
                    request.Parameters.Add("ProductDescription", StringUtils.FromString(publicRequest.ProductDescription));
                }
                if(publicRequest.IsSetReservedCacheNodeId())
                {
                    request.Parameters.Add("ReservedCacheNodeId", StringUtils.FromString(publicRequest.ReservedCacheNodeId));
                }
                if(publicRequest.IsSetReservedCacheNodesOfferingId())
                {
                    request.Parameters.Add("ReservedCacheNodesOfferingId", StringUtils.FromString(publicRequest.ReservedCacheNodesOfferingId));
                }
            }
            return request;
        }
    }
}