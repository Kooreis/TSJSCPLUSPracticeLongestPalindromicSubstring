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