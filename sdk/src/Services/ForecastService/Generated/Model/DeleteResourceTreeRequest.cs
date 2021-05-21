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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourceTree operation.
    /// Deletes an entire resource tree. This operation will delete the parent resource and
    /// its child resources.
    /// 
    ///  
    /// <para>
    /// Child resources are resources that were created from another resource. For example,
    /// when a forecast is generated from a predictor, the forecast is the child resource
    /// and the predictor is the parent resource.
    /// </para>
    ///  
    /// <para>
    /// Amazon Forecast resources possess the following parent-child resource hierarchies:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Dataset</b>: dataset import jobs
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Dataset Group</b>: predictors, predictor backtest export jobs, forecasts, forecast
    /// export jobs
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Predictor</b>: predictor backtest export jobs, forecasts, forecast export jobs
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Forecast</b>: forecast export jobs
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    ///  <code>DeleteResourceTree</code> will only delete Amazon Forecast resources, and will
    /// not delete datasets or exported files stored in Amazon S3. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteResourceTreeRequest : AmazonForecastServiceRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parent resource to delete. All child resources
        /// of the parent resource will also be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}