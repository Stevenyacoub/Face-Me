using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

    public GameObject fadePanel;
    public Image statementImage;
    public Image creditsImage;
    public GameObject backButton;
    protected Image activeImage;

    public float fadeDuration = 0.4f;

    public void StartGallery(){
        SceneManager.LoadScene("Gallery");
    }

    public void StartViewer() {
        SceneManager.LoadScene("ModelViewer");
    }

    public void DisplayStatement() {
        Image fadeImg = fadePanel.GetComponent<Image>();
        activeImage = statementImage;
        fadePanel.SetActive(true);
        backButton.SetActive(true);
        StartCoroutine(Fade(fadeImg, 0, .5f));
        StartCoroutine(Fade(statementImage, 0, 1));
	}

    public void DisplayCredits() {
        Image fadeImg = fadePanel.GetComponent<Image>();
        activeImage = creditsImage;
        fadePanel.SetActive(true);
        backButton.SetActive(true);
        StartCoroutine(Fade(fadeImg, 0, .5f));
        StartCoroutine(Fade(creditsImage, 0, 1));
    }

    public void HideImage() {
        Image fadeImg = fadePanel.GetComponent<Image>();
        var tempPanelColor = fadeImg.color;
        var tempImgColor = activeImage.color;
        tempPanelColor.a = 0;
        tempImgColor.a = 0;
        fadeImg.color = tempPanelColor;
        activeImage.color = tempImgColor;
        fadePanel.SetActive(false);
        backButton.SetActive(false);
    }

    public IEnumerator Fade(Image fadeImg, float start, float end) {
        float counter = 0f;
        while (counter < fadeDuration) {
            var tempColor = fadeImg.color;
            counter += Time.deltaTime;
            tempColor.a = Mathf.Lerp(start, end, counter / fadeDuration);
            fadeImg.color = tempColor;

            yield return null;
		}
    }

}
