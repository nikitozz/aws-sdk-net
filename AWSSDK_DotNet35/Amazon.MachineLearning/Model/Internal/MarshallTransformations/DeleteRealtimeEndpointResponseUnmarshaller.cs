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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeleteRealtimeEndpoint operation
    /// </summary>  
    public class DeleteRealtimeEndpointResponseUnmarshaller : JsonResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DeleteRealtimeEndpointResponse response = new DeleteRealtimeEndpointResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MLModelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MLModelId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RealtimeEndpointInfo", targetDepth))
                {
                    var unmarshaller = RealtimeEndpointInfoUnmarshaller.Instance;
                    response.RealtimeEndpointInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
            {
                return new InternalServerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInputException"))
            {
                return new InvalidInputException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonMachineLearningException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DeleteRealtimeEndpointResponseUnmarshaller _instance = new DeleteRealtimeEndpointResponseUnmarshaller();        

        internal static DeleteRealtimeEndpointResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DeleteRealtimeEndpointResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}