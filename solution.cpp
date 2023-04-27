std::string longestPalindromicSubstring(std::string s) {
    int n = s.size();
    if (n == 0) return "";
    std::string longest = s.substr(0, 1);
    for (int i = 0; i < n; i++) {
        std::string temp = expandAroundCenter(s, i, i);
        if (temp.size() > longest.size()) {
            longest = temp;
        }
        temp = expandAroundCenter(s, i, i + 1);
        if (temp.size() > longest.size()) {
            longest = temp;
        }
    }
    return longest;
}