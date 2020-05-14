/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class DisableWorkflowResponseUnmarshaller
    {
        public static DisableWorkflowResponse Unmarshall(UnmarshallerContext context)
        {
			DisableWorkflowResponse disableWorkflowResponse = new DisableWorkflowResponse();

			disableWorkflowResponse.HttpResponse = context.HttpResponse;
			disableWorkflowResponse.RequestId = context.StringValue("DisableWorkflow.RequestId");
			disableWorkflowResponse.Code = context.IntegerValue("DisableWorkflow.Code");
			disableWorkflowResponse.Success = context.BooleanValue("DisableWorkflow.Success");
			disableWorkflowResponse.Message = context.StringValue("DisableWorkflow.Message");
        
			return disableWorkflowResponse;
        }
    }
}
