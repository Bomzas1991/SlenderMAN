using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashLightScript : MonoBehaviour
{
    public Light flashLight;
    public bool isOn;
    public AudioSource audioSource;
    public AudioClip flashlightButton;
    public float timer = 0;

    public int battery1 = 10;

    void Update()
    {
        if (isOn)
        {
            timer += Time.deltaTime;
        }

        if (timer < battery1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOn = !isOn;
                audioSource.PlayOneShot(flashlightButton);
            }
        }

        else if (timer >= battery1)
        {
            flashLight.intensity -= 1f;
            timer = 0;
        }

        flashLight.enabled = isOn;
    }
}
