#ifndef NODE_HPP
#define NODE_HPP

class Node {
public:
    int value;      // Düğümün taşıdığı değer
    Node* next;     // Bir sonraki düğümün adresi
    Node(int val);  // Düğüm yapıcı işlevi
};

#endif // NODE_HPP
