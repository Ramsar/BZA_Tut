public class Attribute : BaseStat {
	// inherits from BaseStat
	
	private string _name;
	
	// Default constructor
	public Attribute () {
		_name = "";
		ExpToLevel = 50;
		LevelModifier = 1.05f;
	}
	
	public string Name 
	{
		get { return _name; }
		set { _name = value; }
	}
}

// List of attributes
public enum AttributeName {
	Might,
	Constitution,
	Nimbleness,
	Speed,
	Concentration,
	Willpower,
	Charisma

	// if you want a two word attribute use underscore (which is dropped later if you code it appropriately)
}
