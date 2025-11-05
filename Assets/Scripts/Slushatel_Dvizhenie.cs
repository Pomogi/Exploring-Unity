using UnityEngine;

public class Slushatel_Dvizhenie : MonoBehaviour
{
    void Start()
    {
        FindFirstObjectByType<KnopkaGlavnaya>().NaKnopkuNazhali += () =>
        {
            transform.position += new Vector3(0, 1, 0);
            Debug.Log("Я подпрыгнул!");
        };
    }
}