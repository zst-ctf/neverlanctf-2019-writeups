# Binary 1
Binary

## Challenge 

A user accidentally installed malware on their computer and now the user database is unavailable. Can you recover the data and the flag?

Flag is All Caps

[users_db](users_db)

## Solution

We see all hex inside `users_db`

Convert to ASCII

	# cat file, remove newlines, then convert to ascii
	$ cat users_db | tr -d '\n' | xxd -r -p > output.txt

Now inside `output.txt` we see a base64 string. 

	$ cat output.txt | base64 -D > output2.txt

And we find the flag.

	$ grep -E -o ".{5}flag.{50}" output2.txt
	il":"flag{ENC0D1NG_D4TA_1S_N0T_ENCRY7I0N}","address":{"stre

## Flag

	flag{ENC0D1NG_D4TA_1S_N0T_ENCRY7I0N}
