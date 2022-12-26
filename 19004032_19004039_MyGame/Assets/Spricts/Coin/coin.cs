using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            Debug.Log("xu");
            Add_Coin.numberOfCoins++;
            AudioManager.instance.Play("Coins");    
            Destroy(gameObject);
        }
    }
}
