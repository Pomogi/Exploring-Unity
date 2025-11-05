using UnityEngine;

public class Slushatel_Cvet : MonoBehaviour
{
    void Start()
    {
        FindFirstObjectByType<KnopkaGlavnaya>().NaKnopkuNazhali += PomenyatCvet;
    }

    void PomenyatCvet()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
        Debug.Log("Μενÿώ φβες!");
    }
}