using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MessengerAnalysis
{
    public static class Profanity
    {
        //This list is pretty arbitrary, but that's unavoidable
        public static List<string> SwearWords = new List<string>() {"arsehole","arseholes","ass","asses","bitch","bitches","bullshit","bollocks","bolocks","cock","cocks","cum","cums","cumming","cuming","cunt","cunts","cunty","dick","dicks","fag","fags","faggot","faggots","fagot","fagots","fuck","fucks","fucking","fucked","fucker","jerking","jerkoff","jizz","motherfucker","motherfuckers","nigga","niggas","niggaz","nigger","niggers","niggerz","nigg","pussy","pussies","shit","shits","shitting","shitty","shity","slut","sluts","slutty","tit","tits","titties","titty","twat","twats","wank","wanks","whore","whores"};

        public static int Counter(string content)
        {
            var words = (new Regex(@"[^\p{L}]*\p{Z}[^\p{L}]*")).Split(content.ToLower());
            return words.Intersect(SwearWords).Count();
        }
    }
}
