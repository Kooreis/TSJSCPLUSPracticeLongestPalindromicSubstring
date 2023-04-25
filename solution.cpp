```cpp
#include <iostream>
#include <string>

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

std::string expandAroundCenter(std::string s, int c1, int c2) {
    int l = c1, r = c2;
    int n = s.size();
    while (l >= 0 && r <= n - 1 && s[l] == s[r]) {
        l--;
        r++;
    }
    return s.substr(l + 1, r - l - 1);
}

int main() {
    std::string s;
    std::cout << "Enter a string: ";
    std::cin >> s;
    std::cout << "Longest palindromic substring: " << longestPalindromicSubstring(s) << std::endl;
    return 0;
}
```