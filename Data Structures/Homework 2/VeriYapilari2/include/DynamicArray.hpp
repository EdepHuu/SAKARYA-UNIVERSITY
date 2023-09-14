#ifndef DYNAMICARRAY_HPP
#define DYNAMICARRAY_HPP

class DynamicArray {
private:
    int capacity;   // Dizinin kapasitesi
    int size;       // Mevcut eleman sayısı
    void** arr;     // void pointer dizisi

    // Dizi boyutunu artırmak için kullanılan yardımcı işlev
    void resize();

public:
    // Yapıcı işlev, varsayılan kapasite ile bir dizi oluşturur
    DynamicArray();

    // Diziye yeni bir eleman eklemek için kullanılan işlev
    void push_back(void* val);

    // Belirtilen indeksteki elemanı döndüren işlev
    void* at(int index);

    // Dizideki eleman sayısını döndüren işlev
    int getSize() const;

    // Yıkıcı işlev, bellek sızıntısını önlemek için diziyi temizler
    ~DynamicArray();
};

#endif // DYNAMICARRAY_HPP
