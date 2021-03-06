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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20160530;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class BatchGetDeviceStateResponseUnmarshaller
    {
        public static BatchGetDeviceStateResponse Unmarshall(UnmarshallerContext context)
        {
            BatchGetDeviceStateResponse batchGetDeviceStateResponse = new BatchGetDeviceStateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("BatchGetDeviceState.RequestId"),
                Success = context.BooleanValue("BatchGetDeviceState.Success"),
                ErrorMessage = context.StringValue("BatchGetDeviceState.ErrorMessage")
            };
            List<BatchGetDeviceStateResponse.DeviceStatus> deviceStatusList = new List<BatchGetDeviceStateResponse.DeviceStatus>();
			for (int i = 0; i < context.Length("BatchGetDeviceState.DeviceStatusList.Length"); i++) {
                BatchGetDeviceStateResponse.DeviceStatus deviceStatus = new BatchGetDeviceStateResponse.DeviceStatus()
                {
                    DeviceId = context.StringValue($"BatchGetDeviceState.DeviceStatusList[{i}].DeviceId"),
                    DeviceName = context.StringValue($"BatchGetDeviceState.DeviceStatusList[{i}].DeviceName"),
                    Status = context.StringValue($"BatchGetDeviceState.DeviceStatusList[{i}].Status"),
                    AsAddress = context.StringValue($"BatchGetDeviceState.DeviceStatusList[{i}].AsAddress")
                };
                deviceStatusList.Add(deviceStatus);
			}
			batchGetDeviceStateResponse.DeviceStatusList = deviceStatusList;
        
			return batchGetDeviceStateResponse;
        }
    }
}