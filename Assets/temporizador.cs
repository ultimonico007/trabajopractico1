using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class temporizador : MonoBehaviour
{
    public float tiempoinicial = 10f;
        public TextMeshProUGUI tiempotexto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cronometro());
    }
    IEnumerator cronometro()
    {
        float tiemporestante = tiempoinicial;
        while (tiemporestante >= 0)
        {
            tiempotexto.text = "tiempo: " + tiemporestante.ToString("F0");
            Debug.Log("segundos: " + tiemporestante);
            yield return new WaitForSeconds(1f);
            tiemporestante--;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
