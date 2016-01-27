public abstract class Node
{
	protected NodeState state = NodeState.FAILURE;

	public abstract void ExecuteNode();
}

public enum NodeState {
	RUNNING,
	SUCCESS,
	FAILURE
}