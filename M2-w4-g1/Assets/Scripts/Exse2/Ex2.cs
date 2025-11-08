using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    [SerializeField] string stringa;
   

    void Start()
    {
        string stringo="";
        for (int i = 0; i < stringa.Length; i++)
        {
            if (stringa[i] != ';' && stringa[i]!='(' && stringa[i]!=')')
            {
                stringo += stringa[i];
            }
            else if(stringo!="")
            {
                Debug.Log(stringo);
                stringo = "";
            }

        }
    }



}
