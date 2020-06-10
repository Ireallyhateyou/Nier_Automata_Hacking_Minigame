using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class Main_Menu : MonoBehaviour
{
    public AudioSource Music;
    public float Time_Before_Scene_Change = 5f;
    public float GlitchIntensity = .5f;
     public Kino.PostProcessing.Glitch Glitch = null;
    private void Start() {
        PostProcessVolume volume = gameObject.GetComponent<PostProcessVolume>();
  
        
    }
    public void PlayGame()
    {
        StartCoroutine (AudioFadeOut.FadeOut (Music, Time_Before_Scene_Change));
        GlitchIn();
        Invoke("LoadScene", Time_Before_Scene_Change);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator Wait(float waitTime)
    {
        
        yield return new WaitForSeconds(.1f);
        Debug.Log("wait");
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("Level1");  
    }
    private void GlitchIn()
    {
        
        Glitch.block = new UnityEngine.Rendering.ClampedFloatParameter(.5f, 0f, 1, true);
    }
}
