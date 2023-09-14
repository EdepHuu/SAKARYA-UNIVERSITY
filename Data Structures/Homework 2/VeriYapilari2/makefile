All: compile run

compile:
	g++ -I ./include/ -o ./lib/main.o -c ./src/main.cpp
	g++ -I ./include/ -o ./lib/BinaryTree.o -c ./src/BinaryTree.cpp
	g++ -I ./include/ -o ./lib/DynamicArray.o -c ./src/DynamicArray.cpp
	g++ -I ./include/ -o ./lib/Node.o -c ./src/Node.cpp
	g++ -I ./include/ -o ./lib/Stack.o -c ./src/Stack.cpp
	g++ -o ./bin/Program ./lib/main.o ./lib/BinaryTree.o ./lib/DynamicArray.o ./lib/Node.o ./lib/Stack.o

run:
	./bin/Program