using UnityEngine;
using UnityEngine.UI;

public class UI_Pokazatel : MonoBehaviour
{
    public Text textHP;
    public Text textUstalost;
    public Text textTrevoga;

    void Start()
    {
        Player igrok = FindFirstObjectByType<Player>();

        igrok.HP_Izmenilos += ObnovitHP;
        igrok.Ustalost_Izmenilas += ObnovitUstalost;
        igrok.Trevoga += PokazatTrevogu;

        textHP.text = "Здоровье: " + igrok.GetCurrentHealth();
        textUstalost.text = "Усталость: " + igrok.GetCurrentFatigue();
        textTrevoga.text = "";
    }

    void ObnovitHP(int novoeHP)
    {
        textHP.text = "Здоровье: " + novoeHP;
    }

    void ObnovitUstalost(int novayaUstalost)
    {
        textUstalost.text = "Усталость: " + novayaUstalost;
    }

    void PokazatTrevogu(string soobshenie)
    {
        textTrevoga.text = soobshenie;
    }
}