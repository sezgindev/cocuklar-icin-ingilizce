using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class loadscene : MonoBehaviour {

    public void Eğitim()     //Eğitim Menüleri
    {
        Application.LoadLevel("EğitimMenüsi");
    }
    public void Sınav()      //Sınav Menüleri
    {
        Application.LoadLevel("SınavMenüsü");
    }
   
    //  ------------------------------------ 
    public void AnimalEğit()
    {
        Application.LoadLevel("AnimalEgitim");
    }
    public void ColorEğit()
    {       
        Application.LoadLevel("ColorEgitim");               //Eğitim Menüleri
    }
    public void JobEğit()
    {
        Application.LoadLevel("JobsEgitim");
    }

    // -------------------------------------

    public void AnimSınav()
    {
        Application.LoadLevel("AnimTest");
    }
    public void ColorSınav()
    {                                                       //Sınav Menüleri
        Application.LoadLevel("ColorTest");
    }
    public void JobSınav()
    {
        Application.LoadLevel("JobTest");
    }

    //---------------------------------------


    public void Çıkış()
    {
        Application.Quit();
        Debug.Log("sss");
  
    }
    public void anasayfa()
    {
        Application.LoadLevel("GirişMenü");
    }
  
}
