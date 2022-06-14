using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public int num;

public int num1;
public int num2;

public int n1;
public int n2;


void start (){

    // Crea un programa que pida al usuario un número entero y diga si es par

    if ((num % 2) == 0)
    {//Si num da resto 0
        debug.log (num + "es par")//diremos por pantalla -> num es par
    }else{
        debug.log (num + "es impar") //pero sino, diremos por pantalla -> num es impar
    }

    // Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.

    if (num1 > num2)
    {
        debug.log (num1 + "es mayor que" + num2)
    }else 
        debug.log (num2 + "es mayor" + num1)

    // Crea un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo

    if ((n1 % n2)==0)
    {
        debug.log(n1 + "es multiplo de" + n2)
    }else
    {
        debug.log(n1 + "no es multiplo de" +n2)
    }


}  

