using Discord;
using System.Threading.Tasks;

namespace WhalesFargo.Services
{
    /**
    * ChatService
    * Handles the simple chat services like responses and manipulating chat text.
    */
    public class PUBGService : CustomService
    {
        // Replies in the text channel using the parent module.
        public void SayMessage(string s)
        {
            DiscordReply(s);
        }

        // Sets the bot playing status.
       
    }

}