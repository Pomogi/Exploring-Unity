using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class AbilityManager : MonoBehaviour
{
    [Header("Объект для взаимодействия")]
    public Renderer targetObjectRenderer; 

    [Header("Способность 1")]
    public Button abilityButton1;
    public float cooldown1 = 3.0f;

    [Header("Способность 2")]
    public Button abilityButton2;
    public float cooldown2 = 5.0f;

    [Header("Способность 3")]
    public Button abilityButton3;
    public float cooldown3 = 8.0f;

    private Color originalColor;

    void Start()
    {
        if (targetObjectRenderer != null)
        {
            originalColor = targetObjectRenderer.material.color;
        }

        abilityButton1.onClick.AddListener(() => UseAbility(1));
        abilityButton2.onClick.AddListener(() => UseAbility(2));
        abilityButton3.onClick.AddListener(() => UseAbility(3));
    }

    void UseAbility(int abilityId)
    {
        switch (abilityId)
        {
            case 1:
                StartCoroutine(StartCooldown(abilityButton1, cooldown1));
                targetObjectRenderer.material.color = Color.red;
                break;
            case 2:
                StartCoroutine(StartCooldown(abilityButton2, cooldown2));
                targetObjectRenderer.material.color = Color.green;
                break;
            case 3:
                StartCoroutine(StartCooldown(abilityButton3, cooldown3));
                targetObjectRenderer.material.color = Color.blue;
                break;
        }

        StartCoroutine(ResetColorAfterDelay(1f));
    }

    private IEnumerator StartCooldown(Button abilityButton, float cooldownTime)
    {
        abilityButton.interactable = false;

        yield return new WaitForSeconds(cooldownTime);

        abilityButton.interactable = true;
    }

    private IEnumerator ResetColorAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (targetObjectRenderer != null)
        {
            targetObjectRenderer.material.color = originalColor;
        }
    }
}