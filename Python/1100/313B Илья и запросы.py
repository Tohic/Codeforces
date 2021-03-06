'''
Лев Илья хочет помочь всем своим друзьям со сдачей экзаменов. Чтобы сдать экзамен по информатике нужно решить следующую задачу.

Даны строка s = s1s2... sn (n — длина строки), состоящая только из символов «.» и «#», и m запросов. Каждый запрос описывается парой целых чисел li, ri (1 ≤ li < ri ≤ n). Ответ на запрос li, ri — это количество таких целых чисел i (li ≤ i < ri), что si = si + 1.

Лев Илья хочет помочь друзьям, но кто же поможет ему. Помогите Льву Илье, решите задачу.

Входные данные
В первой строке записана строка s длины n (2 ≤ n ≤ 105). Гарантируется, что заданная строка состоит только из символов «.» и «#».

В следующей строке записано целое число m (1 ≤ m ≤ 105) — количество запросов. В каждой из следующих m строк записано описание соответствующего запроса. В i-той строке записаны целые числа li, ri (1 ≤ li < ri ≤ n).

Выходные данные
Выведите m целых чисел — ответы на запросы в том порядке, в котором запросы заданы во входных данных.
'''
string = input()
s = [0] * (len(string))
for i in range(1,len(s)):
    if string[i] == string[i - 1]:
        s[i] = s[i-1]+1
    else:
        s[i] = s[i-1]
n = int(input())
for i in range(n):
    l, k = [int(num) for num in input().split(' ')]
    print(s[k-1]-s[l-1])