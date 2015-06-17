﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DiscourseDotNet.Response.LatestEndpoint
{
    [Serializable]
    public class Topic
    {
        [JsonProperty("id")]
        public int TopicID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fancy_title")]
        public string FancyTitle { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("posts_count")]
        public int PostCount { get; set; }

        [JsonProperty("reply_count")]
        public int ReplyCount { get; set; }

        [JsonProperty("highest_post_number")]
        public int HighestPostNumber { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("last_posted_at")]
        public DateTime LastPostedAt { get; set; }

        [JsonProperty("bumped")]
        public bool Bumped { get; set; }

        [JsonProperty("bumped_at")]
        public DateTime BumpedAt { get; set; }

        [JsonProperty("unseen")]
        public bool Unseen { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("unpinned")]
        public object Unpinned { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("bookmarked")]
        public object Bookmarked { get; set; }

        [JsonProperty("liked")]
        public object Liked { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("like_count")]
        public int LikeCount { get; set; }

        [JsonProperty("has_summary")]
        public bool HasSummary { get; set; }

        [JsonProperty("archetype")]
        public string Archetype { get; set; }

        [JsonProperty("last_poster_username")]
        public string LastPosterUsername { get; set; }

        [JsonProperty("category_id")]
        public int CategoryID { get; set; }

        [JsonProperty("pinned_globally")]
        public bool PinnedGlobally { get; set; }

        [JsonProperty("posters")]
        public IList<Poster> Posters { get; set; }
    }
}