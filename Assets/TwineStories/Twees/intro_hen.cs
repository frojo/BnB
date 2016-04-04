/*
Generated by UnityTwine on 4/3/2016 9:22:33 PM
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class intro_hen: TwineStory
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
		passageInit_3();
	}
    
	// .............
	// #0: Start

	void passageInit_0()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{  }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"%<1>, <hen>, <center>, <neutral>%");
		yield return new TwineText(@"HENRIETTA: MOOOOOOOOOOOOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Yes, um. Well, my name is...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Adam.]]
		[[Prince Adam.", @"Adam.]]
		[[Prince Adam.", @"Adam.", null, null);
		yield return new TwineLink(@"The Beast.", @"The Beast.", @"Adam.", null, null);	
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
	// #2: Adam.

	void passageInit_2()
	{
		this.Passages["Adam."] = new TwinePassage("Adam.", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"HENRIETTA: MMMMMMOOOOOOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Er....right. Nice meeting you, too.");	
	}
    
	// .............
	// #3: StoryAuthor

	void passageInit_3()
	{
		this.Passages["StoryAuthor"] = new TwinePassage("StoryAuthor", new string[]{  }, passageExecute_3);
	}

	IEnumerable<TwineOutput> passageExecute_3()
	{
		yield return new TwineText(@"Anonymous");	
	}

}