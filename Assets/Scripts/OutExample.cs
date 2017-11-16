using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutExample : MonoBehaviour 
{
    void sevenOut(out int s)
    {
        s = 7;
    }

    void goingOut(out int first, out int second, out int third)
    {
        first = 1;
        second = 2;
        third = 3;
    }

    void inAndOut(int inComing, out int outGoing)
    {
        outGoing = inComing * 2;
    }

	void Start () 
	{
        int i;
        sevenOut(out i);
        Debug.Log(i);//Esta línea dara como salida el numero 7

        int j;
        int k;
        goingOut(out i, out j, out k);
        Debug.Log(i + "" + j + "" + k);


        int outValue = 0;
        Debug.Log(outValue);
        inAndOut(6,out outValue);
        Debug.Log(outValue);

	}
    
}
