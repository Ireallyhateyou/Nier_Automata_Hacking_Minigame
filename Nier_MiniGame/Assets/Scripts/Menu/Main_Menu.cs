using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using Kino; 
 

public class Main_Menu : MonoBehaviour
{
    public Main_Menu S;
    public AudioSource Music;
    public float Time_Before_Scene_Change = 5f;
    public float GlitchIntensity = .5f;
    public Kino.PostProcessing.Glitch Glitch;
    public AnalogGlitch analogGlitch;
    public DigitalGlitch digitalGlitch;
    public VolumeProfile volumeProfile;
    public float cd = 0.0f;
    private void Awake() {
        S = this;
    }
    private void Start() {
        volumeProfile.TryGet<AnalogGlitch>(out analogGlitch);
        //volume.GetComponent<Volume>().sharedProfile;
        //GetComponent<Kino.AnalogGlitch>().colorDrift = cd;
        //volume.sharedProfile.TryGet<cd>(out Aglitch);
        //Aglitch = volume.GetComponent<AnalogGlitch>();
        digitalGlitch = GetComponent<DigitalGlitch>();
        analogGlitch = GetComponent<AnalogGlitch>();
        
    }
    public void PlayGame()
    {
        StartCoroutine (AudioFadeOut.FadeOut (Music, Time_Before_Scene_Change));
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
        

    }
}
