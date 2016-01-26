public class Sequence : Node
{
	private Node[] childNodes;

	public Sequence(params Node[] childNodes)
	{
		this.childNodes = childNodes;
	}


	public override void ExecuteNode() {
		bool sequenceSuccesful = true;

		for (int i = 0; i < childNodes.Length; i++) {
			childNodes[i].ExecuteNode();
			if (!childNodes[i].success) {
				sequenceSuccesful = false;
				break;
			}
		}

		success = sequenceSuccesful;
	}
}
