using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class thongbao : MonoBehaviour
{
    // Start is called before the first frame update
    public void Setup(int score){
        if(score == 1){
            gameObject.SetActive(true);
        }else{
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
