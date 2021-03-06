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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class UpdatePipelineResponseUnmarshaller
    {
        public static UpdatePipelineResponse Unmarshall(UnmarshallerContext context)
        {
            UpdatePipelineResponse updatePipelineResponse = new UpdatePipelineResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("UpdatePipeline.RequestId")
            };
            UpdatePipelineResponse.Pipeline_ pipeline = new UpdatePipelineResponse.Pipeline_()
            {
                Id = context.StringValue("UpdatePipeline.Pipeline.Id"),
                Name = context.StringValue("UpdatePipeline.Pipeline.Name"),
                State = context.StringValue("UpdatePipeline.Pipeline.State"),
                Speed = context.StringValue("UpdatePipeline.Pipeline.Speed"),
                Role = context.StringValue("UpdatePipeline.Pipeline.Role")
            };
            UpdatePipelineResponse.Pipeline_.NotifyConfig_ notifyConfig = new UpdatePipelineResponse.Pipeline_.NotifyConfig_()
            {
                Topic = context.StringValue("UpdatePipeline.Pipeline.NotifyConfig.Topic"),
                QueueName = context.StringValue("UpdatePipeline.Pipeline.NotifyConfig.QueueName")
            };
            pipeline.NotifyConfig = notifyConfig;
			updatePipelineResponse.Pipeline = pipeline;
        
			return updatePipelineResponse;
        }
    }
}