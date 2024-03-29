=============================================
LIMITLESS by Geoff Clark
PUBLISHED by CLARKTRIBEGAMES LLC
VERSION ALPHA 0.1.007.0013
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

ALPHA 0.1.007.0013 / 2021.11.26 - The Revamp

- redesigned the gui to have the menu buttons on the left
- removed the options and editor for redesign
- nulled out the functions for options and editor
- fixed issue with some dll calls crashing the game
- updated the updater method for new update server
- removed some unused code
- expanded about section, adding reddit, twitter, web, email
- removed donate section and merged paypal and patreon links into about
- shifted main menu buttons around
- corrected a grammar error in about and added names of my kids :)
- added borders for update and about pages
- disabled editor and option buttons (for now)
- removed about panel in exchange for an about dialog box
- hid other buttons for future use
- added readme and license info access to about page
- added built in doc reader for text files
- removed typewriter effect from about page to prevent thread crashes
- removed update panel in exchange for an update dialog box
- added current/recommended database versions to update section
- removed redundant logger and jukebox modules
- fixed query errors when there is no internet connection
- added query of database versions in updater
- left future functionality of database update available in updater
- removed options panel in exchange for an options dialog box
- removed static color theme configs
- added custom colors to settings with dark and lite modes as defaults
- added avatar options panel
- added features to display avatar image, dimensions, rename and delete avatars within the avatar dir
- changed rename and delete to be universal for options
- added import feature for options
- added game status dashboard at opening of options
- removed some old optioner code
- created colors options menu with full range editing
- expanded colors in memory to full color spectrum range
- created method to read color mode from settings and apply them to options
- added ability to switch between modes in option menu
- created internal folder structure to break out forms and classes
- added ability to add new, delete, rename, set active, and copy themes
- removed older colors related code from previous version
- added theme description with ability to edit the description
- added randomizer button and function for color themes as an option
- added database option section
- added ability to create new blank, duplicate, import, rename, delete, and set active database files
- removed lastdb from settings and memory, only using defaultdb now
- updated references to lastdb as defaultdb
- removed old code again
- built music options section
- added function to pull duration times for audio files selected
- added buttons for setting custom audio, music turn on and off, and reset music to default
- added function to read settings and display current music assignments
- created logic for checking for default audio, updating audio with custom tracks, and updating the settings file appropriately
- added logic for music turn on and off and reset music to default
- added jukebox to switch to intro when stop preview is click or if the option window closes
- placeholder form for editor and ported over legacy editor code to new form
- created editor menu form and class
- added add edit copy delete import search multimode select-all and clear buttons - but only add edit copy delete will be active for now
- temporary disable and hide buttons added for buttons that are inactive
- added search filter for finding items faster
- editor dropdown populates editable tables in the database
- editor dropdown will show all editable items in the editor list
- classifications, charms, handhelds, wearables, items have to have special queries built in order for their results to be accurate
- added item description and count to editor display
- added active database name to editor
- added select category or double click item instruction at bottom of editor
- removed samedb setting as it will not be used now
- added hidden editor categories from the db to be edited in mod maker mode
- added mod maker mode for editing all tables in editor, not just the main ones
- added proficiencies, modifiers, and ability modifiers to database tables for future use
- modified some tables core fields to optimize future plans
- added editor for editor categories - mainly just the ability to turn categories on or off when not in mod maker mode
- added stats table to database
- added editor ui for abilities with functionality

[PREVIOUS UPDATES]

ALPHA 0.1.006.0011 / 2021.08.18 - The Editor Update - Character Menu

- added race specific force, ability, and effect assignments in character editor
- added character edit cancel button functionality
- added heart as default life force item
- added itemMax to items table
- added ForceObtain and Existence tables to database
- added functionality to the + button to add new characters from character menu
- added queries for various fields in character menu to populate dropdowns and list
- completed character editor design and quickadd and inventory management design windows
- fixed global issue with listboxes not deslecting when focus is lost
- added all fields and effects for buttons for character menu
- integrated aliases into character menu and changed alias button to language button
- added character editor fields and dropdowns along with image for avatar
- added placeholder label for system testing fields to be displayed
- added language table to database and default database
- added multiverse, language, and misc field for characters in database
- added about, donate, exit, update, options, settings, and editor modules and removed them from main
- transfer of mini modules from main to respective locations
- reduced the number of library files required to be physically in install folder, now embedded into game
- added newgame module for future use
- change update version check to use new update server
- added assembly encryption
- added ClarkTribeGames LLC digitial signature

ALPHA 0.1.006.0003 / 2021.07.29 - The Editor Update

- create pages for each editor section with functional query list
- created custom dropdown filler queries for editor dropdowns
- recoded color mode change to not require restart of game
- set custom color option to hidden until further notice
- added switch database functionality
- added clone and delete database buttons and functionality
- added ability to custom named create baseline database from menu
- added functionality to navigate databases and show names and version numbers on menu
- added dropdown to show all databases in data folder
- designed editor baseline menu (may change as development progresses) with inactive buttons for now
- created elements, info, itemclass, and multiverse tables for new db
- ported age, alignment, arenas (formerly areas), environments, sections, and size tables to new db format
- created baseline database for default game to build upon
- added baseline database builder function for players that want a blank db
- embedded ClarkTribeGames Updater into the main exe
- updated welcome screen to support up to 12 random avatars
- fixed issue with dark/lite mode checkboxes not working correctly
- fixed issue with settings not saving in certain scenarios
- added image resizer for imported avatars

ALPHA 0.1.005.0002 / 2021.07.22 - The Updater Update

- enabled update button
- added check for available update on server vs installed version of game
- added cosmetics for update notifications
- added logic for checking available update vs current version
- added ClarkTribeGames Updater 3rd party app as an exe with the application
- added updater functionality
- embedded updater into resources and created method for auto installing updater if not exists

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