#include<iostream>
using namespace std;
int main(void){
    cin.tie(0);
    ios::sync_with_stdio(0);
    int n, m, mini, maxi, a, c;
    char b;
    cin>>n>>m;
    map<int, pair<bool, bool> > x;
    map<int, pair<bool, bool> > y;
    for(int i = 0; i<n; i++){
        x[i] = {1,1};
        y[i] = {0,0};
    }
    maxi = n;
    mini = 0;
    while(m--){
        cin>>a>>b>>c;
        if(c==1){
            bool changes = 0;
            if(b=='P'&&!y[i].first){
                y[i].first = 1;
                changes = 1;
            }else if(b=='M'&&!y[i].second){
                y[i].second = 0;
                changes = 1;
            }if(changes&&y[i].first&&y[i].second){
                mini++;
            }
        }else{
            bool changes = 0;
            if(b=='P'&&x[i].first){
                x[i].first = 0;
                changes = 1;
            }else if(b=='M'&&x[i].second){
                x[i].second = 0;
                changes = 1;
            }if(changes&&!x[i].first&&!x[i].second){
                maxi--;
            }
        }
    }
    cout<<mini<<" "<<maxi;
}