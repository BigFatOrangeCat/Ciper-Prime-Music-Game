using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject theP;
    public int Parcount;
    public float Radius;
    [Range(0.2f, 10)]
    public float timeinterval;
    public float Partime;

    void Update()
    {
        StartCoroutine(Pardrop());


    }
    IEnumerator Pardrop()
    {
        while (true)
        {

            GameObject obj = Instantiate(theP, transform.position + (Random.insideUnitSphere * Radius), Quaternion.identity);
            yield return new WaitForSeconds(timeinterval);
            Destroy(obj,1.5f);

        }
    }

}