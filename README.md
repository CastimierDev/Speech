# Speech
A modifiable text adventure engine 

A simple text adventure engine that is highly modifiable with some programming knowledge.


# Example Of A Simple Program:
The following lines (excluding: 1., 2. and 3.) can be copied into the Define class in the function "DefineLines".

1. lines.SetLine("bg", "BLACK", WHITE, 0, 0, 0);
2. lines.SetLine("say", "Hello World", WHITE, 0, 0, 1);
3. lines.SetLine("end", "END", WHITE, 0, 0, 2);

Explanation:
1. Sets the Background (bg) to a png called "BLACK", it is drawn in WHITE (how you normally see the png), than you define the x and y position, last you set when in the timeline it happens.
2. "Says" (shows) the text "Hello World", the text color is set to WHITE, than you define the x and y position, last you set when it happens in the timeline.
3. Ends the program, "END", WHITE and the x and y position don't do anything currently, last you set when it happens in the timeline.


# How Does It Work?
There is a Parser that looks at the command (1st one). Let's say it's a "say" command, than the Parser will see what you put after that (this is reffered to as the "object").
Let's say you set the object to "HELLO". Than the Parser goes to the drawing method and uses the color and two numbers you put in after that (x and y positions) to draw the text.
If you want some event to happen later in the story than you just need to change the last number, the index, and set it to a higher number. The index determines when somehting happens.


# Goal And Progress
My goal is to make a small game with it (maybe 2 hours long or something) and publish it without having to change the entire engine.
I made a short todo-list:

0.1:

Showing text [X]

Showing images [X]

End the game [X]

0.2:

Background [X]

Sound [X]

Music [O]

0.3:

Choice [O]

Branches [O]

Player character(s) with changeable attributes [O]

0.4:

Custom mini games [O]

Read commands and stuff from file [O]

Mouse input [O]
