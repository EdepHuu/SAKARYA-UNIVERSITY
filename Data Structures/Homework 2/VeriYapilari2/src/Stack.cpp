/**
* @file G211210031_G201210073
* @description main methodu
* @course 1. Öğretim A
* @assignment 2. Ödev
* @date 29.07.2023
* @author Metehan Dündar metehan.dundar@ogr.sakarya.edu.tr - Muhammed Sefa Özdemir muhammed.ozdemir12@ogr.sakarya.edu.tr
*/

#include "Stack.hpp" // Stack sınıfının tanımını içe aktarıyoruz

#include <iostream>

void Stack::push(int val) {
    Node* newNode = new Node(val); // Yeni bir düğüm oluşturuyoruz
    newNode->next = topNode;       // Yeni düğümün next işaretçisini eski üst düğüme ayarlıyoruz
    topNode = newNode;             // Üst düğümü yeni düğüme ayarlıyoruz
    stackSize++;                   // Yığındaki eleman sayısını bir artırıyoruz
    stackSum += val;               // Yığındaki elemanların toplamını güncelliyoruz
}

int Stack::pop() {
    if (!topNode) return -1;       // Yığın boşsa -1 döndürüyoruz
    int val = topNode->value;      // Üst düğümün değerini alıyoruz
    Node* tmp = topNode;           // Geçici bir düğüm oluşturuyoruz
    topNode = topNode->next;       // Üst düğümü bir alt düğüme ayarlıyoruz
    delete tmp;                    // Eski üst düğümü bellekten siliyoruz
    stackSize--;                   // Yığındaki eleman sayısını bir azaltıyoruz
    stackSum -= val;               // Yığındaki elemanların toplamını güncelliyoruz
    return val;                    // Çıkarılan değeri döndürüyoruz
}

int Stack::top() const {
    if (topNode) return topNode->value; // Üst düğüm varsa değerini döndürüyoruz
    return -1;                          // Üst düğüm yoksa -1 döndürüyoruz
}

bool Stack::empty() const {
    return !topNode; // Üst düğüm yoksa yığın boştur
}

int Stack::size() const {
    return stackSize; // Yığındaki eleman sayısını döndürüyoruz
}

int Stack::sum() const {
    return stackSum; // Yığındaki elemanların toplamını döndürüyoruz
}

Stack::~Stack() {
    while (!empty()) {
        pop(); // Yığın öğelerini bellekten silerek yığını temizliyoruz
    }
}
