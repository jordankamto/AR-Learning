using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerDeScene : MonoBehaviour
{
    public string levelLoad;

    public void Info()
    {
        levelLoad = "InformatiqueQuantique";
        SceneManager.LoadScene(levelLoad);
    }

    public void Chimie()
    {
        levelLoad = "ChimieOrganique";
        SceneManager.LoadScene(levelLoad);
    }

    public void Bio()
    {
        levelLoad = "";
        SceneManager.LoadScene(levelLoad);
    }

    public void Retour()
    {
        levelLoad = "SampleScene";
        SceneManager.LoadScene(levelLoad);
    }
}
