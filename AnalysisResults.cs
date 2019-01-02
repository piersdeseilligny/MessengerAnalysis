using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MessengerAnalysis.Program;

namespace MessengerAnalysis
{
    public class AnalysisResults
    {
        
        public class UserStats
        {
            public void Add(UserStats stats)
            {
                foreach(var entry in stats.RespondedTo)
                {
                    if (RespondedTo.ContainsKey(entry.Key))
                        RespondedTo[entry.Key] += stats.RespondedTo[entry.Key];
                    else
                        RespondedTo.Add(entry.Key,entry.Value);
                }


                MessagesSent += stats.MessagesSent;
                TotalCharacterCount += stats.TotalCharacterCount;
                GifsSent += stats.GifsSent;
                ImagesSent += stats.ImagesSent;
                LinksSent += stats.LinksSent;
                AllCapsSent += stats.AllCapsSent;
                CustomWordsSent += stats.CustomWordsSent;
                SwearingSent += stats.SwearingSent;
                SwearingSentMono += stats.SwearingSentMono;

                GaveHeart += stats.GaveHeart;
                GaveLaugh += stats.GaveLaugh;
                GaveWow += stats.GaveWow;
                GaveAngry += stats.GaveAngry;
                GaveLike += stats.GaveLike;
                GaveDislike += stats.GaveDislike;
                GaveSad += stats.GaveSad;

                ReceivedHeart += stats.ReceivedHeart;
                ReceivedLaugh += stats.ReceivedLaugh;
                ReceivedWow += stats.ReceivedWow;
                ReceivedAngry += stats.ReceivedAngry;
                ReceivedLike += stats.ReceivedLike;
                ReceivedDislike += stats.ReceivedDislike;
                ReceivedSad += stats.ReceivedSad;

                AppreciationMeter += stats.AppreciationMeter;
            }
            public string MostGivenReaction()
            {
                int mostgivencount = 0;
                string mostgivenreaction = "None given";
                Helper.MostSomethingHelper(ref mostgivencount, ref mostgivenreaction, GaveAngry, "Angry");
                Helper.MostSomethingHelper(ref mostgivencount, ref mostgivenreaction, GaveDislike, "Dislike");
                Helper.MostSomethingHelper(ref mostgivencount, ref mostgivenreaction, GaveHeart, "Heart");
                Helper.MostSomethingHelper(ref mostgivencount, ref mostgivenreaction, GaveLaugh, "Laugh");
                Helper.MostSomethingHelper(ref mostgivencount, ref mostgivenreaction, GaveLike, "Like");
                Helper.MostSomethingHelper(ref mostgivencount, ref mostgivenreaction, GaveSad, "Sad");
                Helper.MostSomethingHelper(ref mostgivencount, ref mostgivenreaction, GaveAngry, "Wow");
                return mostgivenreaction;
            }
            public string MostReceivedReaction()
            {
                int mostreceivedcount = 0;
                string mostreceivedreaction = "None received";
                Helper.MostSomethingHelper(ref mostreceivedcount, ref mostreceivedreaction, ReceivedAngry, "Angry");
                Helper.MostSomethingHelper(ref mostreceivedcount, ref mostreceivedreaction, ReceivedDislike, "Dislike");
                Helper.MostSomethingHelper(ref mostreceivedcount, ref mostreceivedreaction, ReceivedHeart, "Heart");
                Helper.MostSomethingHelper(ref mostreceivedcount, ref mostreceivedreaction, ReceivedLaugh, "Laugh");
                Helper.MostSomethingHelper(ref mostreceivedcount, ref mostreceivedreaction, ReceivedLike, "Like");
                Helper.MostSomethingHelper(ref mostreceivedcount, ref mostreceivedreaction, ReceivedSad, "Sad");
                Helper.MostSomethingHelper(ref mostreceivedcount, ref mostreceivedreaction, ReceivedAngry, "Wow");
                return mostreceivedreaction;
            }

            /// <summary>
            /// Write down a list of who the user has talked with the most. For each user, this is calculated with the following formula:
            /// 
            /// Ab/At+Ba/Bt where
            /// Ab = times A has responded to B
            /// At = total message count sent by A
            /// Ba = times B has responded to A
            /// Bt = total message count sent by B
            /// </summary>
            /// <param name="GlobalStats"></param>
            public void WriteTalksWith(ref Dictionary<string,UserStats> GlobalStats)
            {
                Dictionary<string, double> TalksWith = new Dictionary<string, double>();
                foreach(var user in RespondedTo)
                {
                    double otherside = 0;
                    if (GlobalStats[user.Key].RespondedTo.ContainsKey(Username))
                        otherside = (double)GlobalStats[user.Key].RespondedTo[Username]/(double)MessagesSent;
                    TalksWith.Add(user.Key, Math.Round((((double)user.Value/GlobalStats[user.Key].MessagesSent)+(otherside))*100, 2));
                }
                foreach (var person in TalksWith.OrderBy(x => x.Value).Select(x => x.Key + " (" + x.Value + ")"))
                    Log.WriteSubtleLine(person);
            }

            public Dictionary<string, int> RespondedTo = new Dictionary<string, int>();
            public string Username { get; set; }
            public int MessagesSent { get; set; }
            public int TotalCharacterCount { get; set; }
            public int GifsSent { get; set; }
            public int ImagesSent { get; set; }
            public int LinksSent { get; set; }
            public int AllCapsSent { get; set; }
            public int CustomWordsSent { get; set; }
            public int SwearingSent { get; set; }
            public int SwearingSentMono { get; set; }

            public int GaveHeart { get; set; }
            public int GaveLaugh { get; set; }
            public int GaveWow { get; set; }
            public int GaveAngry { get; set; }
            public int GaveLike { get; set; }
            public int GaveDislike { get; set; }
            public int GaveSad { get; set; }

            public int ReceivedHeart { get; set; }
            public int ReceivedLaugh { get; set; }
            public int ReceivedWow { get; set; }
            public int ReceivedAngry { get; set; }
            public int ReceivedLike { get; set; }
            public int ReceivedDislike { get; set; }
            public int ReceivedSad { get; set; }
            public double AppreciationMeter { get; set; }
        }
    }
}
