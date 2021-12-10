using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveScore : MonoBehaviour
{
    public static SaveScore inst = null;
    public Text p;

    private void Awake()
    {

        //apagar as informações que foram salvas
        PlayerPrefs.DeleteAll();
        if (inst == null)
        {
            inst = this;
            //DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }




    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            Load();

        }

    }

    // Update is called once per frame
    void Update()
    {
        SalveScore_(SpawnPeixes.pontos);
    }

    public void SalveScore_(int val)
    {
        if (PlayerPrefs.GetInt("Score") < SpawnPeixes.pontos)
        {
            PlayerPrefs.SetInt("Score", val);
            Load();
        }
        

    }

    public int Load()
    {
        //Debug.Log(PlayerPrefs.GetInt("Score").ToString());
        p.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
        return PlayerPrefs.GetInt("Score");
    }
}