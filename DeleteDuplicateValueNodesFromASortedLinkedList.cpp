#include<iostream>
using namespace std;
int main()
{
    int t, n, val;
    cin >> t;
    while (t--)
    {
        int a[1001] = {0};
        cin >> n;
        for (int i = 0; i < n; i++)
        {
            cin >> val;
            a[val]++;
        }
        for (int i = 1; i < 1001; i++)
        {
            if(a[i] > 0)
                cout << i << " ";
        }
        cout << endl;
    }
    return 0;
}