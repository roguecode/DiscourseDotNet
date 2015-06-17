﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DiscourseDotNet.Response.LatestEndpoint
{
    [Serializable]
    public class TopicList
    {
        [JsonProperty("can_create_topic")]
        public bool CanCreateTopic { get; set; }

        [JsonProperty("more_topics_url")]
        public string MoreTopicsURL { get; set; }

        [JsonProperty("draft")]
        public object Draft { get; set; }

        [JsonProperty("draft_key")]
        public string DraftKey { get; set; }

        [JsonProperty("draft_sequence")]
        public object DraftSequence { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("topics")]
        public IList<Topic> Topics { get; set; }
    }
}