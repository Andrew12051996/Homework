print('Введите трехзначное число ')
a = int(input())
if ((a > 100) & (a < 1000)):
    x = a % 10
    y = (a % 100) // 10
    z = a // 100
    print( x + y + z)
else:
    print('Число не трехзначное')
