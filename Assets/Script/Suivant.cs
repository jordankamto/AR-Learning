using UnityEngine;
using UnityEngine.SceneManagement;

public class Suivant : MonoBehaviour
{
    public string levelLoad;

    public void Suivanit1()
    {
        levelLoad = "InformatiqueQuantique 2";
        SceneManager.LoadScene(levelLoad);
    }

    public void Suivant2()
    {
        levelLoad = "InformatiqueQuantique 3";
        SceneManager.LoadScene(levelLoad);
    }

    public void Fin()
    {
        levelLoad = "ChoixMatiere";
        SceneManager.LoadScene(levelLoad);
    }

    public void Suivant4()
    {
        levelLoad = "ChimieOrganique 2";
        SceneManager.LoadScene(levelLoad);
    }
}
