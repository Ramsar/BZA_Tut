using UnityEngine;
using System.Collections;
using System;

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
	public void SaveCharacterData () {
		GameObject pc = GameObject.Find("pc");							// ref to character
		PlayerCharacter pcClass = pc.GetComponent<PlayerCharacter>();	// ref to player character class attached to it
		
		PlayerPrefs.DeleteAll(); // Delete old PlayerPrefs
		
		PlayerPrefs.SetString("Player Name", pcClass.Name);	// save player name		
		
		// Save attribute parameters
		for (int cnt = 0; cnt < Enum.GetValues(typeof(AttributeName)).Length; cnt++) 
		{
			PlayerPrefs.SetInt(((AttributeName)cnt).ToString() + " - Base Value", 
				pcClass.GetPrimaryAttribute(cnt).BaseValue);
			PlayerPrefs.SetInt(((AttributeName)cnt).ToString() + " - Exp To Level", 
				pcClass.GetPrimaryAttribute(cnt).ExpToLevel);
		}
		
		// Save vital parameters
		for (int cnt = 0; cnt < Enum.GetValues(typeof(VitalName)).Length; cnt++) 
		{
			PlayerPrefs.SetInt(((VitalName)cnt).ToString() + " - Base Value", 
				pcClass.GetVital(cnt).BaseValue);
			PlayerPrefs.SetInt(((VitalName)cnt).ToString() + " - Exp To Level", 
				pcClass.GetVital(cnt).ExpToLevel);
			PlayerPrefs.SetInt(((VitalName)cnt).ToString() + " - Cur Value", 
				pcClass.GetVital(cnt).CurValue);
			
			PlayerPrefs.SetString(((VitalName)cnt).ToString() + " - Mods", 
				pcClass.GetVital(cnt).GetModifyingAttributesString());
		}
		
		// Save skill parameters
		for (int cnt = 0; cnt < Enum.GetValues(typeof(SkillName)).Length; cnt++) 
		{
			PlayerPrefs.SetInt(((SkillName)cnt).ToString() + " - Base Value", 
				pcClass.GetSkill(cnt).BaseValue);
			PlayerPrefs.SetInt(((SkillName)cnt).ToString() + " - Exp To Level", 
				pcClass.GetSkill(cnt).ExpToLevel);
			
			PlayerPrefs.SetString(((SkillName)cnt).ToString() + " - Mods", 
				pcClass.GetSkill(cnt).GetModifyingAttributesString());
		}
	}
	
	// Load character data
	public void LoadCharacterData () {
		
	}
}
