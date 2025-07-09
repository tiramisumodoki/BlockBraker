using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("ゲームを終了します");
        Application.Quit(); 
    }   



}
