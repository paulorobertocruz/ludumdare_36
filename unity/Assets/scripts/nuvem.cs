using UnityEngine;
using System.Collections;

public class nuvem : MonoBehaviour {

    // Use this for initialization
    float position;
    float tempo;

    public GameObject fogo;
    
    void Start () {
	}

    // Update is called once per frame
    void Update () {
        tempo += Time.deltaTime;

        if (tempo >= 5) {
            Instantiate(fogo,transform.position,transform.rotation);
            tempo = 0;
        }
        transform.transform.position = new Vector3(Random.Range(86f, 410f), 9, Random.Range(90f, 390f));

    }
}
