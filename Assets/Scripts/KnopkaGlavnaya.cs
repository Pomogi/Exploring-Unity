using UnityEngine;
using System; 

public class KnopkaGlavnaya : MonoBehaviour
{
    public event Action NaKnopkuNazhali;

    public void KtoToNazhal()
    {
        Debug.Log("Кнопка нажата");

        if (NaKnopkuNazhali != null)
        {
            NaKnopkuNazhali();
        }
    }
}