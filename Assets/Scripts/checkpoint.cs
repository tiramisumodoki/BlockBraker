using UnityEngine;

public class checkpoiunt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
		Vector3 topRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

		Debug.Log("画面左下: " + bottomLeft);
    		Debug.Log("画面右上: " + topRight);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
