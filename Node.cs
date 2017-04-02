using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Node
{
	private string dialogue = "";
	private bool hasClue = false;
	private string clue = "";
	private List<Node> nextNodes = new List<Node>();
	private bool nextIsStore = false;
	private bool nextIsReceipt = false;
	private Dictionary<Button, Item> storeItems = new Dictionary<Button, Item>();
//	private Sprite myBackground;

	private AudioClip myAudioClip;
	private AudioClip myMusicClip;
	private bool hasAudioClip = false;
	private bool hasMusicClip = false;

	public Node  ()
	{
	}


	// =====================================
	// GET INFORMATION ABOUT NODE VARIABLES
	// =====================================

	public string GetDialogue()
	{
		return this.dialogue;
	}

	public List<Node> GetNextNodes()
	{
		return this.nextNodes;
	}

	public bool GetHasClue()
	{
		return this.hasClue;
	}

	public string GetClue()
	{
		return this.clue;
	}

	public bool GetNextIsStore()
	{
		return this.nextIsStore;
	}

	public bool GetNextIsReceipt()
	{
		return this.nextIsReceipt;
	}

	public Dictionary<Button, Item> GetDic()
	{
		return this.storeItems;
	}

	public AudioClip GetMyAudioClip()
	{
		return this.myAudioClip;
	}

	public AudioClip GetMyMusicClip()
	{
		return this.myMusicClip;
	}

	public bool GetHasAudioClip()
	{
		return this.hasAudioClip;
	}

	public bool GetHasMusicClip()
	{
		return this.hasMusicClip;
	}

//	public Sprite GetMyBackground()
//	{
//		return this.myBackground;
//	}

	// =============================
	// SET VALUES OF NODE VARIABLES
	// =============================

	public void AddNextNodes(List<Node> _nextNodes)
	{
		this.nextNodes = _nextNodes;
	}

	public void SetDialogue(string _dialogue)
	{
		this.dialogue = _dialogue;
	}

	public void SetHasClue(bool _hasClue)
	{
		this.hasClue = _hasClue;
	}

	public void SetClue(string _clue)
	{
		this.clue = _clue;
	}

	public void SetNextIsStore(bool _isStore)
	{
		this.nextIsStore = _isStore;
	}

	public void SetStoreItems(Button _button, Item _item)
	{
		this.storeItems.Add(_button, _item);
	}

	public void SetNextIsReceipt(bool _isReceipt)
	{
		this.nextIsReceipt = _isReceipt;
	}

	public void SetHasAudioClip(bool _hasAudioClip) 
	{
		this.hasAudioClip = _hasAudioClip;
	}

	public void SetMyAudioClip(AudioClip _myAudioClip)
	{
		this.myAudioClip = _myAudioClip;
	}

	public void SetHasMusicClip(bool _hasMusicClip)
	{
		this.hasMusicClip = _hasMusicClip;
	}

	public void SetMyMusicClip(AudioClip _myMusicClip)
	{
		this.myMusicClip = _myMusicClip;
	}

//	public void SetMyBackground(Sprite _myImage)
//	{
//		this.myBackground = _myImage;
//	}
}