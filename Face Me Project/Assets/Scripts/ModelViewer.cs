using UnityEngine;
using UnityEngine.SceneManagement;

public class ModelViewer : MonoBehaviour {

    public GameObject modelViewerUI;
    public GameObject BackButton;
    public GameObject ActiveGameObject;

    public void LoadMenu() {
        Debug.Log("Loading menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void OpenViewer(GameObject model) {
        modelViewerUI.SetActive(false);
        model.SetActive(true);
        ActiveGameObject = model;
        BackButton.SetActive(true);
	}

    public void CloseViewer() {
        modelViewerUI.SetActive(true);
        BackButton.SetActive(false);
        ActiveGameObject.SetActive(false);
    }
}
