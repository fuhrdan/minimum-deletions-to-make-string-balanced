//*****************************************************************************
//** 1653. Minimum Deletions to Make String Balanced  leetcode               **
//** Solution in C.  Started with a left and right, then moved into one-side **
//**                                                                -Dan     **
//*****************************************************************************


int minimumDeletions(char* s) {
    int n = strlen(s);
    int countB = 0; 
    int minDeletions = 0;

    for (int i = 0; i < n; ++i) {
        if (s[i] == 'b') {
            ++countB;
        } else {
            if (countB > 0) {
                ++minDeletions;
                --countB;
            }
        }
    }

    return minDeletions;
}