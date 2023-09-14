#ifndef BINARYTREE_HPP
#define BINARYTREE_HPP

class TreeNode {
public:
    int val;
    TreeNode* left;
    TreeNode* right;
    TreeNode(int x);
};

class BinaryTree {
    TreeNode* root = nullptr;

    // Postorder dolaşma fonksiyonu
    void postOrder(TreeNode* node) const;

    // Ağaca yeni bir düğüm eklemek için kullanılan fonksiyon
    void insert(int value, TreeNode*& node);

    // Ağacın yüksekliğini hesaplamak için kullanılan fonksiyon
    int height(TreeNode* node) const;

    // Ağaçtaki düğümlerin değerlerini toplamak için kullanılan fonksiyon
    int sum(TreeNode* node) const;

    // Ağacı yok etmek ve hafızayı serbest bırakmak için kullanılan fonksiyon
    void destroyTree(TreeNode* node);

public:
    // Yeni bir değer eklemek için kullanılan işlev
    void insert(int value);

    // Ağacı postorder şeklinde dolaşan işlev
    void postOrder() const;

    // Ağacın yüksekliğini hesaplayan işlev
    int height() const;

    // Ağaçtaki düğümlerin değerlerini toplamayı sağlayan işlev
    int sum() const;

    // Yıkıcı (destructor) işlev, ağacı bellekten siler
    ~BinaryTree();
};

#endif // BINARYTREE_HPP
