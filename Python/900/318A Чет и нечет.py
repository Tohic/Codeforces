'''
Володя нонконформист и не хочет мириться с существующим порядком натуральных чисел. Он решил непременно его изменить. Но так как натуральных чисел очень уж много, Володя решил начать с малого и изменить порядок первых n натуральных чисел. Для этого записывает в тетрадку такую последовательность: сначала все нечетные натуральные числа от 1 до n (по возрастанию), а затем все четные натуральные числа от 1 до n (по возрастанию). Помогите Володе определить, какое число будет стоять в данной последовательности на позиции с номером k.

Входные данные
В единственной строчке через пробел записаны целые числа n и k (1 ≤ k ≤ n ≤ 1012).

Пожалуйста, не используйте спецификатор %lld для чтения или записи 64-х битных чисел на С++. Рекомендуется использовать потоки cin, cout или спецификатор %I64d).

Выходные данные
Выведите число, которое окажется на позиции с номером k в тетрадке Володи.
'''
n,m = [int(num) for num in input().split(' ')]
mid = int(n/2) if n % 2 == 0 else int(n/2) +1
print((m*2 - 1) if m <= mid else ((m - mid)*2))