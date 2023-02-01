using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] Sahneler;
    public int artmak = 0;
    public GameObject ileributton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void tikla()
    {
        for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);


        }
  
    }

    public void ilerle()
     {
        artmak +=1;
        Sahneler[artmak].SetActive(true);
        if (artmak == 2 )
        {
            ileributton.SetActive(false);
            artmak = 5;
        }
        else if (artmak == 13 )
        {   
            ileributton.SetActive(false);
            
            //artmak = 15;
        }
        else if (artmak == 14 )
        {
            ileributton.SetActive(false);
        }
        else if (artmak == 15 )
        {
            ileributton.SetActive(true);
            
            //artmak = 5;
        }
        else if (artmak == 16)
        {
            ileributton.SetActive(false);
        }
        else
        {
            ileributton.SetActive(true);
        }
        Debug.Log(artmak);
        
     }







}
