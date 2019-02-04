# BashNinjas Bash Games

---

## Bash 1

### Challenge 

ssh -p 3333 neverlan@157.230.73.80

password:neverlan

	For this challenge you need to get the contents of Welcome.txt

### Solution

	neverlan@son-of-honor:~$ cat Welcome.txt 
     ||S||                   level1 password:                     ||S||
     ||S|<          act-with-honor-and-honor-will-aid-you         ||S|<

---

## Bash 2

### Challenge 

ssh -p 3333 level1@157.230.73.80

Use Bash 1 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	We're going to play hide and seek. I'll hide a file and you seek for it.

### Solution

	level1@son-of-honor:~$ ls -la
		total 32
		drwxr-xr-x 1 level1 level1 4096 Feb  3 07:32 .
		drwxr-xr-x 1 root   root   4096 Jan 29 20:12 ..
		-rw------- 1 level1 level1  220 Aug 31  2015 .bash_logout
		-rw------- 1 level1 level1 3771 Aug 31  2015 .bashrc
		drwx------ 2 level1 level1 4096 Feb  3 07:32 .cache
		-rw------- 1 level1 level1 1127 Jan 29 20:12 .honor-code.txt
		-rw------- 1 level1 level1  329 Jan 29 20:12 .instructions
		-rw------- 1 level1 level1  655 May 16  2017 .profile
	
	level1@son-of-honor:~$ cat .honor-code.txt | tail
		Follow these rules at all times:

		- Only hack things you own
		- Do not hack anything you rely on
		- Respect the rights of others
		- Know the law, the possible risk, and the consequences for breaking it
		- Find a safe playground

		level2 password: the-only-path-to-honor-is-to-stick-to-your-chosen-code

---

## Bash 3

### Challenge 

ssh -p 3333 level2@157.230.73.80

Use Bash 2 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	Ok. So you found the hidden file. How about trying to find the password in plain
	sight? You'll have to figure out how to sift through the muck though...


### Solution

	level2@son-of-honor:~$ la -la
		total 15380
		drwxr-xr-x 1 level2 level2     4096 Feb  3 07:37 .
		drwxr-xr-x 1 root   root       4096 Jan 29 20:12 ..
		-rw------- 1 level2 level2      220 Aug 31  2015 .bash_logout
		-rw------- 1 level2 level2     3771 Aug 31  2015 .bashrc
		drwx------ 2 level2 level2     4096 Feb  3 07:37 .cache
		-rw------- 1 level2 level2      409 Jan 29 20:12 .instructions
		-rw------- 1 level2 level2      655 May 16  2017 .profile
		-rw------- 1 level2 level2 15716962 Jan 29 20:12 canyoufindme.txt

The file is huge with 512985 lines.

	level2@son-of-honor:~$ cat canyoufindme.txt | wc -l
	512985

Let's see the unique lines

	level2@son-of-honor:~$ cat canyoufindme.txt | sort | uniq | wc -l
	29

	$ cat canyoufindme.txt | sort | uniq
	<...>
	know the law, the possible risk, and the consequences for breaking it
	level3:child-of-honor
	neverlan honor code
	neverlan kids focuses on these fundamental truths about the universe:
	<...>

--- 

## Bash 4

### Challenge 

ssh -p 3333 level3@157.230.73.80

Use Bash 3 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	So you know how to use grep or some other similar program. Good for you. Now can
	you do the same thing with a binary file?

### Solution

Knowing that the flag is prepended by `level4:` will speed things up

	level3@son-of-honor:~$ ls
	random
	level3@son-of-honor:~$ strings ./random | grep 'level'
	level4:only*hack^things%you$own

---

## Bash 5
### Challenge 

ssh -p 3333 level4@157.230.73.80

Use Bash 4 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	Nice job on that last level. I'll have to step it up. Alright here is a file,
	but I won't tell you what it is. You'll have to figure that out on your own.

### Solution

	level4@son-of-honor:~$ ls
	nextlevel
	level4@son-of-honor:~$ file nextlevel 
	nextlevel: gzip compressed data, was "principles.txt", last modified: Fri Mar 30 08:05:12 2018, max compression, from Unix

Gunzip

	level4@son-of-honor:~$ gunzip < nextlevel 
	PRINCIPLES

	r00tz kids focuses on these fundamental truths about the universe:

	- The world is one. We are all connected.

	- These connections are growing stronger and faster everyday.

	- Chaos controls the connections.

	- Focus controls the chaos.

	- You control the focus.

	level5:on-my-honor-i-will-do-my-best

---

## Bash 6
### Challenge 

ssh -p 3333 level5@157.230.73.80

Use Bash 5 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	Look around for more guidance.

### Solution

	$ ls
	Syl.jpg  values.txt

	$ cat values.txt
	Oh... and you probably want to pull the image file to your computer and look at it.
	You don't know how to do that? Google is your friend. 
	Something like "Transfer files over SSH" might do the trick.

Simply use use `scp`

	$ scp -P3333 level5@157.230.73.80:Syl.jpg level6.png

![level6.png](level6.png)

have-you-memorized-the-code-yet

--- 

## Bash 7

### Challenge 

ssh -p 3333 level6@157.230.73.80

Use Bash 6 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	Look in level7.txt. You'll have to figure out what to do with that on your own.

### Solution

	level6@son-of-honor:~$ ls
	level7.txt

	level6@son-of-honor:~$ cat level7.txt 
	UlVMRVMKClRoZSBJbnRlcm5ldCBpcyBhIHNtYWxsIHBsYWNlLiBXb3JkIGdldHMgYXJvdW5kLCBmYXN0LgoKRm9sbG93IHRoZXNlIHJ1bGVzIGF0IGFsbCB0aW1lczoKCi0gT25seSBoYWNrIHRoaW5ncyB5b3Ugb3duCgotIERvIG5vdCBoYWNrIGFueXRoaW5nIHlvdSByZWx5IG9uCgotIFJlc3BlY3QgdGhlIHJpZ2h0cyBvZiBvdGhlcnMKCi0gS25vdyB0aGUgbGF3LCB0aGUgcG9zc2libGUgcmlzaywgYW5kIHRoZSBjb25zZXF1ZW5jZXMgZm9yIGJyZWFraW5nIGl0CgotIEZpbmQgYSBzYWZlIHBsYXlncm91bmQKCmxldmVsNzp3aGl0ZS1oYXRzLWhhdmUtdmFsdWVzLWFuZC1ydWxlcwo=

	level6@son-of-honor:~$ cat level7.txt | base64 --decode | tail -1
	level7:white-hats-have-values-and-rules

--- 

## Bash 8
### Challenge 

ssh -p 3333 level7@157.230.73.80

Use Bash 7 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	This is almost the same thing as the last level, just gotta do one more step.

### Solution

	level7@son-of-honor:~$ cat level8.txt | base64 --decode > /tmp/test
	level7@son-of-honor:~$ file /tmp/test
	/tmp/test: gzip compressed data, last modified: Fri Mar 30 07:04:41 2018, from Unix
	
	level7@son-of-honor:~$ gunzip < /tmp/test
		...
		level8:my-wit-ran-out-5-levels-ago

--- 

## Bash 9
### Challenge 

ssh -p 3333 level8@157.230.73.80

Use Bash 8 password

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	Your goal here is to decrypt `level9.enc`. There's a clue around here somewhere.

### Solution


	level8@son-of-honor:~$ cat level9.enc 
	U2FsdGVkX1/RjLebmJbThsz7hNuLEJnRevchxfV4RTonlVjXvbUHFMHnitt/TJSt

	level8@son-of-honor:~$ ls -la
	total 36
	drwxr-xr-x 1 level8 level8 4096 Feb  3 07:58 .
	drwxr-xr-x 1 root   root   4096 Jan 29 20:12 ..
	-rw------- 1 level8 level8  220 Aug 31  2015 .bash_logout
	-rw------- 1 level8 level8 3771 Aug 31  2015 .bashrc
	drwx------ 2 level8 level8 4096 Feb  3 07:58 .cache
	-rw------- 1 level8 level8   46 Jan 29 20:12 .clue
	-rw------- 1 level8 level8  337 Jan 29 20:12 .instructions
	-rw------- 1 level8 level8  655 May 16  2017 .profile
	-rw------- 1 level8 level8   65 Jan 29 20:12 level9.enc
	
	level8@son-of-honor:~$ cat .clue
	aes-256-cbc encryption password: level9please
	
	level8@son-of-honor:~$ openssl enc -aes-256-cbc -d -in level9.enc -k level9please -base64
	level9:please-someone-help


--- 

## Bash 10
### Challenge 

ssh -p 3333 level9@157.230.73.80

Use Bash 9 password

	Level: level9

	Instructions
	═════════════════════════════════════════════════════════════════════════════════
	Congrats. You win. Almost... You've just got to get the flag in final.txt

	-----------------------------------------------------------------
	You didn't say the magic word
	Goodbye
	Connection to 157.230.73.80 closed.

### Solution

From this, it seems that .bashrc is auto-exiting...

https://serverfault.com/questions/94503/login-without-running-bash-profile-or-bashrc

We can bypass this by using `/bin/sh`

	$ sshpass -p 'please-someone-help' ssh -p 3333 level9@157.230.73.80 -t /bin/sh

	You didn't say the magic word
	Goodbye
	/home/level9/.bashrc: line 4: logout: not login shell: use `exit'
	$ ls
	final.txt
	$ cat final.txt
	Congratulations. You are a Child of Honor.

	Final Flag: i-am-now-a-child-of-honor


## Flag

- Bash 1: `act-with-honor-and-honor-will-aid-you`
- Bash 2: `the-only-path-to-honor-is-to-stick-to-your-chosen-code`
- Bash 3: `child-of-honor`
- Bash 4: `only*hack^things%you$own`
- Bash 5: `on-my-honor-i-will-do-my-best`
- Bash 6: `have-you-memorized-the-code-yet`
- Bash 7: `white-hats-have-values-and-rules`
- Bash 8: `my-wit-ran-out-5-levels-ago`
- Bash 9: `please-someone-help`
- Bash 10: `i-am-now-a-child-of-honor`


