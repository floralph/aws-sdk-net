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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// A pre-formed Amazon SageMaker model input you can include if your detector version
    /// includes an imported Amazon SageMaker model endpoint with pass-through input configuration.
    /// </summary>
    public partial class ModelEndpointDataBlob
    {
        private MemoryStream _byteBuffer;
        private string _contentType;

        /// <summary>
        /// Gets and sets the property ByteBuffer. 
        /// <para>
        /// The byte buffer of the Amazon SageMaker model endpoint input data blob.
        /// </para>
        /// </summary>
        public MemoryStream ByteBuffer
        {
            get { return this._byteBuffer; }
            set { this._byteBuffer = value; }
        }

        // Check to see if ByteBuffer property is set
        internal bool IsSetByteBuffer()
        {
            return this._byteBuffer != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the Amazon SageMaker model endpoint input data blob. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

    }
}