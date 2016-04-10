/*
Generated by UnityTwine on 04/10/2016 13:13:56
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class suitorsintro: TwineStory
{
	public override TwineVar this[string name]
	{
		get
		{
			switch(name)
			{
				default: throw new KeyNotFoundException(string.Format("There is no variable with the name '{0}'.", name));
			}
		}
		set
		{
			switch(name)
			{
				default: throw new KeyNotFoundException(string.Format("There is no variable with the name '{0}'.", name));
			}
		}
	}


	void Awake() {
		base.Init();
		passageInit_0();
	}
    
	// .............
	// #0: Start

	void passageInit_0()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{  }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"%1, <beau>, <center>, <frown>%");
		yield return new TwineText(@"BEAUREGARD: There you are! I thought I was going to have to drag you in here by the scruff of your neck.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <beau>, <center>, <smile>%");
		yield return new TwineText(@"BEAUREGARD: Now, are you ready?");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: As ready as I'll ever be, I suppose.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <beau>, <center>, <frown>%");
		yield return new TwineText(@"BEAUREGARD: Such enthusiasm. Remember, keep a light tone when you speak to these women! You're going to end up married to one of them.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <beau>, <center>, <neutral>%");
		yield return new TwineText(@"BEAUREGARD: I'll leave you to it now, sire.");	
	}

}