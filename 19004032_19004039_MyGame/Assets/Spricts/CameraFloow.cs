using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class CameraFloow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;
    private void Start()
    {
         // Create a temporary reference to the current scene.
         Scene currentScene = SceneManager.GetActiveScene ();
         // Retrieve the name of this scene.
         string sceneName = currentScene.name;
         if (sceneName == "LV1") 
         {
            AudioManager.instance.Stop("NhacNenBG");
            AudioManager.instance.Play("NhacNenLV1");
            AudioManager.instance.Stop("NhacNen");
            AudioManager.instance.Stop("NhacNenLV3");
         }
         else if (sceneName == "LV2")
         {
            AudioManager.instance.Stop("NhacNenBG");
            AudioManager.instance.Stop("NhacNenLV1");
            AudioManager.instance.Play("NhacNen");
            AudioManager.instance.Stop("NhacNenLV3");
         }
        else if (sceneName == "LV3")
         {
            AudioManager.instance.Stop("NhacNenBG");
            AudioManager.instance.Stop("NhacNenLV1");
            AudioManager.instance.Stop("NhacNen");
            AudioManager.instance.Play("NhacNenLV3");
         }
    }
    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
