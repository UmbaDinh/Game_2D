using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private bool levelCompleted = false;
    [SerializeField] public float vangnext;
    [SerializeField] public float ticme;
    private Animator anim;


    public void Start()
    {
        anim = GetComponent<Animator>();
       // checkVang.Setup(2);
    }

    void Update()
    {
        // Debug.Log("ádasdasd");
        // if(Add_Coin.numberOfCoins >= vangnext)
        // {
        //     Debug.Log("Assssssssssssss");
        //     anini();
        // }
       
    }
    
    private void anini()
    {
        anim.SetTrigger("check");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && !levelCompleted)
        {
            if( Add_Coin.numberOfCoins >= vangnext)
            {
                anini();
                levelCompleted = true;
                Invoke("CompleteLevel", ticme);
            }
        }
    }

    private void CompleteLevel()
    {
        Debug.Log(Add_Coin.numberOfCoins);
       
            AudioManager.instance.Play("Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     

    }
}
