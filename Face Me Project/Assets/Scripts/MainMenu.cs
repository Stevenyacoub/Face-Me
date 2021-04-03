using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    public void StartGallery(){
        SceneManager.LoadScene("Gallery");
    }

    public void StartViewer(){
        SceneManager.LoadScene("ModelViewer");
    }

}
