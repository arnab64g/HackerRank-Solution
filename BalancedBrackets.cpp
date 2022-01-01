#include<iostream>
#include<stack>
using namespace std;
int main()
{
    
    int n;
    
    cin >> n;
    while (n--)
    {
        stack<int> s;
        int len;
    string str;
    bool found, res;
        cin >> str;
        len = str.length();
        res = true;
    
        for (int i = 0; i < len; i++)
        {
            if(str[i] == '{' || str[i] == '(' || str[i] == '[')
                s.push(str[i]);
            else if(!s.empty())
            {
                if(str[i] == ')' && s.top() == '(')
                    s.pop();
                else if(str[i] == '}' && s.top() == '{')
                    s.pop();
                else if(str[i] == ']' && s.top() == '[')
                    s.pop();
                else {
                    res = false;
                    break;
                }
            }
            else
            {
                res = false;
                break;
            }
            
        }
        
        if(res && s.empty())
            cout << "YES" << endl;
        else cout << "NO" << endl;
        
    }
    return 0;
}
