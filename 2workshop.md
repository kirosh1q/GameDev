#GameDev

Отчет по лабораторной работе #2 выполнил(а):
- Паладий Кирилл Григорьевич
- РИ220947

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * |  |
| Задание 2 | * |  |
| Задание 3 | * |  |

знак "*" - задание выполнено; знак "#" - задание не выполнено;


## Цель работы
Научиться передавать в Unity данные из Google Sheets с помощью Python.

## Задание 1
### Выбрать компьютерную игру, привести из нее пару скриншотов и описать концепт игры. Выберать одну из игровых переменных в игре и описать её роль, условия изменения / появления и диапазон допустимых значений. Построить схему экономической модели в игре и указать место выбранного ресурса в ней.
Я выбрал игру - DOTA 2

![Kk6tDpu3Dj](https://github.com/kirosh1q/GameDev/assets/119981696/3b3c9d2c-9ba9-43eb-a5ff-5d2592d28a77)
![dota2_lbZ7kb4AG3](https://github.com/kirosh1q/GameDev/assets/119981696/155e9fc1-b6b2-4d28-b42a-ec2b55d20315)

Игра представляет собой жанр MOBA - стратегия, в которой 10 игроков (по 5 в каждой из 2х команд) по ходу игры наращивают денежное и территориальное преимущество и в конечном итоге разрушают вражеский трон (вражеское главное здание, после разрушения которого игра оканчивается).
Выбранная мною игровая переменная - золото. Золото является единицей денег в игре, за золото игрок покупает предметы, расходники и может возродиться без таймера в ходе матча (раз в 7 минут).
Золото дается в начале матча в количестве 600. Это золото используется для закупа в очень ранней стадии игры, обычно это расходники и дешевые предметы дающие атрибуты.
Золото добывается игроками за добивание крипов на линии и в лесу, также золото дается за убийство / содействие в убийстве вражеского персонажа. Также дается 95 золота в минуту.
Игрок может терять золото умирая. Золото имеет диапазон допустимых значений 0 - 99999. Игра фактически зависит от золота, поэтому оно имеет очень много сложных механик, подробнее - https://dota2.fandom.com/ru/wiki/%D0%97%D0%BE%D0%BB%D0%BE%D1%82%D0%BE
![image](https://github.com/kirosh1q/GameDev/assets/119981696/813a9c91-839e-487e-910a-479fbe418c43)
Это простая схема получения и затраты золота. Схема показывает как золото продвигает игровой процесс.

## Задание 2