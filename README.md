This is a CLI tool designed to provide statistics about Facebook Messenger group chats, when fed a `message.json` file (which can be obtained by downloading your data from facebook), it will spit out:

# Output

## STATS 

**For each member, ordered by quantity**
* How many messages they have sent
* How many gifs they have sent (and what percent of all their messages are gifs)
* How many images they have sent (and what percent of all their messages are images)
* How many links they have sent (and what percent of all their messages are links)
* How many images they have sent (and what percent of all their messages are images)
* How many messages IN ALL CAPS they have sent (and what percent of all their messages are in all caps)
* How much they have sweared (and what percent of all their messages contain profanity)
* How many times they have given each type of reaction
* How many times they have received each type of reaction (and what percent of their messages have received them)
* The average length of their messages (in characters)

**For each member, individually**
* What their most received reaction is
* What their most given reaction is
* A list of who they talk with the most

**Overall**:
* Who is the most ignored (an ignored message is one without a response two minutes later)
* Who has been kicked out the most

## HTML FILE

This tool also generates an `output.html` file in the directory it's run from, which has some really cool plots and the entire console output.

## CSV FILE

* **`output.html`**: A web page containing the entire output of the CLI tool, and some really cool plots
* `messages.csv`: The amount of messages sent by each user
* `love.csv`: The amount of 😍 reactions received by each user
* `hate.csv`: The amount of 😠 reactions received by each user
* `funny.csv`: The amount of 😂 reactions received by each user
* `like.csv`: The amount of 👍 reactions received by each user
* `dislike.csv`: The amount of 👎 reactions received by each user
* `sad.csv`: The amount of 😥 reactions received by each user
* `appreciation.csv`: The day-by-day appreciation of each user

# Usage

This tool swallows up a `message.json` file, which you can download from facebook by going to the [Your Information](https://www.facebook.com/settings?tab=your_facebook_information) page, clicking on "Download Your Information". You should then unselect everything in the list other than "Messages", and choose `JSON` from the `Format` drop-down. Then click on "Create".

Once you have downloaded your file, unzip it, and navigate to `messages\inbox`, and choose whichever conversation you want to analyse. There is your `message.json` file.

You can either double-click the .exe and input a file path, or execute it straight from a terminal, the first argument necessarily being the path of the `message.json` file.


## Third-party licenses

This tool uses [Newtonsoft's JSON.NET](https://github.com/JamesNK/Newtonsoft.Json), covered by the MIT License:

```
The MIT License (MIT)

Copyright (c) 2007 James Newton-King

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```