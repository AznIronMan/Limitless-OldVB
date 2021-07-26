=============================================
LIMITLESS by Geoff Clark
VERSION ALPHA 0.1.005.0002
=============================================

SUPPORT THE DEVELOPMENT OF THIS GAME @ 

 https://www.patreon.com/clarktribegames
 https://paypal.me/aznblusuazn

JOIN THE COMMUNITY ON FACEBOOK OR DISCORD

  https://facebook.com/clarktribe.games
  https://discord.gg/6kW4der

=============================================

This game only works on Microsoft Windows
(Windows 10 1809 or higher recommended) and
does require Microsoft .NET Framework 4.7.2
or higher.

http://go.microsoft.com/fwlink/?linkid=863265

=============================================

ABOUT THIS GAME

LIMITLESS is an arena game that will be 
completely customizable.  It is a homage to 
the old school late 80's-90's RPG games, 
specifically the turn based battle.  This 
game will be completely customizable.  Some
of the features will include the ability to
"level up" your chosen character, the NPC 
players to "level up", and an option for the
game world to develop while not in game play.

This is very early development, not playable 
at this time.

This game was inspired by the author's kids 
and their love for arena/simulation games and
the author's enjoyment of late 80's-90's RPG 
games.

Music in Limitless provided by BenSound.com 
Please check out their site for awesome free
music! -- https://www.bensound.com

See the TODO.txt for developing ideas/features
on https://github.com/AznBlusuazn/Limitless/

Copy of this code without the content of the 
Author is prohibited.

Contact the author:  info@clarktribegames.com

=============================================

COPYRIGHT AND TRADEMARK DISCLAIMER

*ALL PRODUCT AND COMPANY NAMES ARE TRADEMARKS
OR REGISTERED(R) TRADEMARKS OF THEIR
RESPECTIVE HOLDERS.  USE OF THEM DOES NOT
IMPLY ANY AFFILIATION WITH OR ENDORSEMENT BY
THEM.*

=============================================

DEVELOPMENT NOTES

[CURRENT UPDATE]

ALPHA 0.1.005.0002 / 2021.07.22 - The Updater Update

- enabled update button
- added check for available update on server vs installed version of game
- added cosmetics for update notifications
- added logic for checking available update vs current version
- added ClarkTribeGames Updater 3rd party app as an exe with the application
- added updater functionality
- embedded updater into resources and created method for auto installing updater if not exists

[PREVIOUS UPDATES]

ALPHA 0.1.004.0002 / 2021.07.20 - The Menu Bar Update

- gui change - moved menu bar to the top of the app and reduced logo, giving increasing the usable space
- adjusted spacing for all menus per new window format
- changed size of menu buttons to squares in menu bar
- added hidden save button for future use
- added placeholder null button for future use
- adjusted colors for disabled and donate buttons in light and dark modes
- enabled editor button with placeholder panel
- added visibility features for panels based on button pressed
- added confirmation for exit game
- fixed custom file edit name box not going to read only when changing menus
- fixed select track buttons not disappearing when unchecked
- added autosave feature to options (bypasses most are you sure prompts)
- added new menu bar icons

ALPHA 0.1.003.0004 / 2021.07.17 - The Options Update

- changed versioning to 0.1.x for the new platform
- added legacy notes document as a reference to the legacy platform
- added feature to pull custom items (avatars, sound, music) into the options menu
- added ability to play (preview) custom music and sounds in options menu
- added ability to set custom items (avatars, sound, music) to active/inactive states in options
- fixed custom option menu transformation
- fixed feature to create music and sound folders if they do not exist
- removed redundant file name box in custom items options
- added feature to display file names on custom items as they are selected
- added feature for custom avatar preview in options menu
- fixed issue with music tracks not stopping when new music starts
- fixed issue with music files not unlocking when previewing
- added ability to rename, import, and delete custom files in menu
- added MP3 image for custom music/sounds menus
- added log file and logger module for troubleshooting exception errors
- added ability to select custom tracks for intro, battle, victory, and defeat music
- added checks for intro music changes
- added checks if custom track is not available to default to built in tracks
- fix some button highlighting errors

ALPHA 0.1.002.0003 / 2021.04.30

- added universal manage library form and framework to update as manage buttons are pressed
- enabled custom library management group in options
- simplified some repeating methods in options menu into single variable based functions
- added splice method for custom lines in settings for ability to have multiple custom items assigned to one task
- added enable/disable functionality to option menu check boxes
- added start/stop music upon turning music on and off in options
- added notice to restart game if dark/lite mode is changed
- removed all fantasy names and going with actual names -- the game will be free so no trademark issues
- added uid and version number to options menu
- added dark/lite mode logic with buttons in options menu
- fixed dark/lite mode not loading correctly upon opening -- previously would always default to dark
- fixed db reader and update functions to work correctly with new db
- added trademark disclaimer to readme

ALPHA 0.1.001 / 2021.03.06

- added typewriter effect method as a class 
- completed the porting of the about button with all working links
- created filefolders, avatars, and calculator classes for various functions
- fixed loading bug looking for x86 x64 and enUS folders

ALPHA 0.1.000 / 2021.03.05-2152

- complete overhaul of UI from scratch
- new, clear sql based settings file generates on start
- enabled exit game button
- created database modules for future use
- added buttons to new title screen with hover/leave effect
- created dark mode (default) and light mode with options to add custom color themes in the future
- added jukebox and added looping function for start/stop/continous mp3 audio
- created title panel, footer panel, and framework for main menu panel
- restructure a custom, borderless window at 1366x768 for main window
- added code to update title bar and version number based on release number
- added code to allow all dlls and references to be references in a separate folder instead of install root
- complete rewrite of the game in vb.net for long term compatiblity and portablity
- migrated from accdb to sqlite for performance and portablity
- ported over legacy java code into placeholders for vb.net version (not available for public)
- updated readme to reflect new changes
- created new github (https://github.com/AznBlusuazn/Limitless) and archived the former github

=============================================