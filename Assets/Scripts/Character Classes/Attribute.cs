public class Attribute : BaseStat {
	// inherits from BaseStat
	
	// Default constructor
	public Attribute () {
		ExpToLevel = 50;
		LevelModifier = 1.05f;
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
