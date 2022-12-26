using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Scroller : MonoBehaviour {
    [SerializeField] int yne = -28;
    void Update()
    {
        transform.position += new Vector3(0, -2 * Time.deltaTime);

        if(transform.position.y < yne)
        {
            transform.position=new Vector3(transform.position.x, 28);
        }
    }
   
}
 