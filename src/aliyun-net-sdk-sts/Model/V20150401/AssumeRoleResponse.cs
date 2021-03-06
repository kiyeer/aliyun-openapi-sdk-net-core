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

namespace Aliyun.Acs.Sts.Model.V20150401
{
	public class AssumeRoleResponse : AcsResponse
	{
	    public Credentials_ Credentials { get; set; }

	    public AssumedRoleUser_ AssumedRoleUser { get; set; }

	    public class Credentials_{
	        public string SecurityToken { get; set; }

	        public string AccessKeySecret { get; set; }

	        public string AccessKeyId { get; set; }

	        public string Expiration { get; set; }
	    }

		public class AssumedRoleUser_{
		    public string Arn { get; set; }

		    public string AssumedRoleId { get; set; }
		}
	}
}