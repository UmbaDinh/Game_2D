using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    [Header ("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth {get; private set;}
    private bool dead;
    private Animator anim;

    [Header("iFrames")]
    [SerializeField] private float iFramesDuration; // bat kha xam pham
    [SerializeField] private int numberOfFlashes; // so lan nhap nhay
    private SpriteRenderer spriteRend;

    [SerializeField] public GameOver gameOver;
    int maxPlatform = 0;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //player hurt
            anim.SetTrigger("hurt");
            StartCoroutine(Invunerability());
        }
        else
        {
            //player die
            if(!dead)
            {
                AudioManager.instance.Play("GameOver");
                anim.SetTrigger("die");
                GetComponent<PlayerController>().enabled = false;
                dead = true; 
                Add_Coin.numberOfCoins = 0;
                StartCoroutine(waiter());
            }
        }
    }

    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(2);
        gameOver.Setup(maxPlatform);

    }

    public void AddHealth(float value)
    {
        currentHealth = Mathf.Clamp(currentHealth + value, 0, startingHealth);
    }

    //Ham bat kha xam pham
    private IEnumerator Invunerability()
    {
        Physics2D.IgnoreLayerCollision(7, 0, true);
        //Thoi gian bat kha xam pham
        for (int i = 0; i < numberOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(7, 0, false);
    }


}
