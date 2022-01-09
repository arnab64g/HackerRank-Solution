#include<iostream>
#include<stack>
using namespace std;
int main()
{
    int n, op, num;
    string s, tem;
    stack<string> stc;
    cin >> n;
    while (n--)
    {
        cin >> op;
        if (op == 1)
        {
            cin >> s;
            if (stc.empty())
            {
                stc.push(s);
            }
            else
            {
                tem = stc.top();
                stc.push(tem + s);
            }
        }
        else if(op == 2)
        {
            cin >> num;
            tem = stc.top();
            
            stc.push(tem.substr(0, tem.length() - num));
        }
        else if(op == 3)
        {
            cin >> num;
            tem = stc.top();
            cout << tem[num-1] << endl;
        }
        else
        {
            stc.pop();
        }
    }
    
}