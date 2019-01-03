using System.Collections.Generic;

namespace MessengerAnalysis
{
    public class GroupConvo
    {
        public class Participant
        {
            public string name { get; set; }
        }

        public class Reaction
        {
            public string reaction { get; set; }
            public string actor { get; set; }
        }

        public class Share
        {
            public string link { get; set; }
        }
        public class Gif
        {
            public string uri { get; set; }
        }
        public class Photo
        {
            public string uri { get; set; }
        }
        public class User
        {
            public string name { get; set; }
        }
        public class Message
        {
            public string sender_name { get; set; }
            public long timestamp_ms { get; set; }
            public string content { get; set; }
            public List<Reaction> reactions { get; set; }
            public List<Photo> photos { get; set; }
            public List<Gif> gifs { get; set; }
            public List<User> users { get; set; }
            public string type { get; set; }
            public Share share { get; set; }
        }

        public class Root
        {
            public List<Participant> participants { get; set; }
            public List<Message> messages { get; set; }
            public string title { get; set; }
            public bool is_still_participant { get; set; }
            public string thread_type { get; set; }
            public string thread_path { get; set; }
        }
    }
}
