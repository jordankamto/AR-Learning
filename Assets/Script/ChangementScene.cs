using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangementScene : MonoBehaviour
{
    public string levelToLoad = "ChoixMatiere";

    public void Lancer()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quitter()
    {
        Debug.Log("Fermeture de l'application");
        Application.Quit();
    }
}
