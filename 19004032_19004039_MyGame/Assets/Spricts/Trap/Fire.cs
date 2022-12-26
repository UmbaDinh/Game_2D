using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private Animator anim;
    private bool isWorking = true;
    [SerializeField] private float cooldown;
    private float cooldownTimer;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isWorking){
            if(collision.tag == "Player")
            {
                //takedamage goi ham tru mau
                collision.GetComponent<Health>().TakeDamage(1);
            }
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if(cooldownTimer < 0){
            isWorking = !isWorking;
            cooldownTimer = cooldown;
        }
        anim.SetBool("isWorking", isWorking);
    }
}
