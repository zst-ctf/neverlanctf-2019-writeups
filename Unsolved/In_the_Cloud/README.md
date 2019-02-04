# In the Cloud
Cloud

## Challenge 

http://neverlanctf.cloud/

## Solution

#### Level 1

	This level is *buckets* of fun. See if you can find the first sub-domain, you'll find the flag along the way.

	Shortcutting with Sublist3r won't get you anywhere. Really. That's the wrong approach.


---

Trying

	$ dig neverlanctf.cloud ANY

	;; ANSWER SECTION:
	neverlanctf.cloud.	2559	IN	SOA	ns1.dynadot.com. hostmaster.neverlanctf.cloud. 1549171353 16384 2048 1048576 2560
	neverlanctf.cloud.	299	IN	NS	ns1.dynadot.com.
	neverlanctf.cloud.	299	IN	NS	ns2.dynadot.com.
	neverlanctf.cloud.	299	IN	CNAME	neverlanctf.cloud.s3-website-us-west-2.amazonaws.com.


	dig +multi AXFR @neverlanctf.cloud.s3-website-us-west-2.amazonaws.com neverlanctf.cloud

## Flag

	??