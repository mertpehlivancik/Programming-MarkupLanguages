##### 1.
$ cat calories.csv | tr ";" ":" > calories.csv.tmp
$ mv calories.csv.tmp calories.csv

##### 2.
$ cat calories.csv | tr -d '"' > calories.csv.tmp
$ mv calories.csv.tmp calories.csv

##### 3.
$ cut -d":" -f2 calories.csv

##### 4.
$ cut -d: -f1 calories.csv | tr "[:lower:]" "[:upper:]" > first
$ cut -d: -f2- calories.csv | paste first -

##### 5.
$ cut -d: -f1 calories.csv > names_original
$ cat names_original | tr " " "_" > names_modified
$ diff names_original names_modified

##### 6.
$ head -1 calories.csv > header
$ tail -n +2 calories.csv | sort -rn -t: -k3,3 | cat header -

##### 7.
$ head -1 calories.csv > header
$ tail -n +2 calories.csv | sort -n -t: -k5,5 -k6,6 -k7,7 | cat header -

##### 8.
$ cut -d: -f2 calories.csv > second
$ cut -d: -f1,3- calories.csv | paste second -

##### 9.
$ ls -l | cut -c2-10 | tail -n +2

##### 10.
$ ls -l | tr -s " " | cut -d" " -f5,9

##### 11.
$ cut -d: -f1 /etc/passwd | paste -d,  - - - -

