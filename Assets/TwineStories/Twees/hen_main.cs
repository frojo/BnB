/*
Generated by UnityTwine on 04/28/2016 17:25:13
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class hen_main: TwineStory
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
		passageInit_10();
		passageInit_11();
		passageInit_12();
		passageInit_13();
		passageInit_14();
		passageInit_15();
		passageInit_16();
	}
    
	// .............
	// #0: stay1

	void passageInit_0()
	{
		this.Passages["stay1"] = new TwinePassage("stay1", new string[]{  }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"HENRIETTA: MMMMMMMMMMOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: ...Right. ");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What's your opinion of the other women staying in the castle?", @"What's your opinion of the other women staying in the castle?", @"women", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk about you.", @"%convo_points, 1, 2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #1: Start

	void passageInit_1()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{  }, passageExecute_1);
	}

	IEnumerable<TwineOutput> passageExecute_1()
	{
		yield return new TwineText(@"%1, <hen>, <center>, <neutral>%");
		yield return new TwineText(@"HENRIETTA: MMMMMOOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Good to see you, too. Now, then...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"I'd like to hear your opinion of the other women staying in the castle.", @"I'd like to hear your opinion of the other women staying in the castle.", @"women", null, null);
		yield return new TwineLink(@"How are you enjoying your stay here?", @"How are you enjoying your stay here?", @"stay1", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk about you.", @"%convo_points, 1, 2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"%hen_gift, 3, 3%I have a gift for you.", @"%hen_gift, 3, 3%I have a gift for you.", @"gift", null, null);
		yield return new TwineLink(@"Actually, I have to go.", @"Actually, I have to go.", @"leave", null, null);	
	}
    
	// .............
	// #2: l1

	void passageInit_2()
	{
		this.Passages["l1"] = new TwinePassage("l1", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"HENRIETTA: MMOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Of course. I completely agree. Now, let's discuss something else.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What's your opinion of the other women staying in the castle?", @"What's your opinion of the other women staying in the castle?", @"women", null, null);
		yield return new TwineLink(@"How are you enjoying your stay here?", @"How are you enjoying your stay here?", @"stay1", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk about you.", @"%convo_points, 1, 2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #3: j1

	void passageInit_3()
	{
		this.Passages["j1"] = new TwinePassage("j1", new string[]{  }, passageExecute_3);
	}

	IEnumerable<TwineOutput> passageExecute_3()
	{
		yield return new TwineText(@"HENRIETTA: MMMMMMMMMOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Really? Hm. I suppose so. Now, let's discuss something else.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What's your opinion of the other women staying in the castle?", @"What's your opinion of the other women staying in the castle?", @"women", null, null);
		yield return new TwineLink(@"How are you enjoying your stay here?", @"How are you enjoying your stay here?", @"stay1", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk about you.", @"%convo_points, 1, 2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #4: fam

	void passageInit_4()
	{
		this.Passages["fam"] = new TwinePassage("fam", new string[]{  }, passageExecute_4);
	}

	IEnumerable<TwineOutput> passageExecute_4()
	{
		yield return new TwineText(@"#convo_points, -1#");
		yield return new TwineText(@"#hen_convo, +1#");
		yield return new TwineText(@"%1, <hen>, <center>, <neutral>%");
		yield return new TwineText(@"HENRIETTA: MMMOOOOO. MMMMMMMMMMOOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Well. Yes, I suppose I should've assumed they'd all be cows, too.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Let's discuss something else.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What's your opinion of the other women staying in the castle?", @"What's your opinion of the other women staying in the castle?", @"women", null, null);
		yield return new TwineLink(@"How are you enjoying your stay here?", @"How are you enjoying your stay here?", @"stay1", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk about you.", @"%convo_points, 1, 2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #5: light

	void passageInit_5()
	{
		this.Passages["light"] = new TwinePassage("light", new string[]{  }, passageExecute_5);
	}

	IEnumerable<TwineOutput> passageExecute_5()
	{
		yield return new TwineText(@"BEAST: I was thinking we could talk about...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"One of the other women in the castle.", @"One of the other women in the castle.", @"women", null, null);
		yield return new TwineLink(@"How you feel about the castle.", @"How you feel about the castle.", @"stay1", null, null);
		yield return new TwineLink(@"%convo_points, 1,2%Let's talk about you.", @"%convo_points, 1,2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"Actually, I have to go.", @"Actually, I have to go.", @"leave", null, null);	
	}
    
	// .............
	// #6: women

	void passageInit_6()
	{
		this.Passages["women"] = new TwinePassage("women", new string[]{  }, passageExecute_6);
	}

	IEnumerable<TwineOutput> passageExecute_6()
	{
		yield return new TwineText(@"HENRIETTA: MMOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Oh, good. Specifically, I'm interested in your thoughts on...");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Jane.", @"Jane.", @"j1", null, null);
		yield return new TwineLink(@"Pat.", @"Pat.", @"p1", null, null);
		yield return new TwineLink(@"Noelle.", @"Noelle.", @"n1", null, null);
		yield return new TwineLink(@"Lucille.", @"Lucille.", @"l1", null, null);
		yield return new TwineLink(@"Actually, I have to go.", @"Actually, I have to go.", @"leave", null, null);	
	}
    
	// .............
	// #7: p1

	void passageInit_7()
	{
		this.Passages["p1"] = new TwinePassage("p1", new string[]{  }, passageExecute_7);
	}

	IEnumerable<TwineOutput> passageExecute_7()
	{
		yield return new TwineText(@"HENRIETTA: MMMMMMMMMOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"HENRIETTA: ...Good to hear. Let's discuss something else.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What's your opinion of the other women staying in the castle?", @"What's your opinion of the other women staying in the castle?", @"women", null, null);
		yield return new TwineLink(@"How are you enjoying your stay here?", @"How are you enjoying your stay here?", @"stay1", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk about you.", @"%convo_points, 1, 2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #8: n1

	void passageInit_8()
	{
		this.Passages["n1"] = new TwinePassage("n1", new string[]{  }, passageExecute_8);
	}

	IEnumerable<TwineOutput> passageExecute_8()
	{
		yield return new TwineText(@"HENRIETTA: MMMMMOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Well. That's surprising. Now, let's discuss something else.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What's your opinion of the other women staying in the castle?", @"What's your opinion of the other women staying in the castle?", @"women", null, null);
		yield return new TwineLink(@"How are you enjoying your stay here?", @"How are you enjoying your stay here?", @"stay1", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk about you.", @"%convo_points, 1, 2%Let's talk about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #9: from

	void passageInit_9()
	{
		this.Passages["from"] = new TwinePassage("from", new string[]{  }, passageExecute_9);
	}

	IEnumerable<TwineOutput> passageExecute_9()
	{
		yield return new TwineText(@"#convo_points, -1#");
		yield return new TwineText(@"#hen_convo, +1#");
		yield return new TwineText(@"HENRIETTA: MMMMOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Huh. I...haven't heard of that particular province.");
		yield return new TwineText(@"");
		yield return new TwineText(@"HENRIETTA: MMMMMOOOOOOOOOOOO!");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: No, no, I'll take your word for it.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Let's talk about something lighter.", @"Let's talk about something lighter.", @"light", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk more about you.", @"%convo_points, 1, 2%Let's talk more about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #10: you

	void passageInit_10()
	{
		this.Passages["you"] = new TwinePassage("you", new string[]{  }, passageExecute_10);
	}

	IEnumerable<TwineOutput> passageExecute_10()
	{
		yield return new TwineText(@"HENRIETTA: MMMOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"%hen_convo, 0, 0%Where are you from?", @"%hen_convo, 0, 0%Where are you from?", @"from", null, null);
		yield return new TwineLink(@"%hen_convo, 1, 1%What's your family like?", @"%hen_convo, 1, 1%What's your family like?", @"fam", null, null);
		yield return new TwineLink(@"%hen_convo, 2, 2%Have you always been a cow?", @"%hen_convo, 2, 2%Have you always been a cow?", @"cow", null, null);
		yield return new TwineLink(@"%hen_convo, 3, 3%If you could be any other animal, what would you choose to be?", @"%hen_convo, 3, 3%If you could be any other animal, what would you choose to be?", @"animal", null, null);
		yield return new TwineLink(@"%hen_convo, 4, 4%What's your farm like?", @"%hen_convo, 4, 4%What's your farm like?", @"farm", null, null);
		yield return new TwineLink(@"%hen_convo, 5, 5%Have you ever been in love?", @"%hen_convo, 5, 5%Have you ever been in love?", @"love", null, null);
		yield return new TwineLink(@"Let's talk about something lighter.", @"Let's talk about something lighter.", @"light", null, null);	
	}
    
	// .............
	// #11: cow

	void passageInit_11()
	{
		this.Passages["cow"] = new TwinePassage("cow", new string[]{  }, passageExecute_11);
	}

	IEnumerable<TwineOutput> passageExecute_11()
	{
		yield return new TwineText(@"#convo_points, -1#");
		yield return new TwineText(@"#hen_convo, +1#");
		yield return new TwineText(@"HENRIETTA: MMMMOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Of course. I don't know why I expected anything different.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Let's talk about something lighter.", @"Let's talk about something lighter.", @"light", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk more about you.", @"%convo_points, 1, 2%Let's talk more about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #12: gift

	void passageInit_12()
	{
		this.Passages["gift"] = new TwinePassage("gift", new string[]{  }, passageExecute_12);
	}

	IEnumerable<TwineOutput> passageExecute_12()
	{
		yield return new TwineText(@"#convo_points, -1#");
		yield return new TwineText(@"#hen_gift, +1#");
		yield return new TwineText(@"#hen_approval, +60#");
		yield return new TwineText(@"BEAST: Here. I thought you might like a taste of home.");
		yield return new TwineText(@"");
		yield return new TwineText(@"HENRIETTA: ...!! ");
		yield return new TwineText(@"");
		yield return new TwineText(@"HENRIETTA: MOOOOOOOOOOOOO!");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: It was no trouble at all. A beautiful girl like you deserves gifts like this.");
		yield return new TwineText(@"");
		yield return new TwineText(@"%1, <hen>, <center>, <blush>%");
		yield return new TwineText(@"HENRIETTA: MMMmmoOOOOOOOOoooo....");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: You're very welcome.");	
	}
    
	// .............
	// #13: animal

	void passageInit_13()
	{
		this.Passages["animal"] = new TwinePassage("animal", new string[]{  }, passageExecute_13);
	}

	IEnumerable<TwineOutput> passageExecute_13()
	{
		yield return new TwineText(@"#convo_points, -1#");
		yield return new TwineText(@"#hen_convo, +1#");
		yield return new TwineText(@"HENRIETTA: MMMMOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: No, no, I'm sorry! I didn't mean to be insensitive.");
		yield return new TwineText(@"");
		yield return new TwineText(@"HENRIETTA: MMMOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Let's talk about something lighter.", @"Let's talk about something lighter.", @"light", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk more about you.", @"%convo_points, 1, 2%Let's talk more about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #14: farm

	void passageInit_14()
	{
		this.Passages["farm"] = new TwinePassage("farm", new string[]{  }, passageExecute_14);
	}

	IEnumerable<TwineOutput> passageExecute_14()
	{
		yield return new TwineText(@"#convo_points, -1#");
		yield return new TwineText(@"#hen_convo, +1#");
		yield return new TwineText(@"HENRIETTA: MMMMOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: That sounds...lovely.");
		yield return new TwineText(@"");
		yield return new TwineText(@"HENRIETTA: MMMMMOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: No, I'm not just saying that.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Let's talk about something lighter.", @"Let's talk about something lighter.", @"light", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk more about you.", @"%convo_points, 1, 2%Let's talk more about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #15: love

	void passageInit_15()
	{
		this.Passages["love"] = new TwinePassage("love", new string[]{  }, passageExecute_15);
	}

	IEnumerable<TwineOutput> passageExecute_15()
	{
		yield return new TwineText(@"#convo_points, -1#");
		yield return new TwineText(@"#hen_convo, +1#");
		yield return new TwineText(@"HENRIETTA: MMMMOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Oh, my. That sounds awful. I'm so sorry.");
		yield return new TwineText(@"");
		yield return new TwineText(@"HENRIETTA: MMMMMOOOOOOOOOOOO.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: You're right. It's better to have loved and lost than never loved at all.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Let's talk about something lighter.", @"Let's talk about something lighter.", @"light", null, null);
		yield return new TwineLink(@"%convo_points, 1, 2%Let's talk more about you.", @"%convo_points, 1, 2%Let's talk more about you.", @"you", null, null);
		yield return new TwineLink(@"I have to go now.", @"I have to go now.", @"leave", null, null);	
	}
    
	// .............
	// #16: leave

	void passageInit_16()
	{
		this.Passages["leave"] = new TwinePassage("leave", new string[]{  }, passageExecute_16);
	}

	IEnumerable<TwineOutput> passageExecute_16()
	{
		yield return new TwineText(@"HENRIETTA: MMooOOOOoo.");
		yield return new TwineText(@"");
		yield return new TwineText(@"BEAST: Yes, of course I'll see you again soon.");	
	}

}