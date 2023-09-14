/**
* @file G211210031_G201210073
* @description main methodu
* @course 1. Öğretim A
* @assignment 2. Ödev
* @date 29.07.2023
* @author Metehan Dündar metehan.dundar@ogr.sakarya.edu.tr - Muhammed Sefa Özdemir muhammed.ozdemir12@ogr.sakarya.edu.tr
*/

#include "DynamicArray.hpp"  // DynamicArray sınıfının tanımını içe aktarıyoruz

DynamicArray::DynamicArray() : capacity(10), size(0), arr(new void*[10]) {}
// Yapıcı işlev: Başlangıç kapasitesi, boyut ve dizi oluşturma

void DynamicArray::resize() {
    capacity *= 2;  // Kapasiteyi iki katına çıkar
    void** newArr = new void*[capacity];  // Yeni bir dizi oluştur
    for (int i = 0; i < size; i++) {
        newArr[i] = arr[i];  // Eski verileri yeni diziye kopyala
    }
    delete[] arr;  // Eski diziyi bellekten sil
    arr = newArr;  // Yeni diziyi kullan
}

void DynamicArray::push_back(void* val) {
    if (size == capacity) {
        resize();  // Kapasite dolarsa dizi boyutunu artır
    }
    arr[size++] = val;  // Yeni elemanı diziye ekle ve boyutu artır
}

void* DynamicArray::at(int index) {
    if (index >= 0 && index < size) {
        return arr[index];  // Belirtilen indeksteki elemanı döndür
    }
    return nullptr;  // Geçersiz indeksse nullptr döndür
}

int DynamicArray::getSize() const {
    return size;  // Dizinin mevcut boyutunu döndür
}

DynamicArray::~DynamicArray() {
    delete[] arr;  // Yıkıcı işlev: Diziyi bellekten sil
}
