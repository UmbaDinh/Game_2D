using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [SerializeField] public Text pointsText;
    [SerializeField] public string LV_Load;
    public void Setup(int score){
        gameObject.SetActive(true);
        //pointsText.Text = score.ToString() + " POINT";
    }
    public void RestartButton(){
        SceneManager.LoadScene(LV_Load);
    }
    public void Menumain(){
        SceneManager.LoadScene("Menu");
    }
}
