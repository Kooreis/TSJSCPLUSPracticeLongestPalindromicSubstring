function expandAroundCenter(string, left, right) {
    let L = left, R = right;
    while (L >= 0 && R < string.length && string.charAt(L) === string.charAt(R)) {
        L--;
        R++;
    }
    return R - L - 1;
}