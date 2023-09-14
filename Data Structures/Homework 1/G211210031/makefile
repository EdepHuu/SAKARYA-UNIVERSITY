All: compile run


compile:
	g++ -I ./include/ -o ./lib/main.o -c ./src/main.cpp
	g++ -I ./include/ -o ./lib/linkedlist.o -c ./src/linkedlist.cpp
	g++ -I ./include/ -o ./lib/average.o -c ./src/average.cpp
	g++ -o ./bin/Program ./lib/main.o ./lib/linkedlist.o ./lib/average.o

run:
	./bin/Program