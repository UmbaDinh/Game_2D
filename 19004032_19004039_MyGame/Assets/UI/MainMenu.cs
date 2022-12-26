using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;

    private void Start()
    {
        Time.timeScale = 1;
        mixer.GetFloat("volume",out value);
        volumeSlider.value = 0;
        AudioManager.instance.Play("NhacNenBG");
    }
    public void Loadlevel(int index)
    {
        SceneManager.LoadScene(index); 
    }

    public void SetVolume()
    {
        mixer.SetFloat("volume", volumeSlider.value);
    }
    // public void QuitGame(){
    //     Debug.Log("QUIT GAME");
    //     Application.Quit(); 
    // }
}
