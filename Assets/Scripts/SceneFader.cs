using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFader : MonoBehaviour
{
    public Image fadePanel; 
    public float fadeDuration = 1f; 

    void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOutAndLoadScene(sceneName));
    }

    private IEnumerator FadeIn()
    {
        float timer = fadeDuration;
        while (timer > 0f)
        {
            timer -= Time.deltaTime;
            float alpha = timer / fadeDuration;
            fadePanel.color = new Color(0f, 0f, 0f, alpha);
            yield return null; 
        }
        fadePanel.color = new Color(0f, 0f, 0f, 0f);
    }

    private IEnumerator FadeOutAndLoadScene(string sceneName)
    {
        float timer = 0f;
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = timer / fadeDuration;
            fadePanel.color = new Color(0f, 0f, 0f, alpha);
            yield return null; 
        }
        fadePanel.color = new Color(0f, 0f, 0f, 1f); 

        SceneManager.LoadScene(sceneName);
    }
}