# DiscordBot
How to create Discord bot
1) Go to Discord and create a bot
2) Download a c# editor and create a new console project
3) Copy and paste the code named main.cs into your project
4) Replace the text "Your discord token" with your discord token from your bot
5) run the project (Note the bot only works while running project)
6) add your bot to discord and to test type !hi into the discord chat, the bot should reply
7) to create a new command  copy the code below into the command class in your project and replace the text "your name" with the name you would like to call it 
8)To test your new function run the project and type !and the name of your command next to it
[Command("Your name")]
        public async Task yourname()
        {
            await ReplyAsync("put your Text in here");
        }


