using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameObject[] Sahneler;
    int artmak = 0;
    public GameObject ileributton;


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
        ileributton.SetActive(true);
     }
     public void mekanlariarat()
     {
        for (int i = 0; i < Sahneler.Length; i++)
        {
            Sahneler[i].SetActive(false);


        }
        Sahneler[15].SetActive(true);
        ileributton.SetActive(true);
     }
}
