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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Fmp4 Hls Settings
    /// </summary>
    public partial class Fmp4HlsSettings
    {
        private string _audioRenditionSets;

        /// <summary>
        /// Gets and sets the property AudioRenditionSets. List all the audio groups that are
        /// used with the video output stream. Input all the audio GROUP-IDs that are associated
        /// to the video, separate by ','.
        /// </summary>
        public string AudioRenditionSets
        {
            get { return this._audioRenditionSets; }
            set { this._audioRenditionSets = value; }
        }

        // Check to see if AudioRenditionSets property is set
        internal bool IsSetAudioRenditionSets()
        {
            return this._audioRenditionSets != null;
        }

    }
}