#include <iostream>
#include <cmath>
#include <algorithm>
using namespace std;

int main()
{
    int n, s;
    cin>>n>>s;
    int a[s];
    int max = 0, temp;
    for (int i = 0; i < s; i++)
    {
        cin>>a[i];
    }
    sort(a, a+s);
    for (int i = 1; i < s; i++)
    {
        temp = abs(a[i]-a[i-1]);
        if (temp > max)
        {
            max = temp;
        }
    }
    max /= 2;
    cout<<max<<endl;
    
    
    return 0;
}