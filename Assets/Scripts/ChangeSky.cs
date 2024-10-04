using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour
{
    public Material[] skyBox;
    private Light _light;
    private int currentSkyboxIndex = 0;

    private void Start()
    {
        _light = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            _light.enabled = !_light.enabled;
            ChangeSkybox();
        }
    }

    void ChangeSkybox()
    {
        currentSkyboxIndex++;

        if (currentSkyboxIndex >= skyBox.Length)
        {
            currentSkyboxIndex = 0;
        }

        RenderSettings.skybox = skyBox[currentSkyboxIndex];
    }
}
