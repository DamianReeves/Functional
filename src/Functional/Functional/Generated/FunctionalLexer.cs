//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 Parser\\Functional.g3 2013-02-09 00:24:57

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace Functional.Parser
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class FunctionalLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int CALL=4;
	public const int FUNC=5;
	public const int ID=6;
	public const int INT=7;
	public const int NEWLINE=8;
	public const int WS=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;
	public const int T__15=15;
	public const int T__16=16;
	public const int T__17=17;

    // delegates
    // delegators

	public FunctionalLexer()
	{
		OnCreated();
	}

	public FunctionalLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public FunctionalLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "Parser\\Functional.g3"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__10();
	partial void LeaveRule_T__10();

	// $ANTLR start "T__10"
	[GrammarRule("T__10")]
	private void mT__10()
	{
		EnterRule_T__10();
		EnterRule("T__10", 1);
		TraceIn("T__10", 1);
		try
		{
			int _type = T__10;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:10:7: ( '%' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:10:9: '%'
			{
			DebugLocation(10, 9);
			Match('%'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__10", 1);
			LeaveRule("T__10", 1);
			LeaveRule_T__10();
		}
	}
	// $ANTLR end "T__10"

	partial void EnterRule_T__11();
	partial void LeaveRule_T__11();

	// $ANTLR start "T__11"
	[GrammarRule("T__11")]
	private void mT__11()
	{
		EnterRule_T__11();
		EnterRule("T__11", 2);
		TraceIn("T__11", 2);
		try
		{
			int _type = T__11;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:11:7: ( '(' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:11:9: '('
			{
			DebugLocation(11, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__11", 2);
			LeaveRule("T__11", 2);
			LeaveRule_T__11();
		}
	}
	// $ANTLR end "T__11"

	partial void EnterRule_T__12();
	partial void LeaveRule_T__12();

	// $ANTLR start "T__12"
	[GrammarRule("T__12")]
	private void mT__12()
	{
		EnterRule_T__12();
		EnterRule("T__12", 3);
		TraceIn("T__12", 3);
		try
		{
			int _type = T__12;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:12:7: ( ')' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:12:9: ')'
			{
			DebugLocation(12, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__12", 3);
			LeaveRule("T__12", 3);
			LeaveRule_T__12();
		}
	}
	// $ANTLR end "T__12"

	partial void EnterRule_T__13();
	partial void LeaveRule_T__13();

	// $ANTLR start "T__13"
	[GrammarRule("T__13")]
	private void mT__13()
	{
		EnterRule_T__13();
		EnterRule("T__13", 4);
		TraceIn("T__13", 4);
		try
		{
			int _type = T__13;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:13:7: ( '*' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:13:9: '*'
			{
			DebugLocation(13, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__13", 4);
			LeaveRule("T__13", 4);
			LeaveRule_T__13();
		}
	}
	// $ANTLR end "T__13"

	partial void EnterRule_T__14();
	partial void LeaveRule_T__14();

	// $ANTLR start "T__14"
	[GrammarRule("T__14")]
	private void mT__14()
	{
		EnterRule_T__14();
		EnterRule("T__14", 5);
		TraceIn("T__14", 5);
		try
		{
			int _type = T__14;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:14:7: ( '+' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:14:9: '+'
			{
			DebugLocation(14, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__14", 5);
			LeaveRule("T__14", 5);
			LeaveRule_T__14();
		}
	}
	// $ANTLR end "T__14"

	partial void EnterRule_T__15();
	partial void LeaveRule_T__15();

	// $ANTLR start "T__15"
	[GrammarRule("T__15")]
	private void mT__15()
	{
		EnterRule_T__15();
		EnterRule("T__15", 6);
		TraceIn("T__15", 6);
		try
		{
			int _type = T__15;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:15:7: ( '-' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:15:9: '-'
			{
			DebugLocation(15, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__15", 6);
			LeaveRule("T__15", 6);
			LeaveRule_T__15();
		}
	}
	// $ANTLR end "T__15"

	partial void EnterRule_T__16();
	partial void LeaveRule_T__16();

	// $ANTLR start "T__16"
	[GrammarRule("T__16")]
	private void mT__16()
	{
		EnterRule_T__16();
		EnterRule("T__16", 7);
		TraceIn("T__16", 7);
		try
		{
			int _type = T__16;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:16:7: ( '/' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:16:9: '/'
			{
			DebugLocation(16, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__16", 7);
			LeaveRule("T__16", 7);
			LeaveRule_T__16();
		}
	}
	// $ANTLR end "T__16"

	partial void EnterRule_T__17();
	partial void LeaveRule_T__17();

	// $ANTLR start "T__17"
	[GrammarRule("T__17")]
	private void mT__17()
	{
		EnterRule_T__17();
		EnterRule("T__17", 8);
		TraceIn("T__17", 8);
		try
		{
			int _type = T__17;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:17:7: ( '=' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:17:9: '='
			{
			DebugLocation(17, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__17", 8);
			LeaveRule("T__17", 8);
			LeaveRule_T__17();
		}
	}
	// $ANTLR end "T__17"

	partial void EnterRule_ID();
	partial void LeaveRule_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		EnterRule_ID();
		EnterRule("ID", 9);
		TraceIn("ID", 9);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:60:5: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:60:9: ( 'a' .. 'z' | 'A' .. 'Z' )+
			{
			DebugLocation(60, 9);
			// Parser\\Functional.g3:60:9: ( 'a' .. 'z' | 'A' .. 'Z' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if (((LA1_1>='A' && LA1_1<='Z')||(LA1_1>='a' && LA1_1<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// Parser\\Functional.g3:
					{
					DebugLocation(60, 9);
					input.Consume();


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 9);
			LeaveRule("ID", 9);
			LeaveRule_ID();
		}
	}
	// $ANTLR end "ID"

	partial void EnterRule_INT();
	partial void LeaveRule_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		EnterRule_INT();
		EnterRule("INT", 10);
		TraceIn("INT", 10);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:63:5: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:63:9: ( '0' .. '9' )+
			{
			DebugLocation(63, 9);
			// Parser\\Functional.g3:63:9: ( '0' .. '9' )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_1 = input.LA(1);

				if (((LA2_1>='0' && LA2_1<='9')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// Parser\\Functional.g3:
					{
					DebugLocation(63, 9);
					input.Consume();


					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 10);
			LeaveRule("INT", 10);
			LeaveRule_INT();
		}
	}
	// $ANTLR end "INT"

	partial void EnterRule_NEWLINE();
	partial void LeaveRule_NEWLINE();

	// $ANTLR start "NEWLINE"
	[GrammarRule("NEWLINE")]
	private void mNEWLINE()
	{
		EnterRule_NEWLINE();
		EnterRule("NEWLINE", 11);
		TraceIn("NEWLINE", 11);
		try
		{
			int _type = NEWLINE;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:67:5: ( ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:67:7: ( '\\r' )? '\\n'
			{
			DebugLocation(67, 7);
			// Parser\\Functional.g3:67:7: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, false);
			int LA3_1 = input.LA(1);

			if ((LA3_1=='\r'))
			{
				alt3 = 1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// Parser\\Functional.g3:67:7: '\\r'
				{
				DebugLocation(67, 7);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(67, 13);
			Match('\n'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWLINE", 11);
			LeaveRule("NEWLINE", 11);
			LeaveRule_NEWLINE();
		}
	}
	// $ANTLR end "NEWLINE"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 12);
		TraceIn("WS", 12);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// Parser\\Functional.g3:70:5: ( ( ' ' | '\\t' )+ )
			DebugEnterAlt(1);
			// Parser\\Functional.g3:70:9: ( ' ' | '\\t' )+
			{
			DebugLocation(70, 9);
			// Parser\\Functional.g3:70:9: ( ' ' | '\\t' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1=='\t'||LA4_1==' '))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// Parser\\Functional.g3:
					{
					DebugLocation(70, 9);
					input.Consume();


					}
					break;

				default:
					if (cnt4 >= 1)
						goto loop4;

					EarlyExitException eee4 = new EarlyExitException( 4, input );
					DebugRecognitionException(eee4);
					throw eee4;
				}
				cnt4++;
			}
			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(70, 21);
			 Skip(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 12);
			LeaveRule("WS", 12);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	public override void mTokens()
	{
		// Parser\\Functional.g3:1:8: ( T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | ID | INT | NEWLINE | WS )
		int alt5=12;
		try { DebugEnterDecision(5, false);
		switch (input.LA(1))
		{
		case '%':
			{
			alt5 = 1;
			}
			break;
		case '(':
			{
			alt5 = 2;
			}
			break;
		case ')':
			{
			alt5 = 3;
			}
			break;
		case '*':
			{
			alt5 = 4;
			}
			break;
		case '+':
			{
			alt5 = 5;
			}
			break;
		case '-':
			{
			alt5 = 6;
			}
			break;
		case '/':
			{
			alt5 = 7;
			}
			break;
		case '=':
			{
			alt5 = 8;
			}
			break;
		case 'A':
		case 'B':
		case 'C':
		case 'D':
		case 'E':
		case 'F':
		case 'G':
		case 'H':
		case 'I':
		case 'J':
		case 'K':
		case 'L':
		case 'M':
		case 'N':
		case 'O':
		case 'P':
		case 'Q':
		case 'R':
		case 'S':
		case 'T':
		case 'U':
		case 'V':
		case 'W':
		case 'X':
		case 'Y':
		case 'Z':
		case 'a':
		case 'b':
		case 'c':
		case 'd':
		case 'e':
		case 'f':
		case 'g':
		case 'h':
		case 'i':
		case 'j':
		case 'k':
		case 'l':
		case 'm':
		case 'n':
		case 'o':
		case 'p':
		case 'q':
		case 'r':
		case 's':
		case 't':
		case 'u':
		case 'v':
		case 'w':
		case 'x':
		case 'y':
		case 'z':
			{
			alt5 = 9;
			}
			break;
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
			{
			alt5 = 10;
			}
			break;
		case '\n':
		case '\r':
			{
			alt5 = 11;
			}
			break;
		case '\t':
		case ' ':
			{
			alt5 = 12;
			}
			break;
		default:
			{
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
		}

		} finally { DebugExitDecision(5); }
		switch (alt5)
		{
		case 1:
			DebugEnterAlt(1);
			// Parser\\Functional.g3:1:10: T__10
			{
			DebugLocation(1, 10);
			mT__10(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Parser\\Functional.g3:1:16: T__11
			{
			DebugLocation(1, 16);
			mT__11(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Parser\\Functional.g3:1:22: T__12
			{
			DebugLocation(1, 22);
			mT__12(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Parser\\Functional.g3:1:28: T__13
			{
			DebugLocation(1, 28);
			mT__13(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Parser\\Functional.g3:1:34: T__14
			{
			DebugLocation(1, 34);
			mT__14(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Parser\\Functional.g3:1:40: T__15
			{
			DebugLocation(1, 40);
			mT__15(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Parser\\Functional.g3:1:46: T__16
			{
			DebugLocation(1, 46);
			mT__16(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Parser\\Functional.g3:1:52: T__17
			{
			DebugLocation(1, 52);
			mT__17(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// Parser\\Functional.g3:1:58: ID
			{
			DebugLocation(1, 58);
			mID(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// Parser\\Functional.g3:1:61: INT
			{
			DebugLocation(1, 61);
			mINT(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// Parser\\Functional.g3:1:65: NEWLINE
			{
			DebugLocation(1, 65);
			mNEWLINE(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// Parser\\Functional.g3:1:73: WS
			{
			DebugLocation(1, 73);
			mWS(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}

} // namespace Functional.Parser