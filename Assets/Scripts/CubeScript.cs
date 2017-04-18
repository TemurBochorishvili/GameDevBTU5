using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    void Start()
    {
        BonusSecondTask(10);
    }

    void Update()
    {

    }

    void FirstTask()
    {
        if (Time.frameCount <= 200)
        {
            Debug.Log(Time.frameCount);
        }
    }

    void SecondTask()
    {
        if (Time.frameCount % 5 == 0)
        {
            Debug.Log(Time.frameCount);
        }
    }

    void ThirdTask()
    {
        Debug.Log("For " + Time.frameCount +
            " frames Unity needs " + Time.time + " seconds");
    }

    void BonusFirstTask()
    {
        const int a = 28459;
        int b = 0;

        while (b < a)
        {
            b++;
            if (a % b == 0)
            {
                Debug.Log(b);
            }
        }
    }

    void BonusSecondTask(int index)
    {
        ArrayList primeNumberList = new ArrayList();

        for (int i = 1; i < 1000; i++)
        {
            int n = 0;
            for (int j = 1; j <= Mathf.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    n++;
                }
            }
            if (n == 1)
            {
                primeNumberList.Add(i);
            }
        }

        Debug.Log(primeNumberList[index]);
    }
}
