using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameSaveManager saveManager;

    private void Start()
    {
        LoadGame();
    }

    public void SaveGame()
    {
        saveManager.SaveGame(); // Call SaveGame without arguments
    }

    public void LoadGame()
    {
        saveManager.LoadGame(); // Load the saved game
    }
}
