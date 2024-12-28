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

## Installation

There is no installer Klaro but you can download the latest version on the releases page
and extract the zip to any directory, but I recommend extracting it somewhere you can quickly access if ever you
wish to remove Klaro from your computer like extracting it to the Downloads folder.

If `jpeg2png.exe` is not included when you extracted the .zip file, you may download it from
here: https://github.com/victorvde/jpeg2png

And place `jpeg2png` on the same folder as `KlaroWF.exe`

### Optional

This one is optional but if you want to access Klaro on the start menu or add
the ability to pin it to the taskbar you can do so with this:

Go to the folder of where `KlaroWF.exe` is located

Right click `KlaroWF.exe` > `Create shortcut`
If you're on Windows 11, right click `KlaroWF.exe` > `Show more options` > `Create shortcut`

<img src="https://github.com/user-attachments/assets/b952f003-b30c-456b-9ebd-d3c7bbddebad" alt="A" width="300">


Rename the shortcut to anything you wish.

<img src="https://github.com/user-attachments/assets/7263cb7b-7dd0-4eb1-8f26-4d53cee86875" alt="B" width="200">


Now head to the Start Menu folder, typically you can access it by:
C:\ProgramData\Microsoft\Windows\Start Menu\Programs

Or, if you have installed any windows programs with a traditional installer wizard, open the start
menu and right click any programs you've installed that used an installer wizard.

Once you've right click an app, click `More` > `Open file location`

And move the shortcut to that folder. 

<img src="https://github.com/user-attachments/assets/c494dd91-92b0-4fd9-8e87-97ddf1bf2115" alt="A" width="400">


And it should appear immediately, if not, you might need to wait for a few seconds.

<img src="https://github.com/user-attachments/assets/9b868c48-59c2-40c4-ad5b-1511cff67d3d" alt="A" width="300">


 

