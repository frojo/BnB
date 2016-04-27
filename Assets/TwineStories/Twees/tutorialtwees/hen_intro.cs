/*
Generated by UnityTwine on 4/27/2016 6:31:00 PM
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class hen_intro: TwineStory
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
	}
    
	// .............
	// #0: Start

	void passageInit_0()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{  }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"$HenSmile$");
		yield return new TwineText(@"%1, <hen>, <center>, <neutral>%");
		yield return new TwineText(@"HENRIETTA: MOOOOOOOOOOOOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Yes, um. Well, my name is...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Adam.", @"Adam.", @"hen", null, null);
		yield return new TwineLink(@"Prince Adam.", @"Prince Adam.", @"hen", null, null);
		yield return new TwineLink(@"The Beast.", @"The Beast.", @"hen", null, null);	
	}
    
	// .............
	// #1: hen

	void passageInit_1()
	{
		this.Passages["hen"] = new TwinePassage("hen", new string[]{  }, passageExecute_1);
	}

	IEnumerable<TwineOutput> passageExecute_1()
	{
		yield return new TwineText(@"$HenSmile$");
		yield return new TwineText(@"HENRIETTA: MMMMMMOOOOOOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Er....right. Nice meeting you, too.");	
	}

}