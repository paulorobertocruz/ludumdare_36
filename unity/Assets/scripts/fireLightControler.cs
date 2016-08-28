using UnityEngine;
using System.Collections;

public class fireLightControler : MonoBehaviour {

    public float duration = 0.1F;
    public Light lt;
    void Start()
    {
        lt = GetComponent<Light>();
    }
    void Update()
    {
        float phi = Time.time / duration * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * 0.9F + 0.5f;
        lt.intensity = amplitude+0.5f;
    }
}
