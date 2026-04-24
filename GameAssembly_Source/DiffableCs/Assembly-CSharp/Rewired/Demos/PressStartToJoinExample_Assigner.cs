namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PressStartToJoinExample_Assigner : MonoBehaviour
{
	private class PlayerMap
	{
		public int rewiredPlayerId; //Field offset: 0x10
		public int gamePlayerId; //Field offset: 0x14

		public PlayerMap(int rewiredPlayerId, int gamePlayerId) { }

	}

	private static PressStartToJoinExample_Assigner instance; //Field offset: 0x0
	public int maxPlayers; //Field offset: 0x18
	private List<PlayerMap> playerMap; //Field offset: 0x20
	private int gamePlayerIdCounter; //Field offset: 0x28

	public PressStartToJoinExample_Assigner() { }

	private void AssignNextPlayer(int rewiredPlayerId) { }

	private void Awake() { }

	private int GetNextGamePlayerId() { }

	public static Player GetRewiredPlayer(int gamePlayerId) { }

	private void Update() { }

}

