#ifndef STACK_HPP
#define STACK_HPP

#include "Node.hpp"  // Node sınıfının tanımını içe aktarıyoruz

class Stack {
    Node* topNode = nullptr;  // Yığının en üst düğümü
    int stackSize = 0;        // Yığının eleman sayısı
    int stackSum = 0;         // Yığının elemanlarının toplamı

public:
    void push(int val);       // Yığının üstüne eleman ekleme işlevi
    int pop();                // Yığının üstündeki elemanı çıkarma işlevi
    int top() const;          // Yığının en üstündeki elemanı getiren işlev
    bool empty() const;       // Yığının boş olup olmadığını kontrol eden işlev
    int size() const;         // Yığının eleman sayısını döndüren işlev
    int sum() const;          // Yığının elemanlarının toplamını döndüren işlev
    ~Stack();                 // Yığını temizlemek ve belleği serbest bırakmak için yıkıcı işlev
};

#endif // STACK_HPP
