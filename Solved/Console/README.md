# Console
Web

## Challenge 

You control the browser

https://challenges.neverlanctf.com:1120

## Solution

From the inline Javascript

	function what(){
        var input = document.getElementById("pass").value;
        if( md5(input) == "7b1ece53a46f4a5a2995b9cf901bf457" ){
           getThat('Y');
        }else{getThat('N')}
    }
    function getThat(strg){
        if(strg == 'Y'){
			// Note: There is no data sent to the key.php file...
			// jquery ajax reference: https://api.jquery.com/jQuery.ajax/
            $.ajax({
                type: 'GET',
                url: '1/key.php',
                success: function (file_html) {
                    // success
                   foo.innerHTML=(file_html)
                }
            });
        }else{
            foo.innerHTML = "Nope, try again";
            
        }
    }

The input is passed through MD5 and compared to `"7b1ece53a46f4a5a2995b9cf901bf457"`.

We can bypass that by calling the function directly in console:

    getThat('Y')

The page returns this

	It's not that easy, but nice try. 
	Go back and try again

---

A few days later I tried the exact same thing but this time it returned the flag. Apparently, the organisers didn't even mention that they updated the challenge -.-

calling the function directly in console:

    getThat('Y')

The page returns this

    Password: flag{console_controls_js}

## Flag

	flag{console_controls_js}
