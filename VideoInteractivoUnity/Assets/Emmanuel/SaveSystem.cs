using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSystem : MonoBehaviour
{
    [Header("Jugador")]
    public Transform player;

    [Header("Nombre de escena actual")]
    public string currentScene;

    // GUARDAR PARTIDA
    public void SaveGame()
    {
        // Posición del jugador
        PlayerPrefs.SetFloat("PlayerX", player.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.position.y);
        PlayerPrefs.SetFloat("PlayerZ", player.position.z);

        // Escena actual
        PlayerPrefs.SetString("SavedScene", currentScene);

        // Guardar datos
        PlayerPrefs.Save();

        Debug.Log("Partida guardada");
    }

    // CARGAR PARTIDA
    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedScene"))
        {
            string savedScene = PlayerPrefs.GetString("SavedScene");

            // Cargar escena guardada
            SceneManager.LoadScene(savedScene);
        }
        else
        {
            Debug.Log("No hay partida guardada");
        }
    }

    // RESTAURAR POSICIÓN
    void Start()
    {
        if (PlayerPrefs.HasKey("PlayerX"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX");
            float y = PlayerPrefs.GetFloat("PlayerY");
            float z = PlayerPrefs.GetFloat("PlayerZ");

            player.position = new Vector3(x, y, z);
        }
    }
}
