/**
* @file G211210031
* @description main methodu
* @course 1. Öğretim A
* @assignment 1. Ödev
* @date 18.07.2023
* @author Metehan Dündar metehandundar.ogr@sakarya.edu.tr   
*/
#include <iostream>
#include <fstream>
#include <sstream>
#include <cmath>
#include "linkedlist.hpp"
#include "average.hpp"

using namespace std;

int main() {
    ifstream file("Sayilar.txt");
    if (!file.is_open()) {
        cout << "Dosya acilamadi." << endl;
        return 1;
    }

    Node** upwardLists = nullptr;
    Node** downwardLists = nullptr;
    int numLists = 0;
    string line;

    // Dosyadan verileri okuyarak bağlı listeleri oluşturan döngü
    while (getline(file, line)) {
        istringstream iss(line);
        int num;
        Node* upwardHead = nullptr;
        Node* downwardHead = nullptr;

        while (iss >> num) {
            insertAtEnd(upwardHead, num / 10);
            insertAtEnd(downwardHead, num % 10);
        }

        // Yeni bağlı listeleri upwardLists ve downwardLists dizilerine ekleyin
        Node** newUpwardLists = new Node * [numLists + 1];
        Node** newDownwardLists = new Node * [numLists + 1];

        for (int i = 0; i < numLists; ++i) {
            newUpwardLists[i] = upwardLists[i];
            newDownwardLists[i] = downwardLists[i];
        }

        newUpwardLists[numLists] = upwardHead;
        newDownwardLists[numLists] = downwardHead;
        delete[] upwardLists;
        delete[] downwardLists;

        upwardLists = newUpwardLists;
        downwardLists = newDownwardLists;

        numLists++;
    }

    file.close();

    // Yukarı yönlü bağlı listeleri ekrana yazdırma döngüsü
    //cout << "Yukari yonlu bagli listeler:" << endl;
    //for (int i = 0; i < numLists; ++i) {
    //    cout << "Yukari yonlu " << i + 1 << ". bagli liste: ";
    //    printLinkedList(upwardLists[i]);
    //    cout << endl;
    //}

    //cout << "------------------------------------" << endl;

    //// Aşağı yönlü bağlı listeleri ekrana yazdırma döngüsü
    //cout << "Asagi yonlu bagli listeler:" << endl;
    //for (int i = 0; i < numLists; ++i) {
    //    cout << "Asagi yonlu " << i + 1 << ". bagli liste: ";
    //    printLinkedList(downwardLists[i]);
    //    cout << endl;
    //}

    int indexA, indexB;
    cout << "Konum A: ";
    cin >> indexA;
    cout << "Konum B: ";
    cin >> indexB;

    // Değiştirme işlemi
    if (indexA >= 0 && indexA < numLists && indexB >= 0 && indexB < numLists) {
        Node* tempUpwardA = upwardLists[indexA];
        Node* tempDownwardB = downwardLists[indexB];

        upwardLists[indexA] = tempDownwardB;
        downwardLists[indexB] = tempUpwardA;
    }
    else {
        cout << "Hatali konum girdiniz. Lutfen 0 ile " << numLists-1 << " arasinda bir deger giriniz." << endl;
        return 0;
    }

    // Değiştirilen listelerin elemanlarının ortalamasını hesapla
    double totalUpwardAverage = 0;
    double totalDownwardAverage = 0;
    int longestListLength = 0;

    // En uzun bağlı listenin uzunluğunu bulalım
    for (int i = 0; i < numLists; ++i) {
        Node* temp = upwardLists[i];
        int length = 0;
        while (temp != nullptr) {
            length++;
            temp = temp->next;
        }
        if (length > longestListLength)
            longestListLength = length;
    }

    // Yukarı yönlü bağlı listelerin [n]. indekslerini topla ve eleman sayısına böl
    for (int i = 0; i < longestListLength; ++i) {
        totalUpwardAverage += calculateAverage(upwardLists, numLists, i);
    }

    // En uzun bağlı listenin uzunluğunu bulalım
    longestListLength = 0;
    for (int i = 0; i < numLists; ++i) {
        Node* temp = downwardLists[i];
        int length = 0;
        while (temp != nullptr) {
            length++;
            temp = temp->next;
        }
        if (length > longestListLength)
            longestListLength = length;
    }

    // Aşağı yönlü bağlı listelerin [n]. indekslerini topla ve eleman sayısına böl
    for (int i = 0; i < longestListLength; ++i) {
        totalDownwardAverage += calculateAverage(downwardLists, numLists, i);
    }

    cout << "Ust: " << totalUpwardAverage << endl;
    cout << "Alt: " << totalDownwardAverage << endl;

    // Belleği temizle
    for (int i = 0; i < numLists; ++i) {
        deleteLinkedList(upwardLists[i]);
        deleteLinkedList(downwardLists[i]);
    }

    delete[] upwardLists;
    delete[] downwardLists;

    cout << "Bellek temizlendi..." << endl;

    return 0;
}