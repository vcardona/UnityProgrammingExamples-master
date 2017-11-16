using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploStruct : MonoBehaviour 
{
    public int valorUno;

    struct MyStruct
    {
        public int a;
    }

    class MyClass
    {
        public int a;
    }
    void Start()
    {
        MyClass mClass = new MyClass();
        MyStruct mStruct = new MyStruct();
        mClass.a = 1;
        mStruct.a = 1;
        MyStruct ms = mStruct;
        ms.a = 3;
        Debug.Log("Este es el de los Struct " + ms.a + " and " + mStruct.a);
        MyClass mc = mClass;
        mc.a = 3;
        Debug.Log("Este es el de la clase " + mc.a + " and " + mClass.a);
    }
}
