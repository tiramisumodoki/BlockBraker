using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class RetryButton : MonoBehaviour
{
	void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(change);		
			
	}
	
	void change()
	{
		SceneManager.LoadScene("maingame");
	}
}