using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1= new Player();
        Player p2 = new Player();
        p1.name = "Orstein";
        p2.name = "Smough";

        //prima parte con il campo punteggio pubblico
        //p1.punteggio = 100;
        //p2.punteggio = 80;

        //Debug.Log($"il player uno si chiama {p1.name} e ha un punteggio di {p1.punteggio}");
        //Debug.Log($"il player due si chiama {p2.name} e ha un punteggio di {p2.punteggio}");

        //seconda parte dell'esercizio uno
        //Debug.Log("seconda parte");
        Player p3= new Player();
        p3.name = "fessuj";
        //p3.punteggio=100;
        //Debug.Log($"il palyer {p3.name} ora ha un punteggio di {p3.punteggio}");
        //p3.IncrementaP();
        //Debug.Log($"il palyer {p3.name} dopo l'incremento ha un punteggio di {p3.punteggio}");

        //terza parte

        //sto mettendo/settando i valori dei vari player
        p1.SetPunt(80);
        p2.SetPunt(180);
        p3.SetPunt(-10);

        //ora controllo se il loro valore è stato messo corettamente
        Debug.Log("valore di p1 "+p1.GetPunt());
        Debug.Log("valore p2 "+p2.GetPunt());
        Debug.Log("valore p3 "+p3.GetPunt());

        //controllo se hanno abbastanza punti per vincere

        Debug.Log("p1");
        p1.IsWinner();
        Debug.Log("p2");
        p2.IsWinner();
        Debug.Log("p3");
        p3.IsWinner();

        // parte 4 con una classe enemy

        Enemy nem1= new Enemy();
        nem1.name = "Seth";
        Debug.Log($"il player {p1.name} ha attacatto il nemico {nem1.name}");
        Debug.Log($"il nemico {nem1.name} è passato da salute {nem1.salute}");
        p1.AttackEnemy(nem1, p1.danno);
        Debug.Log($"a salute {nem1.salute} subendo {p1.danno} danni");








    }


}
