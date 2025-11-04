
using UnityEngine;

public class Player
{
    public string name;
    private int punteggio;
    public int danno = 20;

    public void IncrementaP()
    {
        punteggio += 20;
    }

    public int GetPunt()
    {
        return punteggio;
    }

    public int SetPunt(int punt)
    {
        if (punt < 0)
        {
            Debug.LogWarning("hai cercato di impostare un valor negativo, esso verrà impostato a zero");
            return punteggio = 0;
        }
        else
        {
            return punteggio = punt;
        }
    }
    public bool IsWinner()
    {
        return (punteggio >= 100);

    }

    public void AttackEnemy(Enemy enemy, int danno)
    {
        enemy.SubisciDanno(danno);
    }
}

public class Enemy
{
    public string name;
    public int salute=100;
    private int livello;

    public void SubisciDanno(int danno)
    {
        if (danno >= salute)
        {
            salute = 0;
        }
        else
        {
            salute -= danno;
        }
        
    }
}