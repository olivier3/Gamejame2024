using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightAnimation : MonoBehaviour
{
    private Light2D _light;
    public float minIntensity = 0.8f;
    public float maxIntensity = 1.2f;
    public float minFlickerSpeed = 0.1f;
    public float maxFlickerSpeed = 2.0f;
    public float minFlickerTime = 0.08f;
    public float maxFlickerTime = 0.15f;

    private void Start()
    {
        if (_light == null)
        {
            _light = GetComponent<Light2D>();
        }

        StartCoroutine(FlickerLight());
    }

    IEnumerator FlickerLight()
    {
        Debug.Log("Flicker");
        float intensity = Mathf.Lerp(minIntensity, maxIntensity, Random.value);
        float flickerSpeed = Random.Range(minFlickerSpeed, maxFlickerSpeed);
        float flickerTime = Random.Range(minFlickerTime, maxFlickerTime);

        _light.intensity = intensity * Mathf.Lerp(_light.intensity, intensity, Time.time * flickerSpeed);

        yield return new WaitForSeconds(flickerTime);
        StartCoroutine(FlickerLight());

    }
}