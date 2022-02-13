using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class WaveSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start () {
		//Button btn = WaveSpawner.GetComponent<Button>();
		//btn.onClick.AddListener(TaskOnClick);
	}

	/*void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}*/

    int n;
   public void OnButtonPress(){
        n++;
        Debug.Log("Button clicked " + n + " times.");
        Vector3 startVector = new Vector3(-2375.0F, 775.0F, 2.0F);
        Enemy.Create(startVector);
   }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
