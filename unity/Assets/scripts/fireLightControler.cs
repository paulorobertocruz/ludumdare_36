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
        float amplitude = Mathf.Cos(phi) * 3F + 3f;
        lt.intensity = amplitude + 1.5f;
    }
}
