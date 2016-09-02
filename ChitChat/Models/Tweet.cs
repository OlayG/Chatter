

using System;
using System.ComponentModel.DataAnnotations;

namespace ChitChat.Models
{
    public class Tweet
    {
        public int TweetId { get; set; }
        public string TweetMessage { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime TweetMessageTime { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}