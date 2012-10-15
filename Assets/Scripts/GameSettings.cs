using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {
	
	// Awake
	void Awake () {
		// tell game that this object shouldn't be destroyed on load, but passed on
		DontDestroyOnLoad(this);	
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Save character data
	void SaveCharacterData () {
		GameObject pc = GameObject.Find("pc");							// ref to character
		PlayerCharacter pcClass = pc.GetComponent<PlayerCharacter>();	// ref to player character class attached to it
		PlayerPrefs.SetString("Player Name", pcClass.Name);		
	}
	
	// Load character data
	void LoadCharacterData () {
		
	}
}
