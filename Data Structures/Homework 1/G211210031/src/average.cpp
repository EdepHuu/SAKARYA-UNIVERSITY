/**
* @file G211210031
* @description average methodu
* @course 1. Öğretim A
* @assignment 1. Ödev
* @date 18.07.2023
* @author Metehan Dündar metehandundar.ogr@sakarya.edu.tr   
*/

#include "average.hpp"
#include "linkedlist.hpp"

double calculateAverage(Node** lists, int numLists, int index) {
    double sum = 0;
    int count = 0;

    for (int i = 0; i < numLists; ++i) {
        Node* temp = lists[i];
        int currentIndex = 0;

        while (temp != nullptr) {
            if (currentIndex == index) {
                sum += temp->data;
                count++;
                break;
            }
            currentIndex++;
            temp = temp->next;
        }
    }

    return sum / count;
}
