/*
Generated by UnityTwine on 4/3/2016 9:22:32 PM
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class suitorsintro2: TwineStory
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
		passageInit_1();
		passageInit_2();
	}
    
	// .............
	// #0: Start

	void passageInit_0()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{ "1,", "<beau>,", "<center>,", "<frown>", }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"BEAUREGARD: There you are! I thought I was going to have to drag you in here by the scruff of your neck.");
		yield return new TwineText(@"");
		yield return new TwineText(@"[1, <beau>, <center>, <neutral>]");
		yield return new TwineText(@"BEAUREGARD: As long as you stay hidden behind the one-way mirrors set up across the castle, no one will see you.");
		yield return new TwineText(@"");
		yield return new TwineText(@"[1, <beau>, <center>, <smile>]");
		yield return new TwineText(@"BEAUREGARD: It's a good thing your great-grandfather was so paranoid about spies and invaders!");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAUREGARD: Now, are you ready?");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: As ready as I'll ever be, I suppose.");
		yield return new TwineText(@"");
		yield return new TwineText(@"[1, <beau>, <center>, <frown>]");
		yield return new TwineText(@"BEAUREGARD: Such enthusiasm. Remember, keep a light tone when you speak to these women! You're going to end up married to one of them.");
		yield return new TwineText(@"");
		yield return new TwineText(@"[1, <beau>, <center>, <neutral>]");
		yield return new TwineText(@"BEAUREGARD: I'll leave you to it now, sire.");	
	}
    
	// .............
	// #1: StoryTitle

	void passageInit_1()
	{
		this.Passages["StoryTitle"] = new TwinePassage("StoryTitle", new string[]{  }, passageExecute_1);
	}

	IEnumerable<TwineOutput> passageExecute_1()
	{
		yield return new TwineText(@"Untitled Story");	
	}
    
	// .............
	// #2: StoryAuthor

	void passageInit_2()
	{
		this.Passages["StoryAuthor"] = new TwinePassage("StoryAuthor", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"Anonymous");	
	}

}