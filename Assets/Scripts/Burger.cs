using UnityEngine;
using System.Collections.Generic;
public class Burger : MonoBehaviour
{
    void Start()
    {
        string rezultat1 = GotovimBurger("сыр", "кетчуп", "котлета", "огурец");
        Debug.Log("Пробуем сделать чизбургер. Получилось: " + (rezultat1 ?? "ничего"));

        string rezultat2 = GotovimBurger("специальный соус", "салат", "две котлеты", "булочка с кунжутом");
        Debug.Log("Пробуем сделать биг мак. Получилось: " + (rezultat2 ?? "ничего"));

        string rezultat3 = GotovimBurger("котлета", "сыр", "огурец", "кетчуп");
        Debug.Log("Пробуем сделать чизбургер (другой порядок). Получилось: " + (rezultat3 ?? "ничего"));

        string rezultat4 = GotovimBurger("хлеб", "масло", "колбаса", "сыр");
        Debug.Log("Пробуем сделать что-то свое. Получилось: " + (rezultat4 ?? "ничего"));

        string rezultat5 = GotovimBurger("сыр", "салат", "две котлеты", "булочка с кунжутом");
        Debug.Log("Пробуем сделать биг мак (не хватает соуса). Получилось: " + (rezultat5 ?? "ничего"));
    }

    public string GotovimBurger(string ing1, string ing2, string ing3, string ing4)
    {
        List<string> ingredienti = new List<string>();
        ingredienti.Add(ing1.ToLower());
        ingredienti.Add(ing2.ToLower());
        ingredienti.Add(ing3.ToLower());
        ingredienti.Add(ing4.ToLower());

        if (ingredienti.Contains("сыр") && ingredienti.Contains("кетчуп") && ingredienti.Contains("котлета") && ingredienti.Contains("огурец"))
        {
            return "чизбургер";
        }

        if (ingredienti.Contains("специальный соус") && ingredienti.Contains("булочка с кунжутом") && ingredienti.Contains("две котлеты"))
        {
            return "биг мак";
        }

        return null;
    }
}