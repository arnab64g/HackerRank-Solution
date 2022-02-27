#include<iostream>
#include<vector>
#include<queue>
using namespace std;
int main()
{
    int t, n, m, u, v, s, cn;
    cin >> t;
    while (t--){
        cin >> n >> m;
        bool vtd[1001] = {false};
        vector<int> vct[1001];
        int dst[1001] = {0};
        for (int i = 0; i < m; i++){
            cin >> u >> v;
            vct[u].push_back(v);
            vct[v].push_back(u);
        }
        queue<int> q;
        cin >> s;
        q.push(s);
        vtd[s] = true;
        while (!q.empty()){
            cn = q.front();
            q.pop();
            for (int x : vct[cn])
            {
                if(!vtd[x]){
                    dst[x] = dst[cn] + 6;
                    q.push(x);
                    vtd[x] = true;
                }
            }
        }
        for (int i = 1; i <= n; i++){
            if(i == s)
                continue;
            if(dst[i] == 0)
                dst[i] = -1;
            cout << dst[i] << " ";
        }
        cout << endl;   
    }
    return 0;
}