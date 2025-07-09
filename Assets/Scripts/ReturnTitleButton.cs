using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class ReturnTitleButton : MonoBehaviour
{
	void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(change);		
			
	}
	
	void change()
	{
		SceneManager.LoadScene("TitleScene");
	}
}