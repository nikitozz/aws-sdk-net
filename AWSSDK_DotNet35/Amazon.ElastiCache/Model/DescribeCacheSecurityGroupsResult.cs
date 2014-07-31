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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the output of a <i>DescribeCacheSecurityGroups</i> operation.
    /// </summary>
    public partial class DescribeCacheSecurityGroupsResult : AmazonWebServiceResponse
    {
        private List<CacheSecurityGroup> _cacheSecurityGroups = new List<CacheSecurityGroup>();
        private string _marker;


        /// <summary>
        /// Gets and sets the property CacheSecurityGroups. 
        /// <para>
        /// A list of cache security groups. Each element in the list contains detailed information
        /// about one group.
        /// </para>
        /// </summary>
        public List<CacheSecurityGroup> CacheSecurityGroups
        {
            get { return this._cacheSecurityGroups; }
            set { this._cacheSecurityGroups = value; }
        }

        // Check to see if CacheSecurityGroups property is set
        internal bool IsSetCacheSecurityGroups()
        {
            return this._cacheSecurityGroups != null && this._cacheSecurityGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Provides an identifier to allow retrieval of paginated results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}