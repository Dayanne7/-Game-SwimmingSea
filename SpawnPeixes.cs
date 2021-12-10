using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Profiling;

public class SpawnPeixes : MonoBehaviour
{
    public GameObject [] peixinhos;
    public float height;
    public float maxTime;
    private float timer = 0;
    private int j = 0;
    public int tempo = 0;
    public float tempoSpawn;
    public static int pontos=0;
    private Tempo t = new Tempo();
    //public Text te;
   

    void Update()
    {
        tempo++;
        if(timer> maxTime)
        {
            for (int i = 0; i < peixinhos.Length; i++)
            {
                float randomY = Random.Range(-1.4f, 3.5f);
                GameObject newPeixe = Instantiate(peixinhos[i]);
                newPeixe.transform.position = transform.position + new Vector3(0, randomY, 0);
                Destroy(newPeixe, 20f);
                timer = 0;
                Ponto();
            }
           
        }

       timer += Time.deltaTime;

    }

    void Ponto()
    {
       
        pontos = (int)Tempo.count;
        //te.text = pontos.ToString();
    }
}
