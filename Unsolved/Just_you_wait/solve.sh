for i in {14..0}; do
    export TZ="Etc/GMT-$i";
    echo "===================================";
    echo "Timezone: $TZ";
    curl -s https://challenges.neverlanctf.com:1140 | grep "To whomever it may concern: ";
done

for i in {0..14}; do
    export TZ="Etc/GMT+$i";
    echo "===================================";
    echo "Timezone: $TZ"
    curl -s https://challenges.neverlanctf.com:1140 | grep "To whomever it may concern: ";
done