/*
Generated by UnityTwine on 04/28/2016 02:07:04
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class patrice_intro: TwineStory
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
		yield return new TwineText(@"%1, <pat>, <center>, <neutral>%");
		yield return new TwineText(@"PATRICE: Good morning, your highness! I'm Patrice. But you can just call me Pat--everyone does.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: You can call me...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Adam.", @"Adam.", @"Adam.", null, null);
		yield return new TwineLink(@"Prince Adam.", @"Prince Adam.", @"Prince Adam.", null, null);
		yield return new TwineLink(@"The Beast.", @"The Beast.", @"The Beast.", null, null);	
	}
    
	// .............
	// #1: Prince Adam.

	void passageInit_1()
	{
		this.Passages["Prince Adam."] = new TwinePassage("Prince Adam.", new string[]{  }, passageExecute_1);
	}

	IEnumerable<TwineOutput> passageExecute_1()
	{
		yield return new TwineText(@"%1, <pat>, <center>, <scared>%");
		yield return new TwineText(@"PATRICE: Oh, of course! I would never presume to call you otherwise.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <pat>, <center>, <smile>%");
		yield return new TwineText(@"PATRICE: Thank you for sending me that invitation. Things like this don't often happen to me.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Well, starting today, I hope to change that.", @"Well, starting today, I hope to change that.", @"Well, starting today, I hope to change that.", null, null);
		yield return new TwineLink(@"Really? I find that surprising.", @"Really? I find that surprising.", @"Really? I find that surprising.", null, null);
		yield return new TwineLink(@"The lives of commoners are rarely interesting.", @"The lives of commoners are rarely interesting.", @"The lives of commoners are rarely interesting.", null, null);	
	}
    
	// .............
	// #2: Adam.

	void passageInit_2()
	{
		this.Passages["Adam."] = new TwinePassage("Adam.", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"#pat_approval, +5#");
		yield return new TwineText(@"%1, <pat>, <center>, <smile>%");
		yield return new TwineText(@"PATRICE: Adam. What a lovely name.");
		yield return new TwineText(@"");
		yield return new TwineText(@"PATRICE: Thank you for sending me that invitation. Things like this don't often happen to me.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Well, starting today, I hope to change that.", @"Well, starting today, I hope to change that.", @"Well, starting today, I hope to change that.", null, null);
		yield return new TwineLink(@"Really? I find that surprising.", @"Really? I find that surprising.", @"Really? I find that surprising.", null, null);
		yield return new TwineLink(@"The lives of commoners are rarely interesting.", @"The lives of commoners are rarely interesting.", @"The lives of commoners are rarely interesting.", null, null);	
	}
    
	// .............
	// #3: The Beast.

	void passageInit_3()
	{
		this.Passages["The Beast."] = new TwinePassage("The Beast.", new string[]{  }, passageExecute_3);
	}

	IEnumerable<TwineOutput> passageExecute_3()
	{
		yield return new TwineText(@"$PatScared$");
		yield return new TwineText(@"#pat_approval, -5#");
		yield return new TwineText(@"%1, <pat>, <center>, <scared>%");
		yield return new TwineText(@"PATRICE: ....Oh.");
		yield return new TwineText(@"");
		yield return new TwineText(@"PATRICE: Um. Of course, your highness. Er, Beast. Your...beastliness?");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <pat>, <center>, <neutral>%");
		yield return new TwineText(@"PATRICE: Thank you for sending me that invitation. Things like this don't often happen to me.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Well, starting today, I hope to change that.", @"Well, starting today, I hope to change that.", @"Well, starting today, I hope to change that.", null, null);
		yield return new TwineLink(@"Really? I find that surprising.", @"Really? I find that surprising.", @"Really? I find that surprising.", null, null);
		yield return new TwineLink(@"The lives of commoners are rarely interesting.", @"The lives of commoners are rarely interesting.", @"The lives of commoners are rarely interesting.", null, null);	
	}
    
	// .............
	// #4: Well, starting today, I hope to change that.

	void passageInit_4()
	{
		this.Passages["Well, starting today, I hope to change that."] = new TwinePassage("Well, starting today, I hope to change that.", new string[]{  }, passageExecute_4);
	}

	IEnumerable<TwineOutput> passageExecute_4()
	{
		yield return new TwineText(@"$PatBlush$");
		yield return new TwineText(@"#pat_approval, +10#");
		yield return new TwineText(@"%1, <pat>, <center>, <blush>%");
		yield return new TwineText(@"PATRICE: Th-thank you, your highness. You'll never know how much your kindness means to me.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <pat>, <center>, <neutral>%");
		yield return new TwineText(@"PATRICE: I hope it's not too much trouble, but I was wondering if you had any paper and ink I could use? There are some letters I'd like to write to people back home.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Of course. You'll find a writing desk in the sitting parlor.", @"Of course. You'll find a writing desk in the sitting parlor.", @"Of course. You'll find a writing desk in the sitting parlor.", null, null);
		yield return new TwineLink(@"You're welcome to occupy yourself however you like.", @"You're welcome to occupy yourself however you like.", @"You're welcome to occupy yourself however you like.", null, null);
		yield return new TwineLink(@"I'd prefer you didn't have any contact with the outside world.", @"I'd prefer you didn't have any contact with the outside world.", @"I'd prefer you didn't have any contact with the outside world.", null, null);	
	}
    
	// .............
	// #5: Really? I find that surprising.

	void passageInit_5()
	{
		this.Passages["Really? I find that surprising."] = new TwinePassage("Really? I find that surprising.", new string[]{  }, passageExecute_5);
	}

	IEnumerable<TwineOutput> passageExecute_5()
	{
		yield return new TwineText(@"#pat_approval, +5#");
		yield return new TwineText(@"%1, <pat>, <center>, <blush>%");
		yield return new TwineText(@"PATRICE: That's very kind of you to say, sire, but I'm afraid my life compared to yours must seem very dull.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <pat>, <center>, <neutral>%");
		yield return new TwineText(@"PATRICE: I hope it's not too much trouble, but I was wondering if you had any paper and ink I could use? There are some letters I'd like to write to people back home.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Of course. You'll find a writing desk in the sitting parlor.", @"Of course. You'll find a writing desk in the sitting parlor.", @"Of course. You'll find a writing desk in the sitting parlor.", null, null);
		yield return new TwineLink(@"You're welcome to occupy yourself however you like.", @"You're welcome to occupy yourself however you like.", @"You're welcome to occupy yourself however you like.", null, null);
		yield return new TwineLink(@"I'd prefer you didn't have any contact with the outside world.", @"I'd prefer you didn't have any contact with the outside world.", @"I'd prefer you didn't have any contact with the outside world.", null, null);	
	}
    
	// .............
	// #6: The lives of commoners are rarely interesting.

	void passageInit_6()
	{
		this.Passages["The lives of commoners are rarely interesting."] = new TwinePassage("The lives of commoners are rarely interesting.", new string[]{  }, passageExecute_6);
	}

	IEnumerable<TwineOutput> passageExecute_6()
	{
		yield return new TwineText(@"$PatAngry$");
		yield return new TwineText(@"#pat_approval, -5#");
		yield return new TwineText(@"%1, <pat>, <center>, <frown>%");
		yield return new TwineText(@"PATRICE: ...Of course, your majesty. I'm sure we must seem very dull in comparison.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <pat>, <center>, <neutral>%");
		yield return new TwineText(@"PATRICE: I hope it's not too much trouble, but I was wondering if you had any paper and ink I could use? There are some letters I'd like to write to people back home.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Of course. You'll find a writing desk in the sitting parlor.", @"Of course. You'll find a writing desk in the sitting parlor.", @"Of course. You'll find a writing desk in the sitting parlor.", null, null);
		yield return new TwineLink(@"You're welcome to occupy yourself however you like.", @"You're welcome to occupy yourself however you like.", @"You're welcome to occupy yourself however you like.", null, null);
		yield return new TwineLink(@"I'd prefer you didn't have any contact with the outside world.", @"I'd prefer you didn't have any contact with the outside world.", @"I'd prefer you didn't have any contact with the outside world.", null, null);	
	}
    
	// .............
	// #7: Of course. You'll find a writing desk in the sitting parlor.

	void passageInit_7()
	{
		this.Passages["Of course. You'll find a writing desk in the sitting parlor."] = new TwinePassage("Of course. You'll find a writing desk in the sitting parlor.", new string[]{  }, passageExecute_7);
	}

	IEnumerable<TwineOutput> passageExecute_7()
	{
		yield return new TwineText(@"#pat_approval, +5#");
		yield return new TwineText(@"%1, <pat>, <center>, <smile>%");
		yield return new TwineText(@"PATRICE: Thank you, sire. I really do appreciate it. I promise I'll leave everything just as I found it.");
		yield return new TwineText(@"");
		yield return new TwineText(@"PATRICE: This castle is so beautiful. I've never seen anything like it!");
		yield return new TwineText(@"");
		yield return new TwineText(@"PATRICE: I really am glad to be here, sire. Thank you. I won't keep you any longer.");	
	}
    
	// .............
	// #8: You're welcome to occupy yourself however you like.

	void passageInit_8()
	{
		this.Passages["You're welcome to occupy yourself however you like."] = new TwinePassage("You're welcome to occupy yourself however you like.", new string[]{  }, passageExecute_8);
	}

	IEnumerable<TwineOutput> passageExecute_8()
	{
		yield return new TwineText(@"%1, <pat>, <center>, <neutral>%");
		yield return new TwineText(@"PATRICE: ...Oh. Well, to each their own, I suppose.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <pat>, <center>, <smile>%");
		yield return new TwineText(@"PATRICE: Personally, I can't imagine living in such a grand castle. It's all a bit much to take in!");
		yield return new TwineText(@"");
		yield return new TwineText(@"PATRICE: I really am glad to be here, sire. Thank you. I won't keep you any longer.");	
	}
    
	// .............
	// #9: I'd prefer you didn't have any contact with the outside world.

	void passageInit_9()
	{
		this.Passages["I'd prefer you didn't have any contact with the outside world."] = new TwinePassage("I'd prefer you didn't have any contact with the outside world.", new string[]{  }, passageExecute_9);
	}

	IEnumerable<TwineOutput> passageExecute_9()
	{
		yield return new TwineText(@"#pat_approval, -5#");
		yield return new TwineText(@"%1, <pat>, <center>, <frown>%");
		yield return new TwineText(@"PATRICE: That's...");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <pat>, <center>, <smile>%");
		yield return new TwineText(@"PATRICE: I mean, of course. Right. I won't bring it up again.");
		yield return new TwineText(@"");
		yield return new TwineText(@"PATRICE: I really am glad to be here, sire. Thank you. I won't keep you any longer.");	
	}

}