Here is a JavaScript solution for finding the longest palindromic substring in a given string:

```javascript
function longestPalindromicSubstring(string) {
    let start = 0;
    let end = 0;
    for (let i = 0; i < string.length; i++) {
        let len1 = expandAroundCenter(string, i, i);
        let len2 = expandAroundCenter(string, i, i + 1);
        let len = Math.max(len1, len2);
        if (len > end - start) {
            start = i - Math.floor((len - 1) / 2);
            end = i + Math.floor(len / 2);
        }
    }
    return string.substring(start, end + 1);
}

function expandAroundCenter(string, left, right) {
    let L = left, R = right;
    while (L >= 0 && R < string.length && string.charAt(L) === string.charAt(R)) {
        L--;
        R++;
    }
    return R - L - 1;
}

console.log(longestPalindromicSubstring("babad")); // Output: "bab"
console.log(longestPalindromicSubstring("cbbd")); // Output: "bb"
```

This console application can be run in a Node.js environment or any JavaScript console. It will print the longest palindromic substring of the input string.