using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour
{
    public GameObject enemigos;
    public float intervalogeneracion = 3f;
    public Vector3 limitesinferiores;
    public Vector3 limitessuperiores;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generarenemigos());

    }

    IEnumerator generarenemigos()
    {
        while(true)
        {
            Vector3 posicionaleatoria = new Vector3(
                Random.Range(limitesinferiores.x, limitessuperiores.x),
                Random.Range(limitesinferiores.y, limitessuperiores.y),
                Random.Range(limitesinferiores.z, limitessuperiores.z)
            );
            Instantiate(enemigos, posicionaleatoria, Quaternion.identity);
            yield return new WaitForSeconds(intervalogeneracion);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
