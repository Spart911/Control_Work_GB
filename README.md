![лого](/logo/geekbrains.png)
# **ЗАДАЧА**

 >Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
***
*Примеры:*

>[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]\
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]\
[“Russia”, “Denmark”, “Kazan”] → []

# Решение
>1.  Создать массив строк ArrFirst[]
>2.  Создать переменную count и установить ее значение равным 0.
>3. Пройти по каждой строке в массиве ArrFirst[]
>4. Если длина строки меньше или равна 3 символам, увеличить count на 1
>5.  Создать новый массив ArrSecond[] длиной count
>6.  Создать переменную index и установить ее значение равным 0
>7. Пройти по каждой строке в массиве ArrFirst[]
>8.  Если длина строки меньше или равна 3 символам, добавить эту строку в массив ArrSecond[] на позицию index и увеличить index на 1
>9.  Вернуть новый массив ArrSecond[] из строк, длина которых меньше или равна 3 символам