/*
Generated by UnityTwine on 4/27/2016 6:31:00 PM
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class noelle_intro: TwineStory
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
		yield return new TwineText(@"%1, <noelle>, <center>, <smile>%");
		yield return new TwineText(@"NOELLE: Good morning, sire. My name is Noelle.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Good morning. You can refer to me as...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Adam.", @"Adam.", @"n1", null, null);
		yield return new TwineLink(@"Prince Adam.", @"Prince Adam.", @"n2", null, null);
		yield return new TwineLink(@"The Beast.", @"The Beast.", @"n3", null, null);	
	}
    
	// .............
	// #1: n2

	void passageInit_1()
	{
		this.Passages["n2"] = new TwinePassage("n2", new string[]{  }, passageExecute_1);
	}

	IEnumerable<TwineOutput> passageExecute_1()
	{
		yield return new TwineText(@"NOELLE: What a lovely name. It's a pleasure to meet you, sire.");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: Thank you for inviting me to the castle. This is all so exciting!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"I hope you enjoy yourself.", @"I hope you enjoy yourself.", @"I hope you enjoy yourself.", null, null);
		yield return new TwineLink(@"It wasn't my decision.", @"It wasn't my decision.", @"It wasn't my decision.", null, null);
		yield return new TwineLink(@"I'm sorry to put you in this position.", @"I'm sorry to put you in this position.", @"I'm sorry to put you in this position.", null, null);	
	}
    
	// .............
	// #2: n1

	void passageInit_2()
	{
		this.Passages["n1"] = new TwinePassage("n1", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"NOELLE: Adam. Lovely.");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: Thank you for inviting me to the castle. This is all so exciting!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"I hope you enjoy yourself.", @"I hope you enjoy yourself.", @"I hope you enjoy yourself.", null, null);
		yield return new TwineLink(@"It wasn't my decision.", @"It wasn't my decision.", @"It wasn't my decision.", null, null);
		yield return new TwineLink(@"I'm sorry to put you in this position.", @"I'm sorry to put you in this position.", @"I'm sorry to put you in this position.", null, null);	
	}
    
	// .............
	// #3: n3

	void passageInit_3()
	{
		this.Passages["n3"] = new TwinePassage("n3", new string[]{  }, passageExecute_3);
	}

	IEnumerable<TwineOutput> passageExecute_3()
	{
		yield return new TwineText(@"$NoelleScared$");
		yield return new TwineText(@"#noelle_approval, -5#");
		yield return new TwineText(@"%1, <noelle>, <center>, <scared>%");
		yield return new TwineText(@"NOELLE: O-oh. Alright. Um, yes. Yes, of course.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <noelle>, <center>, <smile>%");
		yield return new TwineText(@"NOELLE: Thank you for inviting me to the castle. This is all so exciting!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"I hope you enjoy yourself.", @"I hope you enjoy yourself.", @"I hope you enjoy yourself.", null, null);
		yield return new TwineLink(@"It wasn't my decision.", @"It wasn't my decision.", @"It wasn't my decision.", null, null);
		yield return new TwineLink(@"I'm sorry to put you in this position.", @"I'm sorry to put you in this position.", @"I'm sorry to put you in this position.", null, null);	
	}
    
	// .............
	// #4: I hope you enjoy yourself.

	void passageInit_4()
	{
		this.Passages["I hope you enjoy yourself."] = new TwinePassage("I hope you enjoy yourself.", new string[]{  }, passageExecute_4);
	}

	IEnumerable<TwineOutput> passageExecute_4()
	{
		yield return new TwineText(@"$NoelleSmile$");
		yield return new TwineText(@"#noelle_approval, +5#");
		yield return new TwineText(@"NOELLE: I'm sure I will, sire. Thank you.");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: I hope you find one of us a pleasing option. I'm sure you must have had plenty of suitors in the past.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Certainly none as beautiful as you.", @"Certainly none as beautiful as you.", @"Certainly none as beautiful as you.", null, null);
		yield return new TwineLink(@"None, actually. I wish I'd been so lucky.", @"None, actually. I wish I'd been so lucky.", @"None, actually. I wish I'd been so lucky.", null, null);
		yield return new TwineLink(@"I don't exactly attract people. Quite the opposite, usually.", @"I don't exactly attract people. Quite the opposite, usually.", @"I don't exactly attract people. Quite the opposite, usually.", null, null);	
	}
    
	// .............
	// #5: It wasn't my decision.

	void passageInit_5()
	{
		this.Passages["It wasn't my decision."] = new TwinePassage("It wasn't my decision.", new string[]{  }, passageExecute_5);
	}

	IEnumerable<TwineOutput> passageExecute_5()
	{
		yield return new TwineText(@"#noelle_approval, -5#");
		yield return new TwineText(@"NOELLE: ...Well. I'm sorry you feel inconvenienced by our presence, then.");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: I'm sure it gets exhausting having to constantly host suitors. Being a prince must be hard work, with so many people vying for your hand.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Certainly none as beautiful as you.", @"Certainly none as beautiful as you.", @"Certainly none as beautiful as you.", null, null);
		yield return new TwineLink(@"None, actually. I wish I'd been so lucky.", @"None, actually. I wish I'd been so lucky.", @"None, actually. I wish I'd been so lucky.", null, null);
		yield return new TwineLink(@"I don't exactly attract people. Quite the opposite, usually.", @"I don't exactly attract people. Quite the opposite, usually.", @"I don't exactly attract people. Quite the opposite, usually.", null, null);	
	}
    
	// .............
	// #6: I'm sorry to put you in this position.

	void passageInit_6()
	{
		this.Passages["I'm sorry to put you in this position."] = new TwinePassage("I'm sorry to put you in this position.", new string[]{  }, passageExecute_6);
	}

	IEnumerable<TwineOutput> passageExecute_6()
	{
		yield return new TwineText(@"$NoelleScared$");
		yield return new TwineText(@"#noelle_approval, +5#");
		yield return new TwineText(@"%1, <noelle>, <center>, <scared>%");
		yield return new TwineText(@"NOELLE: .....");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: I don't--");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <noelle>, <center>, <smile>%");
		yield return new TwineText(@"NOELLE: I'm sure I don't know what you're talking about, your highness. Why wouldn't I be happy to be meeting the man who might one day be my husband?");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: But then, I'm sure you must have had plenty of suitors in the past.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Certainly none as beautiful as you.", @"Certainly none as beautiful as you.", @"Certainly none as beautiful as you.", null, null);
		yield return new TwineLink(@"None, actually. I wish I'd been so lucky.", @"None, actually. I wish I'd been so lucky.", @"None, actually. I wish I'd been so lucky.", null, null);
		yield return new TwineLink(@"I don't exactly attract people. Quite the opposite, usually.", @"I don't exactly attract people. Quite the opposite, usually.", @"I don't exactly attract people. Quite the opposite, usually.", null, null);	
	}
    
	// .............
	// #7: Certainly none as beautiful as you.

	void passageInit_7()
	{
		this.Passages["Certainly none as beautiful as you."] = new TwinePassage("Certainly none as beautiful as you.", new string[]{  }, passageExecute_7);
	}

	IEnumerable<TwineOutput> passageExecute_7()
	{
		yield return new TwineText(@"NOELLE: Oh, sire. You're too kind. I'm just a simple village girl. I'm sure I look ridiculous against the backdrop of all this finery.");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: Now, if you'll excuse me, I'm feeling a bit tired and would like to sit down. It's been a pleasure talking to you, sire.");	
	}
    
	// .............
	// #8: None, actually. I wish I'd been so lucky.

	void passageInit_8()
	{
		this.Passages["None, actually. I wish I'd been so lucky."] = new TwinePassage("None, actually. I wish I'd been so lucky.", new string[]{  }, passageExecute_8);
	}

	IEnumerable<TwineOutput> passageExecute_8()
	{
		yield return new TwineText(@"$NoelleSmile$");
		yield return new TwineText(@"NOELLE: I must say I find that surprising, given the splendor of this castle. But I suppose not everyone has such good taste.");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: Now, if you'll excuse me, I'm feeling a bit tired and would like to sit down. It's been a pleasure talking to you, sire.");	
	}
    
	// .............
	// #9: I don't exactly attract people. Quite the opposite, usually.

	void passageInit_9()
	{
		this.Passages["I don't exactly attract people. Quite the opposite, usually."] = new TwinePassage("I don't exactly attract people. Quite the opposite, usually.", new string[]{  }, passageExecute_9);
	}

	IEnumerable<TwineOutput> passageExecute_9()
	{
		yield return new TwineText(@"#noelle_approval, -5#");
		yield return new TwineText(@"%1, <noelle>, <center>, <scared>%");
		yield return new TwineText(@"NOELLE: ...Oh.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <noelle>, <center>, <smile>%");
		yield return new TwineText(@"NOELLE: Well, I'm sorry to hear that. I must admit, I'm surprised no one has courted you before for the castle alone. It's truly magnificent.");
		yield return new TwineText(@"");
		yield return new TwineText(@"NOELLE: Now, if you'll excuse me, I'm feeling a bit tired and would like to sit down.");	
	}

}