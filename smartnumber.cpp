#include <iostream>
#include <cmath>

using namespace std;

bool result(int number){
    int sqr = sqrt((float)number);
    if (sqr * sqr == number)
    {
        return true;
    }
    else return false;
}

int main(){
    int n;
    cin>>n;
    int num;
    for (int i = 0; i < n; i++){
        cin>>num;
        if(result(num))
            cout<<"YES"<<endl;
        else cout<<"NO"<<endl;
    }
    return 0;
}
    
