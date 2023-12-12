#GameDev

Отчет по лабораторной работе #4 выполнил(а):
- Паладий Кирилл Григорьевич
- РИ220947

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | # | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:

## Цель работы
Научиться реализовать перцептрон, который умеет производить вычисления

## Задание 1
### В проекте Unity реализовать перцептрон, который умеет производить вычисления: OR, AND, NAND, XOR и прокоментировать корректность работы

Ход работы:
- Я создал пустой объект с указаным именем, к которому подключил скрипт perceptron. 
- После, для каждого вычисления я ввожу данные input и output. После запуска сцены в консоли мы можем наблюдать, как наш перцептрон начинает обучаться и начинает делать все меньше ошибок.

### Скрипт для перцептрона 
```C#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TrainingSet
{
	public double[] input;
	public double output;
}

public class Perceptron : MonoBehaviour {

	public TrainingSet[] ts;
	double[] weights = {0,0};
	double bias = 0;
	double totalError = 0;

	double DotProductBias(double[] v1, double[] v2) 
	{
		if (v1 == null || v2 == null)
			return -1;
	 
		if (v1.Length != v2.Length)
			return -1;
	 
		double d = 0;
		for (int x = 0; x < v1.Length; x++)
		{
			d += v1[x] * v2[x];
		}

		d += bias;
	 
		return d;
	}

	double CalcOutput(int i)
	{
		double dp = DotProductBias(weights,ts[i].input);
		if(dp > 0) return(1);
		return (0);
	}

	void InitialiseWeights()
	{
		for(int i = 0; i < weights.Length; i++)
		{
			weights[i] = Random.Range(-1.0f,1.0f);
		}
		bias = Random.Range(-1.0f,1.0f);
	}

	void UpdateWeights(int j)
	{
		double error = ts[j].output - CalcOutput(j);
		totalError += Mathf.Abs((float)error);
		for(int i = 0; i < weights.Length; i++)
		{			
			weights[i] = weights[i] + error*ts[j].input[i]; 
		}
		bias += error;
	}

	double CalcOutput(double i1, double i2)
	{
		double[] inp = new double[] {i1, i2};
		double dp = DotProductBias(weights,inp);
		if(dp > 0) return(1);
		return (0);
	}

	void Train(int epochs)
	{
		InitialiseWeights();
		
		for(int e = 0; e < epochs; e++)
		{
			totalError = 0;
			for(int t = 0; t < ts.Length; t++)
			{
				UpdateWeights(t);
				Debug.Log("W1: " + (weights[0]) + " W2: " + (weights[1]) + " B: " + bias);
			}
			Debug.Log("TOTAL ERROR: " + totalError);
		}
	}

	void Start () {
		Train(8);
		Debug.Log("Test 0 0: " + CalcOutput(0,0));
		Debug.Log("Test 0 1: " + CalcOutput(0,1));
		Debug.Log("Test 1 0: " + CalcOutput(1,0));
		Debug.Log("Test 1 1: " + CalcOutput(1,1));		
	}
	
	void Update () {
		
	}
}

```

### Реализация для операции OR
![image](https://github.com/kirosh1q/GameDev/assets/119981696/b13feede-fc8a-4e66-af18-97cf4ace91d9)
Перцептрон обучается за 3-4 поколения 

### Реализация для операции AND
![image](https://github.com/kirosh1q/GameDev/assets/119981696/f3920c04-e376-4eca-8e23-b852551c980b)
Перцептрон обучается за 4-5 поколений

### Реализация для операции NAND
![image](https://github.com/kirosh1q/GameDev/assets/119981696/86ad34c3-af25-4d81-a80f-1a607a2c11d9)
Перцептрон обучается за 5-6 поколений

### Реализация для операции XOR
![image](https://github.com/kirosh1q/GameDev/assets/119981696/0c78106c-de32-48ae-9516-44895e5272ef)
Перцептрон может обучится, получает ошибки в каждом из вычеслений



## Задание 2
### Построить графики зависимости количества эпох от ошибки обучения. Указать от чего зависит необходимое количество эпох обучения

Ход работы:
- Заполняем таблицу данными из процесса
  
  Просмотрев полученные данные для каждой логики, заметил зависимость скорости обучения.
  Для логик OR, AND и NAND персептрон к 7 эпохе перестает делать ошибки.
  Для логики XOR ничего не меняется, XOR с ростом количества эпох не перестает совершать ошибки, что может говорить о том, что он необучаем.
![image](https://github.com/kirosh1q/GameDev/assets/119981696/496a611f-c7f0-4dde-a2a4-ec039c98dfb4)

Ссылка на таблицу: https://docs.google.com/spreadsheets/d/11cK2e7T0zh_XdT0kWbUFzL4QxKfrM4VvTeJd746p6xs/edit?hl=ru#gid=0




