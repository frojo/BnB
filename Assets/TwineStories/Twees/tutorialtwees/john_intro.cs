/*
Generated by UnityTwine on 4/28/2016 10:10:02 PM
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class john_intro: TwineStory
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
		passageInit_4();
		passageInit_5();
		passageInit_6();
		passageInit_7();
		passageInit_8();
		passageInit_9();
	}
    
	// .............
	// #0: Start

	void passageInit_0()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{  }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"%1, <john>, <center>, <neutral>%");
		yield return new TwineText(@"JANE: Hello, your highness. I'm Jane. ");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Good morning. My name is...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Adam.", @"Adam.", @"j1a", null, null);
		yield return new TwineLink(@"Prince Adam.", @"Prince Adam.", @"j1b", null, null);
		yield return new TwineLink(@"The Beast.", @"The Beast.", @"j1c", null, null);	
	}
    
	// .............
	// #1: j1b

	void passageInit_1()
	{
		this.Passages["j1b"] = new TwinePassage("j1b", new string[]{  }, passageExecute_1);
	}

	IEnumerable<TwineOutput> passageExecute_1()
	{
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: Prince, huh? I can work with that.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: So what is it you do in a huge castle like this all day, anyway?");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Sit around moping, according to my butler.", @"Sit around moping, according to my butler.", @"Sit around moping, according to my butler.", null, null);
		yield return new TwineLink(@"A lot of reading, unfortunately.", @"A lot of reading, unfortunately.", @"A lot of reading, unfortunately.", null, null);
		yield return new TwineLink(@"Mostly just wait for a pretty girl like you to come along.", @"Mostly just wait for a pretty girl like you to come along.", @"Mostly just wait for a pretty girl like you to come along.", null, null);	
	}
    
	// .............
	// #2: j1a

	void passageInit_2()
	{
		this.Passages["j1a"] = new TwinePassage("j1a", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"#john_approval, +5#");
		yield return new TwineText(@"%1, <john>, <center>, <neutral>%");
		yield return new TwineText(@"JANE: Adam. Huh. That's...surprisingly normal, I have to admit.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: So what is it you do in a huge castle like this all day, anyway?");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Sit around moping, according to my butler.", @"Sit around moping, according to my butler.", @"Sit around moping, according to my butler.", null, null);
		yield return new TwineLink(@"A lot of reading, unfortunately.", @"A lot of reading, unfortunately.", @"A lot of reading, unfortunately.", null, null);
		yield return new TwineLink(@"Mostly just wait for a pretty girl like you to come along.", @"Mostly just wait for a pretty girl like you to come along.", @"Mostly just wait for a pretty girl like you to come along.", null, null);	
	}
    
	// .............
	// #3: j1c

	void passageInit_3()
	{
		this.Passages["j1c"] = new TwinePassage("j1c", new string[]{  }, passageExecute_3);
	}

	IEnumerable<TwineOutput> passageExecute_3()
	{
		yield return new TwineText(@"%1, <john>, <center>, <neutral>%");
		yield return new TwineText(@"JANE: Jeez, okay. That's one way to make an impression.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: So what is it you do in a huge castle like this all day, anyway?");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Sit around moping, according to my butler.", @"Sit around moping, according to my butler.", @"Sit around moping, according to my butler.", null, null);
		yield return new TwineLink(@"A lot of reading, unfortunately.", @"A lot of reading, unfortunately.", @"A lot of reading, unfortunately.", null, null);
		yield return new TwineLink(@"Mostly just wait for a pretty girl like you to come along.", @"Mostly just wait for a pretty girl like you to come along.", @"Mostly just wait for a pretty girl like you to come along.", null, null);	
	}
    
	// .............
	// #4: A lot of reading, unfortunately.

	void passageInit_4()
	{
		this.Passages["A lot of reading, unfortunately."] = new TwinePassage("A lot of reading, unfortunately.", new string[]{  }, passageExecute_4);
	}

	IEnumerable<TwineOutput> passageExecute_4()
	{
		yield return new TwineText(@"$JohnSmile$");
		yield return new TwineText(@"#john_approval, +5#");
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: Ha! I hear you. My sister's really into books, but I never understood it.");
		yield return new TwineText(@"");
		yield return new TwineText(@"JANE: I can't wait to see your kitchen. It must be huge compared to the one we have at home!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"I'd be happy to show it to you.", @"I'd be happy to show it to you.", @"I'd be happy to show it to you.", null, null);
		yield return new TwineLink(@"The kitchen is for servants, not potential princesses.", @"The kitchen is for servants, not potential princesses.", @"The kitchen is for servants, not potential princesses.", null, null);
		yield return new TwineLink(@"I'm sure the kitchen at your house was much cozier, though.", @"I'm sure the kitchen at your house was much cozier, though.", @"I'm sure the kitchen at your house was much cozier, though.", null, null);	
	}
    
	// .............
	// #5: Sit around moping, according to my butler.

	void passageInit_5()
	{
		this.Passages["Sit around moping, according to my butler."] = new TwinePassage("Sit around moping, according to my butler.", new string[]{  }, passageExecute_5);
	}

	IEnumerable<TwineOutput> passageExecute_5()
	{
		yield return new TwineText(@"$JohnSmile$");
		yield return new TwineText(@"#john_approval, +5#");
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: Ha! That's a good one. Sounds like something my sister would say. ");
		yield return new TwineText(@"");
		yield return new TwineText(@"JANE: I can't wait to see your kitchen. It must be huge compared to the one we have at home!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"I'd be happy to show it to you.", @"I'd be happy to show it to you.", @"I'd be happy to show it to you.", null, null);
		yield return new TwineLink(@"The kitchen is for servants, not potential princesses.", @"The kitchen is for servants, not potential princesses.", @"The kitchen is for servants, not potential princesses.", null, null);
		yield return new TwineLink(@"I'm sure the kitchen at your house was much cozier, though.", @"I'm sure the kitchen at your house was much cozier, though.", @"I'm sure the kitchen at your house was much cozier, though.", null, null);	
	}
    
	// .............
	// #6: Mostly just wait for a pretty girl like you to come along.

	void passageInit_6()
	{
		this.Passages["Mostly just wait for a pretty girl like you to come along."] = new TwinePassage("Mostly just wait for a pretty girl like you to come along.", new string[]{  }, passageExecute_6);
	}

	IEnumerable<TwineOutput> passageExecute_6()
	{
		yield return new TwineText(@"$JohnScared$");
		yield return new TwineText(@"%1, <john>, <center>, <scared>%");
		yield return new TwineText(@"JANE: Right. A girl. Yes.");
		yield return new TwineText(@"");
		yield return new TwineText(@"JANE: I can't wait to see your kitchen. It must be huge compared to the one we have at home!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"I'd be happy to show it to you.", @"I'd be happy to show it to you.", @"I'd be happy to show it to you.", null, null);
		yield return new TwineLink(@"The kitchen is for servants, not potential princesses.", @"The kitchen is for servants, not potential princesses.", @"The kitchen is for servants, not potential princesses.", null, null);
		yield return new TwineLink(@"I'm sure the kitchen at your house was much cozier, though.", @"I'm sure the kitchen at your house was much cozier, though.", @"I'm sure the kitchen at your house was much cozier, though.", null, null);	
	}
    
	// .............
	// #7: I'd be happy to show it to you.

	void passageInit_7()
	{
		this.Passages["I'd be happy to show it to you."] = new TwinePassage("I'd be happy to show it to you.", new string[]{  }, passageExecute_7);
	}

	IEnumerable<TwineOutput> passageExecute_7()
	{
		yield return new TwineText(@"$JohnSmile$");
		yield return new TwineText(@"#john_approval, +5#");
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: That'd be great. I look forward to it.");
		yield return new TwineText(@"");
		yield return new TwineText(@"JANE: Well, I won't keep you from your other ladies-in-waiting any longer. It was nice to meet you.");	
	}
    
	// .............
	// #8: The kitchen is for servants, not potential princesses.

	void passageInit_8()
	{
		this.Passages["The kitchen is for servants, not potential princesses."] = new TwinePassage("The kitchen is for servants, not potential princesses.", new string[]{  }, passageExecute_8);
	}

	IEnumerable<TwineOutput> passageExecute_8()
	{
		yield return new TwineText(@"#john_approval, -5#");
		yield return new TwineText(@"%1, <john>, <center>, <neutral>%");
		yield return new TwineText(@"JANE: I guess that doesn't make me much of a potential princess then, does it?");
		yield return new TwineText(@"");
		yield return new TwineText(@"JANE: Well, I won't keep you from your other ladies-in-waiting any longer. It was nice to meet you.");	
	}
    
	// .............
	// #9: I'm sure the kitchen at your house was much cozier, though.

	void passageInit_9()
	{
		this.Passages["I'm sure the kitchen at your house was much cozier, though."] = new TwinePassage("I'm sure the kitchen at your house was much cozier, though.", new string[]{  }, passageExecute_9);
	}

	IEnumerable<TwineOutput> passageExecute_9()
	{
		yield return new TwineText(@"$JohnSmile$");
		yield return new TwineText(@"#john_approval, +5#");
		yield return new TwineText(@"%1, <john>, <center>, <blush>%");
		yield return new TwineText(@"JANE: It was. We didn't have much but what we did was good. It was home. ");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <john>, <center>, <smile>%");
		yield return new TwineText(@"JANE: Well, I won't keep you from your other ladies-in-waiting any longer. It was nice to meet you.");	
	}

}