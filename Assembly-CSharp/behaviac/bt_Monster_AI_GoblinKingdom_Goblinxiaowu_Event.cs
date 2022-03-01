﻿using System;

namespace behaviac
{
	// Token: 0x020032F6 RID: 13046
	public static class bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event
	{
		// Token: 0x06014E57 RID: 85591 RVA: 0x0064B5E0 File Offset: 0x006499E0
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/GoblinKingdom/Goblinxiaowu_Event");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(1);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(4);
			selector.AddChild(sequence);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.SetId(2);
			sequence.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.HasEvents());
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.SetId(3);
			sequence.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node0 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node0();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.SetId(0);
			sequence.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.HasEvents());
			DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node16 decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node = new DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node16();
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.SetId(16);
			sequence.AddChild(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node);
			Selector selector2 = new Selector();
			selector2.SetClassNameString("Selector");
			selector2.SetId(25);
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.AddChild(selector2);
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(26);
			selector2.AddChild(sequence2);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node27 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node27();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.SetId(27);
			sequence2.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node28 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node28();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.SetId(28);
			sequence2.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(29);
			selector2.AddChild(sequence3);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node30 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node30();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.SetId(30);
			sequence3.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node31 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node31();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.SetId(31);
			sequence3.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(17);
			selector2.AddChild(sequence4);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node20 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node20();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5.SetId(20);
			sequence4.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node18 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node18();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.SetId(18);
			sequence4.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | sequence4.HasEvents());
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.SetHasEvents(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.HasEvents() | selector2.HasEvents());
			sequence.SetHasEvents(sequence.HasEvents() | decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(5);
			selector.AddChild(sequence5);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6.SetId(6);
			sequence5.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6.HasEvents());
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7.SetId(7);
			sequence5.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5.SetId(8);
			sequence5.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node5.HasEvents());
			DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node24 decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2 = new DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node24();
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.SetId(24);
			sequence5.AddChild(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2);
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(21);
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.AddChild(sequence6);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node22 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node22();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8.SetId(22);
			sequence6.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node23 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node23();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6.SetId(23);
			sequence6.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node6.HasEvents());
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.SetHasEvents(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.HasEvents() | sequence6.HasEvents());
			sequence5.SetHasEvents(sequence5.HasEvents() | decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node2.HasEvents());
			Selector selector3 = new Selector();
			selector3.SetClassNameString("Selector");
			selector3.SetId(36);
			sequence5.AddChild(selector3);
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(32);
			selector3.AddChild(sequence7);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node33 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node33();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9.SetId(33);
			sequence7.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node34 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node34();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7.SetId(34);
			sequence7.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node7.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence7.HasEvents());
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(37);
			selector3.AddChild(sequence8);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node38 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node38();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10.SetId(38);
			sequence8.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node39 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node39();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8.SetId(39);
			sequence8.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node8.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence8.HasEvents());
			Sequence sequence9 = new Sequence();
			sequence9.SetClassNameString("Sequence");
			sequence9.SetId(40);
			selector3.AddChild(sequence9);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node41 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node41();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11.SetId(41);
			sequence9.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node42 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node42();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9.SetId(42);
			sequence9.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node9.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence9.HasEvents());
			sequence5.SetHasEvents(sequence5.HasEvents() | selector3.HasEvents());
			DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node35 decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3 = new DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node35();
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.SetId(35);
			sequence5.AddChild(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3);
			Sequence sequence10 = new Sequence();
			sequence10.SetClassNameString("Sequence");
			sequence10.SetId(43);
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.AddChild(sequence10);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node44 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node12 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node44();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node12.SetId(44);
			sequence10.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node12);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node12.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node45 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node45();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10.SetId(45);
			sequence10.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node10.HasEvents());
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.SetHasEvents(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.HasEvents() | sequence10.HasEvents());
			sequence5.SetHasEvents(sequence5.HasEvents() | decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node3.HasEvents());
			DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node49 decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4 = new DecoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node49();
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.SetClassNameString("DecoratorAlwaysSuccess");
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.SetId(49);
			sequence5.AddChild(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4);
			Sequence sequence11 = new Sequence();
			sequence11.SetClassNameString("Sequence");
			sequence11.SetId(46);
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.AddChild(sequence11);
			Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node47 condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node13 = new Condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node47();
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node13.SetId(47);
			sequence11.AddChild(condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node13);
			sequence11.SetHasEvents(sequence11.HasEvents() | condition_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node13.HasEvents());
			Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node48 action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11 = new Action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node48();
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11.SetClassNameString("Action");
			action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11.SetId(48);
			sequence11.AddChild(action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11);
			sequence11.SetHasEvents(sequence11.HasEvents() | action_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node11.HasEvents());
			decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.SetHasEvents(decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.HasEvents() | sequence11.HasEvents());
			sequence5.SetHasEvents(sequence5.HasEvents() | decoratorAlwaysSuccess_bt_Monster_AI_GoblinKingdom_Goblinxiaowu_Event_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}
