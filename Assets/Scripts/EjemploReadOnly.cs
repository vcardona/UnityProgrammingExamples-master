using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EjemploOtroNameSpace;
using carro = ejemploVictor.MyClass;

public class EjemploReadOnly : MonoBehaviour 
{
    public readonly int MaxHitPoints = 50;

    public  EjemploReadOnly(int hp)
    {
        this.MaxHitPoints = hp;
    }

     void Start()
    {
        MyClass loquesea = new MyClass();
        loquesea.MyFunction();

        ejemploVictor.MyClass otraCosa = new ejemploVictor.MyClass();
        otraCosa.MyFunction();
    }




}
