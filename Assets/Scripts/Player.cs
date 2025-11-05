using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public event Action<int> HP_Izmenilos;
    public event Action<int> Ustalost_Izmenilas;
    public event Action<string> Trevoga;

    private int zdorovie = 100;
    private int ustalost = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            zdorovie -= 10;
            if (zdorovie < 0) zdorovie = 0;

            Debug.Log("Получил урон. Осталось ХП: " + zdorovie);

            if (HP_Izmenilos != null) HP_Izmenilos(zdorovie);

            if (zdorovie < 20)
            {
                if (Trevoga != null) Trevoga("Мало жизней");
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ustalost -= 15;
            if (ustalost < 0) ustalost = 0;

            Debug.Log("Осталось сил: " + ustalost);

            if (Ustalost_Izmenilas != null) Ustalost_Izmenilas(ustalost);

            if (ustalost < 20)
            {
                if (Trevoga != null) Trevoga("Мало сил");
            }
        }
    }

    public int GetCurrentHealth()
    {
        return zdorovie;
    }

    public int GetCurrentFatigue()
    {
        return ustalost;
    }
}