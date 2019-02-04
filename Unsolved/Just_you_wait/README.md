# Just you wait
Scripting/Coding

## Challenge 

It's going to be a long day... and night.

https://challenges.neverlanctf.com:1140

# Hint

	[1] Just you WAIT
	[2] What timezone is this in? That would be good place to start



## Solution

I opened it at night and On the page we see a night sky.

	To whomever it may concern:
	61 48 52 30 63 48 4d 36 4c 79 39 35 62 33 56 30 64 53 35 69 5a 53 39 6b 55 58 63 30 64 7a 6c 58 5a 31 68 6a 55 51 3d 3d

Convert hex to ascii

	aHR0cHM6Ly95b3V0dS5iZS9kUXc0dzlXZ1hjUQ==

Decode base64. And we get rick-rolled

	$ echo 'aHR0cHM6Ly95b3V0dS5iZS9kUXc0dzlXZ1hjUQ==' | base64 -D
	https://youtu.be/dQw4w9WgXcQ

---

The next day morning, I tried again and I see a clear bright sky

	To whomever it may concern:
	01100001 01001000 01010010 00110000 01100011 01001000 01001101 00110110 01001100 01111001 00111001 00110101 01100010 00110011 01010110 00110000 01100100 01010011 00110101 01101001 01011010 01010011 00111001 01101011 01010101 01011000 01100011 00110000 01100100 01111010 01101100 01011000 01011010 00110001 01101000 01101010 01010101 01010001 00111101 00111101

This also results in a rick roll.

---

Looking at the hint, is it possible to spoof timezones?
https://stackoverflow.com/a/28398154

Apparently it does not work...




## Flag

	??