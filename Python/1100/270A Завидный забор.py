'''
Эмускальду надо построить забор вокруг фермы, но вот самому это делать ему лень. Так что юноша приобрел робота-заборостройщика.

Эмускальду хочется, чтобы забор представлял собой правильный многоугольник. К сожалению, его робот строит забор, двигаясь по единственному пути. При этом робот может соединять стороны забора только под заданным углом a.

Сможет ли робот построить забор, который хочет Эмускальд? Иными словами, существует ли правильный многоугольник с углами, равными a?

Входные данные
Первая строка входных данных содержит целое число t (0 < t < 180) — количество тестов. Каждая из последующих t строк содержит единственное целое число a (0 < a < 180) — угол, под которым робот может соединять стороны, в градусах.

Выходные данные
Для каждого теста выведите в единственной строке «YES» (без кавычек), если робот может построить тот забор, который хочет Эмускальд. Если это невозможно, выведите «NO» (без кавычек).
'''
n = int(input())
for i in range(n):
    num = int(input())
    print("NO" if ((2*180)/(180-num)) - int((2*180)/(180-num)) else "YES")