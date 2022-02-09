#include <iostream>
using namespace std;
struct Node
{
    int data, ht;
    Node *left, *right;
};
Node* insertNode(Node*, int);
int Height(Node*);
void InOrder(Node*);
void PreOrder(Node*);
int BalanceFactor(Node*);
Node* BalanceNode(Node*);
Node* leftRotate(Node*);
Node* rightRotate(Node*);
int main()
{
    Node* root = NULL;
    int n, data;
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        cin >> data;
        root = insertNode(root, data);
    }
    cin >> data;
    root = insertNode(root, data);
    InOrder(root);
    cout << endl;
    PreOrder(root);
    return 0;
}
Node* leftRotate(Node* root){
     Node* ptr;
     ptr = root->right;
     root->right = ptr->left;
     ptr->left = root;
     return ptr;
}
Node* rightRotate(Node* root){
     Node* ptr;
     ptr = root->left;
     root->left = ptr->right;
     ptr->right = root;
     return ptr;
}
int BalanceFactor(Node *root){
    return Height(root->left) - Height(root->right);
}
Node* BalanceNode(Node *ptr){
    Node* temp;
     if (ptr->left != NULL)
          ptr->left = BalanceNode(ptr->left);
     if (ptr->right != NULL)
          ptr->right = BalanceNode(ptr->right);
     if (BalanceFactor(ptr) > 1){
          if (BalanceFactor(ptr->left) < 0)
               ptr->left = leftRotate(ptr->left);
          ptr = rightRotate(ptr);
     }
     else if (BalanceFactor(ptr) < -1){
          if (BalanceFactor(ptr->right) > 0)
               ptr->right = rightRotate(ptr->right);
          ptr = leftRotate(ptr);
     }
     ptr->ht = Height(ptr);
     return ptr;
}
Node* insertNode(Node * root, int data){
    Node* ptr = (Node*) malloc(sizeof(Node));
    ptr->data = data;
    ptr->left = NULL;
    ptr->right = NULL;
    if(root == NULL)
        return ptr;
    else if(root->data > data)
        root->left = insertNode(root->left, data);
    else if(root->data < data)
        root->right = insertNode(root->right, data);
    root->ht = Height(root);
    root = BalanceNode(root);
    return root;
}
int Height(Node *root){
    int height = 0;
    if(root != NULL){
        height = Height(root->left) > Height(root->right) ? Height(root->left) : Height(root->right);
        height++;
        root->ht = height;
    }
    return height;
}
void InOrder(Node* root){
    if(root != NULL){
        InOrder(root->left);
        cout << root->data << "(BF=" << BalanceFactor(root) <<") ";
        InOrder(root->right);
    }
}
void PreOrder(Node* root){
    if(root != NULL){
        cout << root->data << "(BF=" << BalanceFactor(root) <<") ";
        PreOrder(root->left);
        PreOrder(root->right);
    }
}   