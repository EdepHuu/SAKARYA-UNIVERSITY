/**
* @file G211210031
* @description linkedlist methodu
* @course 1. Öğretim A
* @assignment 1. Ödev
* @date 18.07.2023
* @author Metehan Dündar metehandundar.ogr@sakarya.edu.tr   
*/

#include "linkedlist.hpp"
#include <iostream>
using namespace std;

void insertAtEnd(Node*& head, int value) {
    Node* newNode = new Node(value);
    if (head == nullptr) {
        head = newNode;
    }
    else {
        Node* temp = head;
        while (temp->next != nullptr) {
            temp = temp->next;
        }
        temp->next = newNode;
    }
}

void printLinkedList(Node* head) {
    Node* temp = head;
    while (temp != nullptr) {
        cout << temp->data << " -> ";
        temp = temp->next;
    }
    cout << "NULL";
}

void deleteLinkedList(Node*& head) {
    while (head != nullptr) {
        Node* temp = head;
        head = head->next;
        delete temp;
    }
}
