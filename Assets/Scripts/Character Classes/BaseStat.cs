public class BaseStat {
	
	// Vars
#region Vars
	// underscore before variable is to denote that this variable
	// is private and has a basic setter and getter
	private int _baseValue;			// base value of the stat
	private int _buffValue;			// amount of buff to this stat
	private int _expToLevel;		// total amount of exp needed to raise this skill
	private float _levelModifier;	// modifier applied to the exp needed to raise the skill
#endregion
	
	// Basic constructor
	public BaseStat () {
		_baseValue = 0;
		_buffValue = 0;
		_levelModifier = 1.1f; 	// 10% needed to raise
		_expToLevel = 100; 		// 100 needed to upgrade to next level, level after that will be 110 (see _levelModifier)
	}
	
#region Basic setters and getters
	// Basic setters and getters
	public int BaseValue {
		get { return _baseValue; }
		set { _baseValue = value; }
	}
	
	public int BuffValue {
		get { return _buffValue; }
		set { _buffValue = value; }
	}
	
	public int ExpToLevel {
		get { return _expToLevel; }
		set { _expToLevel = value; }
	}
	
	public float LevelModifier {
		get { return _levelModifier; }
		set { _levelModifier = value; }
	}
#endregion
	
	// Calculate exp to level
	private int CalculateExpToLevel () {
		return (int) (_expToLevel * _levelModifier);
	}
	
	// Level up
	public void LevelUp () {
		_expToLevel = CalculateExpToLevel();
		_baseValue++;
	}
	
	/* if we use getter and setter, no braces are needed when calling this method
	 	equivalent (where braces are needed):
	
	public int AdjustedBaseValue () {
		return _baseValue + _buffValue;
	}
	*/
	public int AdjustedBaseValue {
		get { return _baseValue + _buffValue; }
	}
	
	
}
