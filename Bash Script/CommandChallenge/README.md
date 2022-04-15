# Solutions of Command Challenges(cmdchallenge)
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
* Used commands detailed descriptions: 
    * [rm](https://man7.org/linux/man-pages/man1/rm.1.html)
    * [find](https://man7.org/linux/man-pages/man1/find.1.html)

```
rm -r $(find .)

```

## Challenge 12 - "Deleting Files as Type"
* There are files in this challenge with different file extensions. Remove all files with the .doc extension recursively in the current working directory.
* Used commands detailed descriptions: 
    * [rm](https://man7.org/linux/man-pages/man1/rm.1.html)
    * [find](https://man7.org/linux/man-pages/man1/find.1.html)

```
rm -r $(find -type f -name "*.doc")

```

## Challenge 13 - "Printing All Lines Which Include Given Value"
* There is a file named access.log in the current working directory. Print all lines in this file that contains the string "GET".
* Used command detailed description: [grep](https://man7.org/linux/man-pages/man1/grep.1.html)

```
grep GET access.log

```

## Challenge 14 - "Printing File Names Which Include Given Value"
* Print all files in the current directory, one per line (not the path, just the filename) that contain the string "500".
* Used command detailed description: [grep](https://man7.org/linux/man-pages/man1/grep.1.html)

```
grep -l 500 *

```

## Challenge 15 - "Printing Relative Paths Which Start With Given Value"
* Print the relative file paths, one path per line for all filenames that start with "access.log" in the current directory.
* Used command detailed description: [ls](https://man7.org/linux/man-pages/man1/ls.1.html)

```
ls -d access.log*

```

## Challenge 16 - "Searching Recursive and Using Piping"
* Print all matching lines (without the filename or the file path) in all files under the current directory that start with "access.log" that contain the string "500".
* Note that there are no files named access.log in the current directory, you will need to search recursively.
* Used commands detailed descriptions: 
    * [ls](https://man7.org/linux/man-pages/man1/ls.1.html)
    * [find](https://man7.org/linux/man-pages/man1/find.1.html)
    * [grep](https://man7.org/linux/man-pages/man1/grep.1.html)

```
ls | find ./ -type f -name "*access.log*" | grep -r -h "500"

```

## Challenge 17 - "Finding IP Addresses From Given Files"
* Extract all IP addresses from files that start with "access.log" printing one IP address per line.
* Used commands detailed descriptions: 
    * [find](https://man7.org/linux/man-pages/man1/find.1.html)
    * [grep](https://man7.org/linux/man-pages/man1/grep.1.html)

```
find . -name "access.log*" | grep -r -o ^[0-9.]* 

```

## Challenge 18 - "Counting the Number of Files in Current Directory"
* Count the number of files in the current working directory. Print the number of files as a single integer.
* Used commands detailed descriptions: 
    * [ls](https://man7.org/linux/man-pages/man1/ls.1.html)
    * [wc](https://man7.org/linux/man-pages/man1/wc.1.html)

```
ls -l | wc -l

```

## Challenge 19 - "Printing sorted Contents"
* Print the contents of access.log sorted.
* Used commands detailed descriptions:
    * [cat](https://man7.org/linux/man-pages/man1/cat.1.html)
    * [sort](https://man7.org/linux/man-pages/man1/sort.1.html)

```
cat access.log | sort

```

## Challenge 20 - "Counting Number of Lines from Given File"
* Print the number of lines in access.log that contain the string "GET".
* Used commands detailed descriptions:
    * [find](https://man7.org/linux/man-pages/man1/find.1.html)
    * [grep](https://man7.org/linux/man-pages/man1/grep.1.html)
    * [wc](https://man7.org/linux/man-pages/man1/wc.1.html)

```
find ./ -type f -name "access.log" | grep -r -h "GET" | wc -l

```

## Challenge 21 - "Splitting on a Char"
* The file split-me.txt contains a list of numbers separated by a ; character. Split the numbers on the ; character, one number per line.
* Used commands detailed descriptions:
    * [cat](https://man7.org/linux/man-pages/man1/cat.1.html)
    * [sed](https://man7.org/linux/man-pages/man1/sed.1.html)

```
cat ./split-me.txt | sed s/\;/\\n/g

```

## Challenge 22 - "Printing x to y"
* Print the numbers 1 to 100 separated by spaces.
* Used commands detailed descriptions: [echo](https://man7.org/linux/man-pages/man1/echo.1.html)

```
echo {1..100}

```

## Challenge 23 - "Deleting Sentence which is given in File"
* This challenge has text files (with a .txt extension) that contain the phrase "challenge are difficult". Delete this phrase from all text files recursively.
* Note that some files are in subdirectories so you will need to search for them.
* Used commands detailed descriptions: 
    * [find](https://man7.org/linux/man-pages/man1/find.1.html)
    * [sed](https://man7.org/linux/man-pages/man1/sed.1.html)
    * [exec](https://man7.org/linux/man-pages/man3/exec.3.html)
    * NOTE: if you don't want to get "find: missing argument to `-exec'" error while running command in terminal, you should put "{} \;" end of the code while using "-exec" command.

```
find -type f -name "*.txt" -exec sed -i "challenge are difficult" {} \;

```
