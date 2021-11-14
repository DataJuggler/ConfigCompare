# ConfigCompare
This project is a Windows Forms .Net5 project, that I use to compare the values in app settings between dev machines and / or test or production servers.

To run this program:
Start the program and browse for the Source and Target web.config or app.config files.

Click the Compare button.

You will see any differences listed in the results text box.

This project uses three projects / nuget packages of mine:
1. DataJuggler.Win.Controls - Latest version is for .net 5, soon it will multi-target .Net 5 / 6 if possible
https://github.com/DataJuggler/DataJuggler.Win.Controls

2. DataJuggler.UltimateHelper - I uses this in almost everything
https://github.com/DataJuggler/UltimateHelper

3. XmlMirror5.RunTime - I have a class called FieldValuePair I used to hold the appsettings key value pairs.
https://github.com/DataJuggler/XmlMirror
