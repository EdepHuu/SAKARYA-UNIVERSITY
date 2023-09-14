/**
* @file G211210031_G201210073
* @description main methodu
* @course 1. Öğretim A
* @assignment 2. Ödev
* @date 29.07.2023
* @author Metehan Dündar metehan.dundar@ogr.sakarya.edu.tr - Muhammed Sefa Özdemir muhammed.ozdemir12@ogr.sakarya.edu.tr
*/

#include <iostream>
#include <fstream>
#include <cctype>
#include <sstream>
#ifdef _WIN32
#include <windows.h> // Windows için Sleep fonksiyonu
#else
#include <unistd.h>  // Diğer platformlar için usleep fonksiyonu
#endif

#include "Stack.hpp"      // Stack sınıfının tanımını içe aktarıyoruz
#include "BinaryTree.hpp" // BinaryTree sınıfının tanımını içe aktarıyoruz
#include "DynamicArray.hpp" // DynamicArray sınıfının tanımını içe aktarıyoruz

using namespace std;

void sleepMilliseconds(int milliseconds) {
#ifdef _WIN32
    Sleep(milliseconds);   // Windows'ta Sleep fonksiyonu
#else
    usleep(milliseconds * 1000); // Diğer platformlarda usleep fonksiyonu
#endif
}

int main() {
    ifstream inFile("Sayilar.txt"); // "Sayilar.txt" adlı metin dosyasını açıyoruz
    string line;

    while (getline(inFile, line)) { // Dosyanın her bir satırını okuyoruz
        DynamicArray stacks;         // Yığınları depolamak için bir DynamicArray nesnesi oluşturuyoruz
        DynamicArray trees;          // Ağaçları depolamak için bir DynamicArray nesnesi oluşturuyoruz

        stringstream ss(line);       // Satırı stringstream'e dönüştürüyoruz
        int number;
        Stack* currentStack = new Stack(); // Geçici bir yığın oluşturuyoruz

        while (ss >> number) {
            if (currentStack->empty() || (number <= currentStack->top() || number % 2 != 0)) {
                currentStack->push(number); // Yığına eleman ekliyoruz
            }
            else {
                stacks.push_back(currentStack); // Oluşturulan yığını stacks DynamicArray'e ekliyoruz
                currentStack = new Stack();     // Yeni bir yığın oluşturuyoruz
                currentStack->push(number);
            }
        }
        stacks.push_back(currentStack); // Son kalan yığını stacks DynamicArray'e ekliyoruz

        for (int i = 0; i < stacks.getSize(); i++) {
            Stack* s = static_cast<Stack*>(stacks.at(i)); // Stacks'ten yığınları alıyoruz
            BinaryTree* tree = new BinaryTree();          // Yeni bir ikili ağaç oluşturuyoruz
            trees.push_back(tree);                        // Oluşturulan ağacı trees DynamicArray'e ekliyoruz
            while (!s->empty()) {
                tree->insert(s->pop()); // Yığındaki elemanları ikili ağaca ekliyoruz
            }
        }

        BinaryTree* maxTree = static_cast<BinaryTree*>(trees.at(0)); // İlk ağacı maksimum ağaç olarak belirliyoruz
        for (int i = 0; i < trees.getSize(); i++) {
            BinaryTree* t = static_cast<BinaryTree*>(trees.at(i)); // Trees'ten ağaçları alıyoruz
            if (t->height() > maxTree->height() || (t->height() == maxTree->height() && t->sum() > maxTree->sum())) {
                maxTree = t; // Yükseklik ve toplam değere göre maksimum ağacı güncelliyoruz
            }
        }

        maxTree->postOrder(); // Maksimum ağacı postorder olarak gezerek değerleri yazdırıyoruz
        cout << endl;

        for (int i = 0; i < stacks.getSize(); i++) delete static_cast<Stack*>(stacks.at(i)); // Belleği temizliyoruz
        for (int i = 0; i < trees.getSize(); i++) delete static_cast<BinaryTree*>(trees.at(i)); // Belleği temizliyoruz

        sleepMilliseconds(10); // Her iterasyondan sonra 10 milisaniye bekliyoruz
    }

    inFile.close(); // Dosyayı kapatıyoruz
    return 0;
}
