using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOtherScene : MonoBehaviour
{
	void Update()
	{
		// press R to use the ReloadingScene method
		if (Input.GetKeyDown(KeyCode.R))
		{
			LoadingOtherScene();
		}
	}

	void LoadingOtherScene()
	{
		SceneManager.LoadScene("Prototype104");
	}
}
