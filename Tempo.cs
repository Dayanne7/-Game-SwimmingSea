using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tempo : MonoBehaviour
{
    public Text timer;
    public static float count = 0;
    public bool tempoAcabou = false;
    //public GameObject go;


    public void Update()
    {
        ContarTempo();
    }

    public void ContarTempo()
    {

        
        count += Time.deltaTime;

        timer.text = count.ToString("F0");
            //VerificarTempo();
        

    }

    public bool VerificarTempo()
    {
        if (count <= 0.0f)
        {
            this.tempoAcabou = true;
            Time.timeScale = 0;
            //Debug.Log ("Acabou tempo");
            SaveScore.inst.SalveScore_(SpawnPeixes.pontos);
            SpawnPeixes.pontos = 0;
            //go.SetActive(true);
        }
        else
        {
            this.tempoAcabou = false;

            //Time.timeScale = 1;
            //Debug.Log ("NÂO acabou tempo");
        }
        return this.tempoAcabou;
    }

}