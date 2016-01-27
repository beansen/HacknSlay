public class Sequence : Node
{
	private Node[] childNodes;

	public Sequence(params Node[] childNodes)
	{
		this.childNodes = childNodes;
	}


	public override void ExecuteNode() {
		for (int i = 0; i < childNodes.Length; i++) {
			childNodes[i].ExecuteNode();
			if (childNodes[i].state == NodeState.FAILURE) {
				state = NodeState.FAILURE;
				break;
			}
		}
	}
}
