using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour 
{
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

	void Start () 
	{
        myDelegate = PrintNum;
        myDelegate(50);
	}

    void PrintNum(int num)
    {
        Debug.Log("Print Num: " + num);
    }

    void DoubleNum(int num)
    {
        Debug.Log("Double Num: " + num * 2);
    }
}
