/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// An optional category of meeting features that contains audio-specific configurations,
    /// such as operating parameters for Amazon Voice Focus.
    /// </summary>
    public partial class AudioFeatures
    {
        private MeetingFeatureStatus _echoReduction;

        /// <summary>
        /// Gets and sets the property EchoReduction. 
        /// <para>
        /// Makes echo reduction available to clients who connect to the meeting.
        /// </para>
        /// </summary>
        public MeetingFeatureStatus EchoReduction
        {
            get { return this._echoReduction; }
            set { this._echoReduction = value; }
        }

        // Check to see if EchoReduction property is set
        internal bool IsSetEchoReduction()
        {
            return this._echoReduction != null;
        }

    }
}