using System.Collections.Generic; 

public class ModifiedStat : BaseStat {
	// inherits from BaseStat
	
	private List<ModifyingAttribute> _mods;	// a list of attributes that modify this stat
	private int _modValue;					// the amount added to the baseValue from the modifiers
	
	
	// Constructor
	public ModifiedStat () {
		_mods = new List<ModifyingAttribute>();
		_modValue = 0;
	}
	
	// Add modifier to list
	public void AddModifier (ModifyingAttribute mod) {
		_mods.Add(mod);
	}
	
	//
	private void CalculateModValue () {
		_modValue = 0; // just to make sure that it's zero
		
		if (_mods.Count > 0) // have a least one value in list
		{
			foreach (ModifyingAttribute att in _mods)
			{
				_modValue += (int) (att.attribute.AdjustedBaseValue * att.ratio);
			}
		}
	}
	
	// Polymorphism (overwrite base class method
	public new int AdjustedBaseValue {
		get { return BaseValue + BuffValue + _modValue; }
		// this uses the getters for _baseValue and _buffValue
	}
	
	// Not the update from Monobehaviour
	public void Update () {
		CalculateModValue();
	}
	
	// (assist in saving)
	public string GetModifyingAttributesString () {
		string temp = "";
		
//		UnityEngine.Debug.Log(_mods.Count);
		
		for (int cnt= 0; cnt < _mods.Count; cnt++)
		{
			temp += _mods[cnt].attribute.Name;
			temp += "_";
			temp += _mods[cnt].ratio;
			
			if (cnt < _mods.Count - 1) // if not the last modifying attribute
				temp += "|";
//			UnityEngine.Debug.Log(_mods[cnt].attribute.Name);
//			UnityEngine.Debug.Log(_mods[cnt].ratio);
			
		}
//		UnityEngine.Debug.Log(temp);
		return temp;
	}
}

// Structure: like a class, but with no methods, to hold a bunch of vars together
public struct ModifyingAttribute {
	public Attribute attribute; // instance of Attribute class
	public float ratio;			// effect of stat on attribute
	
	// constructor
	public ModifyingAttribute (Attribute att, float rat) {
		attribute = att;
		ratio = rat;
	}
}
