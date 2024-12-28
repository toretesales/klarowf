![Klaro]()
<img src="https://github.com/user-attachments/assets/07d84004-135f-4153-a5fa-ed60c17fcad9" alt="Klaro logo" width="500">

# KlaroWF
*Klaro built on Windows Forms*
- A barebones GUI wrapper for Jpeg2png in C#.NET and Windows Forms.


<img src="https://github.com/user-attachments/assets/0e4cd9f2-188f-467b-9da9-0c2857fcdaa4" alt="Screenshot of Klaro with an image and a faux terminal preview." width="500">


## Notice
Klaro is absolutely barebones that it doesn't even have a way to set flags provided by Jpeg2png, some bugs
might appear that I haven't come across as of yet.

I'm not sure if it is possible for me to maintain this project as I only made this because I got tired of having to
execute commands and the tedious process of putting unconverted JPEGs on a specific folder then having to move the converted
files to where I want to put them.

The application is built on C#.NET and Windows Forms because that's what my professors taught me before I
graduated and shifted to a different program on college.

## Features
- Decodes and converts JPEG files to PNGs by utilising Jpeg2png.
- Have the ability to select a file from one directory and have the converted file to a different one.
- Utilise a workaround to do conversions more than one file at the same time by using a `foreach` loop for every image that was selected through Klaro.

 

