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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class AuthorizeSecurityGroupEgressRequest : RpcAcsRequest<AuthorizeSecurityGroupEgressResponse>
    {
        public AuthorizeSecurityGroupEgressRequest()
            : base("Ecs", "2014-05-26", "AuthorizeSecurityGroupEgress")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _securityGroupId;

		private string _ipProtocol;

		private string _portRange;

		private string _destGroupId;

		private string _destGroupOwnerAccount;

		private string _destCidrIp;

		private string _policy;

		private string _priority;

		private string _nicType;

		private string _clientToken;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return _securityGroupId;
			}
			set	
			{
				_securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public string IpProtocol
		{
			get
			{
				return _ipProtocol;
			}
			set	
			{
				_ipProtocol = value;
				DictionaryUtil.Add(QueryParameters, "IpProtocol", value);
			}
		}

		public string PortRange
		{
			get
			{
				return _portRange;
			}
			set	
			{
				_portRange = value;
				DictionaryUtil.Add(QueryParameters, "PortRange", value);
			}
		}

		public string DestGroupId
		{
			get
			{
				return _destGroupId;
			}
			set	
			{
				_destGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DestGroupId", value);
			}
		}

		public string DestGroupOwnerAccount
		{
			get
			{
				return _destGroupOwnerAccount;
			}
			set	
			{
				_destGroupOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "DestGroupOwnerAccount", value);
			}
		}

		public string DestCidrIp
		{
			get
			{
				return _destCidrIp;
			}
			set	
			{
				_destCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "DestCidrIp", value);
			}
		}

		public string Policy
		{
			get
			{
				return _policy;
			}
			set	
			{
				_policy = value;
				DictionaryUtil.Add(QueryParameters, "Policy", value);
			}
		}

		public string Priority
		{
			get
			{
				return _priority;
			}
			set	
			{
				_priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value);
			}
		}

		public string NicType
		{
			get
			{
				return _nicType;
			}
			set	
			{
				_nicType = value;
				DictionaryUtil.Add(QueryParameters, "NicType", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return _clientToken;
			}
			set	
			{
				_clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override AuthorizeSecurityGroupEgressResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AuthorizeSecurityGroupEgressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}