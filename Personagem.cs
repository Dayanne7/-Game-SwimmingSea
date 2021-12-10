using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    public float speed = 1f;
    private Rigidbody2D rig;

    public GameObject GameOver;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {

        SaveScore.inst.SalveScore_(SpawnPeixes.pontos);
        //SaveScore.inst.Load();
        //SpawnPeixes.pontos = 0;
        SaveScore.inst.Load();
        Tempo.count = 0;
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }


}
