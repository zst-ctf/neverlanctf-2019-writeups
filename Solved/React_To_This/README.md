# React To This
Web

## Challenge 

It looks like someone set up their react site wrong...

https://challenges.neverlanctf.com:1145


## Solution

Look through source code

	<script type="text/javascript" src="/static/js/main.237378d2.js"></script>

And then view the JS code

    value: function() {
        var e = "You are not an admin.";
        return this.props.admin ? 

        e = s.a.createElement(s.a.Fragment, null, s.a.createElement("div", {
            className: "banner",
            align: "center"
        }, 
        
        s.a.createElement("h1", null, "Welcome to the Admin Page!")), s.a.createElement(c.Columns, null, s.a.createElement(c.Column, {
            align: "center"
        }, 

        s.a.createElement("p", null, "f", "l", "a", "g", "{s3cur3_y0ur_s3ss10ns}"))))

        : window.history.back(), e
    }

We see the flag

	"f", "l", "a", "g", "{s3cur3_y0ur_s3ss10ns}"

## Flag

	flag{s3cur3_y0ur_s3ss10ns}