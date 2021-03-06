'''
HQ9+ — шуточный язык программирования, состоящий всего из четырех односимвольных команд:

«H» печатает «Hello, World!»,
«Q» печатает исходный код самой программы,
«9» печатает текст песни «99 бутылок пива»,
«+» увеличивает на единицу значение внутреннего счетчика.
Команды «H» и «Q» воспринимаются только в верхнем регистре. Все символы программы, не являющиеся командами, игнорируются.

Вам дана программа на HQ9+. Определите, будет ли что-то напечатано в результате ее выполнения.

Входные данные
В единственной строке входных данных задана строка p — программа на языке HQ9+. Строка p содержит от 1 до 100 символов, включительно. ASCII-код каждого символа будет от 33 (восклицательный знак) до 126 (тильда), включительно.

Выходные данные
Выведите «YES», если в результате выполнения программы будет напечатано какое-то сообщение, и «NO» в противном случае.
'''
st = input()
print("YES" if 'H' in st or 'Q' in st or '9' in st  else "NO")