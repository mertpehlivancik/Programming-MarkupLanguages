# Solutions of Command Challenges 
There are challenges and their solutions in here. All of challenges belong to "https://cmdchallenge.com/". Thanks to everyone who created such an infrastructure.

Source of these challenges: "https://cmdchallenge.com/"

## Challenge 1 - "Print 'Hello World'"
* Your first challenge is to print "hello world" on the terminal in a single command.
Hint: There are many ways to print text on the command line, one way is with the 'echo' command. Try it below and good luck!

* Used command detailed description: [echo](https://man7.org/linux/man-pages/man1/echo.1.html)  

```
echo "hello world"

```
## Challenge 2 - "Finding Current Directory"
* Print the current working directory.
* Used command detailed description: [pwd](https://man7.org/linux/man-pages/man1/pwd.1.html)

```
pwd

```
## Challenge 3 - "Listing Files"
* List names of all the files in the current directory, one file per line.
* Used command detailed description: [ls](https://man7.org/linux/man-pages/man1/ls.1.html)

```
ls

```

## Challenge 4 - "Printing The Contents"
* There is a file named access.log in the current directory. Print the contents.
* Used command detailed description: [cat](https://man7.org/linux/man-pages/man1/cat.1.html)

```
cat access.log

```

## Challenge 5 - "Printing Last lines"
* Print the last 5 lines of "access.log".
* Used command detailed description: [tail](https://man7.org/linux/man-pages/man1/tail.1.html)

```
tail -5 access.log

```

## Challenge 6 - "Creating File"
* Create an empty file named "take-the-command-challenge" in the current working directory.
* Used command detailed description: [touch](https://man7.org/linux/man-pages/man1/touch.1.html)

```
touch take-the-command-challenge

```

## Challenge 7 - "Creating a Directory"
* Create a directory named tmp/files in the current working directory.
* Hint: The directory "tmp/" doesn't exist, with one command you need to create both "tmp/" and "tmp/files"
* Used command detailed description: [mkdir](https://man7.org/linux/man-pages/man1/mkdir.1.html)

```
mkdir -p tmp/files

```

## Challenge 8 - "Copying File"
* Copy the file named take-the-command-challenge to the directory tmp/files
* Used command detailed description: [cp](https://man7.org/linux/man-pages/man1/cp.1.html)

```
cp take-the-command-challenge tmp/files 

```

## Challenge 9 - "Moving File"
* Move the file named take-the-command-challenge to the directory tmp/files
* Used command detailed description: [mv](https://man7.org/linux/man-pages/man1/mv.1.html)

```
mv take-the-command-challenge tmp/files 

```

## Challenge 10 - "Creating Symbolic(Soft) Link"
* A symbolic link is a type of file that is a reference to another file. Create a symbolic link named take-the-command-challenge that points to the file "tmp/files/take-the-command-challenge".
* Used command detailed description: [ln](https://man7.org/linux/man-pages/man1/ln.1.html)

```
ln -s tmp/files/take-the-command-challenge take-the-command-challenge 

```

## Challenge 11 - "Deleting All Files"
* Delete all of the files in this challenge directory including all subdirectories and their contents.
* Hint: There are files and directories that start with a dot ".", "rm -rf *" won't work here!
* Used command detailed description: 
** [rm](https://man7.org/linux/man-pages/man1/rm.1.html)
** [find](https://man7.org/linux/man-pages/man1/find.1.html)

```
rm -r $(find .)

```

