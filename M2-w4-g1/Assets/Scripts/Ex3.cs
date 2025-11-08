using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] int NumeroMax;
    [SerializeField] int lung;


    void Start()
    {
        List<int> lista = new List<int>();
        int a=0;

        for (int i = 0; i <=lung; i++)
        {

            if (a == 0)
            {
                lista.Insert(0, i);

            }
            if (a == 1)
            {
                lista.Add(i);
            }
            if (a == 2)
            {
                lista.Insert(lista.Count/2, i);

            }
           
            a = (a+1)%3;
         






        }

        for (int i = 0; i < lista.Count; i++)
        {
            Debug.Log(lista[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
