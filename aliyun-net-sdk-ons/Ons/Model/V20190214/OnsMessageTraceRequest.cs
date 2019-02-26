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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ons.Transform;
using Aliyun.Acs.Ons.Transform.V20190214;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Model.V20190214
{
    public class OnsMessageTraceRequest : RpcAcsRequest<OnsMessageTraceResponse>
    {
        public OnsMessageTraceRequest()
            : base("Ons", "2019-02-14", "OnsMessageTrace", "ons", "openAPI")
        {
        }

		private long? preventCache;

		private string instanceId;

		private string topic;

		private string msgId;

		public long? PreventCache
		{
			get
			{
				return preventCache;
			}
			set	
			{
				preventCache = value;
				DictionaryUtil.Add(QueryParameters, "PreventCache", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Topic
		{
			get
			{
				return topic;
			}
			set	
			{
				topic = value;
				DictionaryUtil.Add(QueryParameters, "Topic", value);
			}
		}

		public string MsgId
		{
			get
			{
				return msgId;
			}
			set	
			{
				msgId = value;
				DictionaryUtil.Add(QueryParameters, "MsgId", value);
			}
		}

        public override OnsMessageTraceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OnsMessageTraceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}