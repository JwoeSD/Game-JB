using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
//public class zorgt ervoor dat je de code/functie kan aanpassen via de game zelf en niet in de script hoeft te komen voor aanpassingen//
//de functie MoveToScene zorgt ervoor dat de scene overgaat naar de volgende scene, omdat het public is kan de scene verandering aangepast worden//
//scene ID geeft aan welke scene wordt voorgebracht//




