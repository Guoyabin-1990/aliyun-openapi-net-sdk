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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.saf.Transform;
using Aliyun.Acs.saf.Transform.V20170331;

namespace Aliyun.Acs.saf.Model.V20170331
{
    public class ExecuteRequestRequest : RpcAcsRequest<ExecuteRequestResponse>
    {
        public ExecuteRequestRequest()
            : base("saf", "2017-03-31", "ExecuteRequest", "saf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private string serviceParameters;

		private string service;

		public string ServiceParameters
		{
			get
			{
				return serviceParameters;
			}
			set	
			{
				serviceParameters = value;
				DictionaryUtil.Add(QueryParameters, "ServiceParameters", value);
			}
		}

		public string Service
		{
			get
			{
				return service;
			}
			set	
			{
				service = value;
				DictionaryUtil.Add(QueryParameters, "Service", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExecuteRequestResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExecuteRequestResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
