FILE_LIST=./main.c \
			./sum.c
TEST_FILE_LIST=./test.c \
			./sum.c
main:
	gcc $(FILE_LIST) -DA=10 -o main

test:
	gcc $(TEST_FILE_LIST) -DA=10 -o test

clean:
	rm ./a.exe