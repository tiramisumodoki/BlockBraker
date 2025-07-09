using UnityEngine;
using UnityEngine.SceneManagement;
public class BlockManager:MonoBehaviour
{

	public Transform blockcount; 
    	// Start is called once before the first execution of Update after the MonoBehaviour is created
    	void Start()
    	{
        
    	}

    	// Update is called once per frame
    	void Update()
	{
		GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");

    		if (blocks.Length == 0)
    		{
        		Debug.Log("すべてのブロックが消えました！");
        		SceneManager.LoadScene("GameClearScene");
    		}
	}
}
