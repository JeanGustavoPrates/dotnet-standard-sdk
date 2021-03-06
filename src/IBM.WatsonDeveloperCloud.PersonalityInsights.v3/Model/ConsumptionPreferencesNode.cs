/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model
{
    /// <summary>
    /// ConsumptionPreferencesNode.
    /// </summary>
    public class ConsumptionPreferencesNode
    {
        /// <summary>
        /// The unique identifier of the consumption preference to which the results pertain. IDs have the form `consumption_preferences_{preference}`.
        /// </summary>
        /// <value>The unique identifier of the consumption preference to which the results pertain. IDs have the form `consumption_preferences_{preference}`.</value>
        [JsonProperty("consumption_preference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumptionPreferenceId { get; set; }
        /// <summary>
        /// The user-visible name of the consumption preference.
        /// </summary>
        /// <value>The user-visible name of the consumption preference.</value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// The score for the consumption preference: `0.0` indicates unlikely, `0.5` indicates neutrality, and `1.0` indicates likely. The scores for some preferences are binary and do not allow a neutral value. The score is an indication of preference based on the results inferred from the input text, not a normalized percentile.
        /// </summary>
        /// <value>The score for the consumption preference: `0.0` indicates unlikely, `0.5` indicates neutrality, and `1.0` indicates likely. The scores for some preferences are binary and do not allow a neutral value. The score is an indication of preference based on the results inferred from the input text, not a normalized percentile.</value>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public double? Score { get; set; }
    }

}
