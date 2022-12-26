using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedBall : MonoBehaviour
{

    private float rotz;
    [SerializeField] private float RotationSpeed;
    public bool ClokkwiseRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ClokkwiseRotation == false)
        {
            rotz +=Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotz += -Time.deltaTime * RotationSpeed;

        }
        transform.rotation = Quaternion.Euler(0,0,rotz);
    }
}
