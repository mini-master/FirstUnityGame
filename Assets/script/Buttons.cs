using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public string SceneName;
    public Animator transitionAnim1;
    public Animator transitionAnim2;
    public Animator transitionAnim3;
    public Animator transitionAnim4;
    public void PlayButtonStartMenu()
    {
        StartCoroutine(NextScene());
    }

    public void PlayButtonMainMenu()
    {
        SceneManager.LoadSceneAsync(SceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator NextScene()
    {
        transitionAnim1.SetTrigger("NextScene");
        transitionAnim2.SetTrigger("NextScene");
        transitionAnim3.SetTrigger("NextScene");
        transitionAnim4.SetTrigger("NextScene");
        yield return new WaitForSeconds(1.6f);
        SceneManager.LoadSceneAsync(SceneName);
    }
}