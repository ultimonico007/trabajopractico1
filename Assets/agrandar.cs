using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agrandar : MonoBehaviour
{
    public Vector3 tama�oMinimo = new Vector3(1f, 1f, 1f);
    public Vector3 tama�oMaximo = new Vector3(2f, 2f, 2f);
    public float intervalo = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CambiarTamano());
    }
    IEnumerator CambiarTamano()
    {
        while (true)
        {
            transform.localScale = tama�oMinimo;
            yield return new WaitForSeconds(intervalo);
            transform.localScale = tama�oMaximo;
            yield return new WaitForSeconds(intervalo);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
