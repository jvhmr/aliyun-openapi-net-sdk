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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceGroupPhotosResponseUnmarshaller
    {
        public static ListFaceGroupPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceGroupPhotosResponse listFaceGroupPhotosResponse = new ListFaceGroupPhotosResponse();

			listFaceGroupPhotosResponse.HttpResponse = context.HttpResponse;
			listFaceGroupPhotosResponse.RequestId = context.StringValue("ListFaceGroupPhotos.RequestId");
			listFaceGroupPhotosResponse.NextMarker = context.StringValue("ListFaceGroupPhotos.NextMarker");

			List<ListFaceGroupPhotosResponse.ListFaceGroupPhotos_PhotosItem> listFaceGroupPhotosResponse_photos = new List<ListFaceGroupPhotosResponse.ListFaceGroupPhotos_PhotosItem>();
			for (int i = 0; i < context.Length("ListFaceGroupPhotos.Photos.Length"); i++) {
				ListFaceGroupPhotosResponse.ListFaceGroupPhotos_PhotosItem photosItem = new ListFaceGroupPhotosResponse.ListFaceGroupPhotos_PhotosItem();
				photosItem.PhotoUri = context.StringValue("ListFaceGroupPhotos.Photos["+ i +"].PhotoUri");
				photosItem.FaceId = context.StringValue("ListFaceGroupPhotos.Photos["+ i +"].FaceId");

				listFaceGroupPhotosResponse_photos.Add(photosItem);
			}
			listFaceGroupPhotosResponse.Photos = listFaceGroupPhotosResponse_photos;
        
			return listFaceGroupPhotosResponse;
        }
    }
}