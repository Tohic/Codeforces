'''
Вася работает диджеем в самом лучшем ночном клубе Берляндии, и часто в своих выступлениях он использует музыку в стиле «дабстеп». Недавно он решил взять несколько старых песен и сделать из них дабстеп-ремиксы.

Пусть песня состоит из некоторого количества слов. Для того, чтобы сделать дабстеп-ремикс этой песни, Вася вставляет некоторое количество слов «WUB» до первого слова песни (возможно нулевое количество), после последнего слова (возможно нулевое количество) и между словами (между любой парой соседних слов песни хотя бы одно слово «WUB»), а затем склеивает все слова, включая «WUB», в одну строку и проигрывает в клубе
'''
string = input().split('WUB')
print(' '.join(string))
