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

/*
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using Amazon.Runtime;

namespace Amazon.WorkSpaces
{
    public class AmazonWorkSpacesException : AmazonServiceException
    {
        public AmazonWorkSpacesException(string message)
            : base(message)
        {
        }

        public AmazonWorkSpacesException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AmazonWorkSpacesException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        public AmazonWorkSpacesException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        public AmazonWorkSpacesException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }
    }
}