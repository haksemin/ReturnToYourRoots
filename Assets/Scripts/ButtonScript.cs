using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameManager manager;
    public int aritmak;
    public GameObject YouFailed;
    public GameObject YouWin;
    public GameObject[] Sahneler;
    public GameObject ileributton;
    public GameObject hizmetcidinleniyor;
    public GameObject hizmetcizindanagider;


     public void degistiriciyedi()
     {
        for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);


        }
        Sahneler[3].SetActive(true);
        ileributton.SetActive(true);
     }

     
   public void degistiriciyemedi()
     {
                for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);
            

        }

        Sahneler[4].SetActive(true);
        ileributton.SetActive(true);
     }



          public void arastir1()
     {
                for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);


        }
        Sahneler[5].SetActive(true);
        ileributton.SetActive(true);
     }


     public void zindanaat1()
     {
        for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);


        }
        Sahneler[14].SetActive(true);
        ileributton.SetActive(false);
     }
     public void mekanlariarat()
     {
        for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);
            
            aritmak = 14;
            manager.artmak = aritmak;

        }
        Sahneler[15].SetActive(true);
        ileributton.SetActive(true);
        
        
     }

     public void hizmetcizindan()
     {
        for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);
     }
        hizmetcizindanagider.SetActive(true);
     }

    public void hizmetcidinle()
    {
        for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);
    }
    hizmetcidinleniyor.SetActive(true);
    }

     public void Hatun()
     {
        YouFailed.SetActive(true);
     }

     public void Hizmetci()
     {
        YouFailed.SetActive(true);
     }

     public void Asci()
     {
        YouWin.SetActive(true);
     }
}
