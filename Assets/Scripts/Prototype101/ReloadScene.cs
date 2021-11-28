using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour 
{
	void Update()
	{
		// press R to use the ReloadingScene method
		if (Input.GetKeyDown(KeyCode.R))
		{
			ReloadingScene();
		}
	}

	void ReloadingScene()
	{
		// // Here are 3 different ways to use the Scene Manager:
		
		// // 1) Is to use the scene name and place into the brackets.
		// // This is no ideal, as it can cause problems, when you rename the scene
		// SceneManager.LoadScene("Prototype101");
		
		// // 2) This uses the order defined in the Build Settings. You need to add the scene at "File/Build Settings/" for it to work.
		// // This is useful, when using an array to switch between scenes. But can cause problems, when you change the scene order.
		// SceneManager.LoadScene(0);

		// // 3) This uses another method to return the active scene name and uses that value for reloading
		// // This is the most flexible, as you can rename the scene and change the build order. 
		// // BUT only if you have one scene to reload. If you have more than one scene, additional methods are needed.
		// Debug.Log(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
