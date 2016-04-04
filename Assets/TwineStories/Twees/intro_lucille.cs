/*
Generated by UnityTwine on 4/3/2016 9:22:32 PM
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class intro_lucille: TwineStory
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
	}
    
	// .............
	// #0: Start

	void passageInit_0()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{  }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"%<1>, <lucy>, <center>, <neutral>%");
		yield return new TwineText(@"LUCILLE: Good morning. I'm Lucille.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Good morning. You can refer to me as...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Adam.", @"Adam.", @"Adam.", null, null);
		yield return new TwineLink(@"Prince Adam.", @"Prince Adam.", @"Prince Adam.", null, null);
		yield return new TwineLink(@"The Beast.", @"The Beast.", @"The Beast.", null, null);	
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
	// #2: Prince Adam.

	void passageInit_2()
	{
		this.Passages["Prince Adam."] = new TwinePassage("Prince Adam.", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"%<1>, <lucy>, <center>, <thinking>%");
		yield return new TwineText(@"LUCILLE: Hmm. Alright.");
		yield return new TwineText(@"");
		yield return new TwineText(@"LUCILLE: I look forward to learning more about the castle.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Please, look around as much as you like.", @"Please, look around as much as you like.", @"Please, look around as much as you like.", null, null);
		yield return new TwineLink(@"Don't go poking your nose where it doesn't belong.", @"Don't go poking your nose where it doesn't belong.", @"Don't go poking your nose where it doesn't belong.", null, null);	
	}
    
	// .............
	// #3: Adam.

	void passageInit_3()
	{
		this.Passages["Adam."] = new TwinePassage("Adam.", new string[]{  }, passageExecute_3);
	}

	IEnumerable<TwineOutput> passageExecute_3()
	{
		yield return new TwineText(@"LUCILLE: Adam. Interesting.");
		yield return new TwineText(@"");
		yield return new TwineText(@"LUCILLE: I look forward to learning more about the castle.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Please, look around as much as you like.", @"Please, look around as much as you like.", @"Please, look around as much as you like.", null, null);
		yield return new TwineLink(@"Don't go poking your nose where it doesn't belong.", @"Don't go poking your nose where it doesn't belong.", @"Don't go poking your nose where it doesn't belong.", null, null);	
	}
    
	// .............
	// #4: The Beast.

	void passageInit_4()
	{
		this.Passages["The Beast."] = new TwinePassage("The Beast.", new string[]{  }, passageExecute_4);
	}

	IEnumerable<TwineOutput> passageExecute_4()
	{
		yield return new TwineText(@"%<1>, <lucy>, <center>, <thinking>%");
		yield return new TwineText(@"LUCILLE: 'The Beast', hmm? Very interesting.");
		yield return new TwineText(@"");
		yield return new TwineText(@"LUCILLE: I look forward to learning more about the castle.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Please, look around as much as you like.", @"Please, look around as much as you like.", @"Please, look around as much as you like.", null, null);
		yield return new TwineLink(@"Don't go poking your nose where it doesn't belong.", @"Don't go poking your nose where it doesn't belong.", @"Don't go poking your nose where it doesn't belong.", null, null);	
	}
    
	// .............
	// #5: StoryAuthor

	void passageInit_5()
	{
		this.Passages["StoryAuthor"] = new TwinePassage("StoryAuthor", new string[]{  }, passageExecute_5);
	}

	IEnumerable<TwineOutput> passageExecute_5()
	{
		yield return new TwineText(@"Anonymous");	
	}
    
	// .............
	// #6: Don't go poking your nose where it doesn't belong.

	void passageInit_6()
	{
		this.Passages["Don't go poking your nose where it doesn't belong."] = new TwinePassage("Don't go poking your nose where it doesn't belong.", new string[]{  }, passageExecute_6);
	}

	IEnumerable<TwineOutput> passageExecute_6()
	{
		yield return new TwineText(@"#<lucyapproval>, <-5>#");
		yield return new TwineText(@"%<1>, <lucy>, <center>, <frown>%");
		yield return new TwineText(@"");
		yield return new TwineText(@"LUCILLE: So I'm a prisoner rather than a guest. Fine, then. I'm sure I'll see you again later, unfortunately.");	
	}
    
	// .............
	// #7: Please, look around as much as you like.

	void passageInit_7()
	{
		this.Passages["Please, look around as much as you like."] = new TwinePassage("Please, look around as much as you like.", new string[]{  }, passageExecute_7);
	}

	IEnumerable<TwineOutput> passageExecute_7()
	{
		yield return new TwineText(@"#<lucyapproval>, <+5>#");
		yield return new TwineText(@"%<1>, <lucy>, <center>, <smile>%");
		yield return new TwineText(@"");
		yield return new TwineText(@"LUCILLE: I certainly will. Thank you.");	
	}

}