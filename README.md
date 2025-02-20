# Unity Game Development
This is the repository for development of <unit_game_name>. 

## Local Environment
Follow these steps to set up your local development environment.
### Git
1. Create a free account on [GitHub](https://github.com/)
1. Install Git on your computer by following the instructions at https://git-scm.com/
1. Download and install VSCode (https://code.visualstudio.com/Download).
1. Create an account and download the free version from [Unity's Store](https://store.unity.com/download?ref=personal)
1. Follow the instructions to set up VSCode as the editor for Unity https://code.visualstudio.com/docs/other/unity

## Project Setup

1. Open a new terminal/command line AFTER installing Git 
    > If you already had one open before installing, you need to open a new one otherwise it will not find the new `git` command.
1. Enter the following commands, replacing text in angle-brackets (`<text>`) with the appropriate values:
    ```bash
    # Set your full name, i.e., "John Doe"
	git config --global user.name "<full_name_with_spaces>"

    # Set your email - make sure this matches the email you use for GitHub
	git config --global user.email <email_address_no_quotes>
    
    # Set git to use rebase on pull (results in cleaner git history)
	git config --global pull.rebase true
    ```
1. Make a new directory
    ```ps
    # if you are on Windows
	mkdir C:\projects

    # if you are on Linux
	mkdir /projects
    ```
1. Change directories into your new "projects" folder
    ```ps
    # if you are on Windows
	cd C:\projects

    # if you are on Linux
	cd /projects
    ```
1. Clone the Unity repo and set up Git LFS
    ```ps
    # copies the remote repository from spaceducks/unity-game and puts it into a folder named ProjectForge
	git clone https://github.com/spaceducks/unity-game ProjectForge

    # change directories into your new folder
    cd ProjectForge
    
    # Initialize git LFS
    git lfs install
    ```
1. Open UnityHub then select the Add button and choose the ProjectForge folder to add it to UnityHub
1. Click on the new entry for ProjectForge to launch it in Unity

## Making Changes in the Game

2. Open cmd 

2. Set directory to Project Forge on your computer
   ```ps
   # If your project is in another drive (D-drive)
      D:
   # Then, change to the path your Project Forge is located:
       For example: cd D:\Projects\ProjectForge

2. Check to see if your version of the game is up to date:
   ```ps
   git status

   # If it is not up to date:
   git pull
   
   I recommend doing this step right before you start working on the project, every time.
   
   # If you have changes made locally but need to make a pull
   git stash
   	this moves all of your local changes to another spot, your local copy will appear as though your changes have been deleted if opened at this point
   git pull
   	grabs the latest copy of the files, gets you up to date
   git show
   	shows everything in your stash, if it looks correct proceed
   git stash pop
   	restores stashed changes to your directory of the game, effectively reincluding your changes


2. Once your changes have been made to your unity file, SAVE the file in unity, then:
   ```ps
   git add .

   git commit -m "Any message describing what you did with quotes”

   git push

2. Just to make sure the change was added, check the discord text channel “github” and see if your commit was made



## References:
* Using git with Unity: https://thoughtbot.com/blog/how-to-git-with-unity
* Git LFS: https://git-lfs.github.com/
* Git setup: https://git-scm.com/book/en/v2/Getting-Started-First-Time-Git-Setup
