Here is a TypeScript console application that solves the problem:

```typescript
function longestPalindromicSubstring(s: string): string {
    if (s.length < 1 || s == null) return "";
    let start = 0, end = 0;
    for (let i = 0; i < s.length; i++) {
        let len1 = expandAroundCenter(s, i, i);
        let len2 = expandAroundCenter(s, i, i + 1);
        let len = Math.max(len1, len2);
        if (len > end - start) {
            start = i - Math.floor((len - 1) / 2);
            end = i + Math.floor(len / 2);
        }
    }
    return s.substring(start, end + 1);
}

function expandAroundCenter(s: string, left: number, right: number): number {
    let L = left, R = right;
    while (L >= 0 && R < s.length && s.charAt(L) == s.charAt(R)) {
        L--;
        R++;
    }
    return R - L - 1;
}

console.log(longestPalindromicSubstring("babad")); // Output: "bab"
console.log(longestPalindromicSubstring("cbbd")); // Output: "bb"
```

This application defines a function `longestPalindromicSubstring` that finds the longest palindromic substring in a given string. It also defines a helper function `expandAroundCenter` that expands a potential palindrome around the center (which could be in between two letters). It then logs the results of calling `longestPalindromicSubstring` with two different test strings.