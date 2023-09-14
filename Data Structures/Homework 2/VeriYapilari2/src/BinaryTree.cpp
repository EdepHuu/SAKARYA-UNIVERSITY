/**
* @file G211210031_G201210073
* @description main methodu
* @course 1. Öğretim A
* @assignment 2. Ödev
* @date 29.07.2023
* @author Metehan Dündar metehan.dundar@ogr.sakarya.edu.tr - Muhammed Sefa Özdemir muhammed.ozdemir12@ogr.sakarya.edu.tr
*/

#include "BinaryTree.hpp"  // BinaryTree sınıfının tanımını içe aktarıyoruz

#include <iostream>  // Standart giriş/çıkış kütüphanesi

TreeNode::TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
// TreeNode yapıcı işlevi: Düğümün değerini ayarlar ve sol/sağ düğüm işaretçilerini boşa ayarlar

void BinaryTree::postOrder(TreeNode* node) const {
    if (!node) return;
    postOrder(node->left);   // Sol alt ağacı postorder dolaş
    postOrder(node->right);  // Sağ alt ağacı postorder dolaş
    std::cout << (char)node->val << " ";  // Düğüm değerini ekrana yazdır
}

void BinaryTree::insert(int value, TreeNode*& node) {
    if (!node) {
        node = new TreeNode(value);  // Düğüm yoksa yeni düğüm oluştur
        return;
    }
    if (value == node->val) return;  // Değer zaten varsa ekleme yapma
    if (value < node->val) {
        insert(value, node->left);    // Düğümün sol alt ağacına ekle
    }
    else {
        insert(value, node->right);   // Düğümün sağ alt ağacına ekle
    }
}

int BinaryTree::height(TreeNode* node) const {
    if (!node) return 0;
    int leftHeight = height(node->left);    // Sol alt ağacın yüksekliği
    int rightHeight = height(node->right);  // Sağ alt ağacın yüksekliği
    return std::max(leftHeight, rightHeight) + 1;  // Maksimum yüksekliği hesapla ve bir artır
}

int BinaryTree::sum(TreeNode* node) const {
    if (!node) return 0;
    return node->val + sum(node->left) + sum(node->right);  // Düğümlerin değerlerini topla
}

void BinaryTree::destroyTree(TreeNode* node) {
    if (!node) return;
    destroyTree(node->left);   // Sol alt ağacı sil
    destroyTree(node->right);  // Sağ alt ağacı sil
    delete node;               // Düğümü bellekten sil
}

void BinaryTree::insert(int value) {
    insert(value, root);  // Ağaca yeni bir değer eklemek için yardımcı işlevi çağır
}

void BinaryTree::postOrder() const {
    postOrder(root);  // Ağacı postorder dolaşmak için yardımcı işlevi çağır
}

int BinaryTree::height() const {
    return height(root);  // Ağacın yüksekliğini hesaplamak için yardımcı işlevi çağır
}

int BinaryTree::sum() const {
    return sum(root);  // Ağacın düğümlerindeki değerleri toplamak için yardımcı işlevi çağır
}

BinaryTree::~BinaryTree() {
    destroyTree(root);  // Ağacı bellekten silmek için yardımcı işlevi çağır
}
