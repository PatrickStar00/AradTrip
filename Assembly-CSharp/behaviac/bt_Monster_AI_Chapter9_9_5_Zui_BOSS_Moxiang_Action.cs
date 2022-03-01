﻿using System;

namespace behaviac
{
	// Token: 0x020031CE RID: 12750
	public static class bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action
	{
		// Token: 0x06014C2F RID: 85039 RVA: 0x006402B4 File Offset: 0x0063E6B4
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Chapter9/9-5_Zui_BOSS_Moxiang_Action");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7 parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node = new Parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7();
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetId(7);
			bt.AddChild(parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.AddChild(sequence);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetId(3);
			sequence.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.HasEvents());
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(1);
			sequence.AddChild(selector);
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(6);
			selector.AddChild(sequence2);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2.SetId(16);
			sequence2.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node73 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node73();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3.SetId(73);
			sequence2.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetId(8);
			sequence2.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(5);
			selector.AddChild(sequence3);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4.SetId(10);
			sequence3.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node74 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node74();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5.SetId(74);
			sequence3.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2.SetId(12);
			sequence3.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(23);
			selector.AddChild(sequence4);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node24 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node24();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6.SetId(24);
			sequence4.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node75 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node75();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7.SetId(75);
			sequence4.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node26 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node26();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3.SetId(26);
			sequence4.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node3.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(27);
			selector.AddChild(sequence5);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node28 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node28();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8.SetId(28);
			sequence5.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node77 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node77();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9.SetId(77);
			sequence5.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node29 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node29();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4.SetId(29);
			sequence5.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			sequence.SetHasEvents(sequence.HasEvents() | selector.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.HasEvents() | sequence.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(11);
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.AddChild(sequence6);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10.SetId(13);
			sequence6.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10.HasEvents());
			Selector selector2 = new Selector();
			selector2.SetClassNameString("Selector");
			selector2.SetId(14);
			sequence6.AddChild(selector2);
			Sequence sequence7 = new Sequence();
			sequence7.SetClassNameString("Sequence");
			sequence7.SetId(15);
			selector2.AddChild(sequence7);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node17 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node17();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11.SetId(17);
			sequence7.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node18 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node18();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12.SetId(18);
			sequence7.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12);
			sequence7.SetHasEvents(sequence7.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node19 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node19();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5.SetId(19);
			sequence7.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5);
			sequence7.SetHasEvents(sequence7.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node5.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | sequence7.HasEvents());
			Sequence sequence8 = new Sequence();
			sequence8.SetClassNameString("Sequence");
			sequence8.SetId(20);
			selector2.AddChild(sequence8);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node21 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node21();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13.SetId(21);
			sequence8.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node22 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node22();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14.SetId(22);
			sequence8.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14);
			sequence8.SetHasEvents(sequence8.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node25 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node25();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6.SetId(25);
			sequence8.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6);
			sequence8.SetHasEvents(sequence8.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node6.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | sequence8.HasEvents());
			Sequence sequence9 = new Sequence();
			sequence9.SetClassNameString("Sequence");
			sequence9.SetId(30);
			selector2.AddChild(sequence9);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node31 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node31();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15.SetId(31);
			sequence9.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node32 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node32();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16.SetId(32);
			sequence9.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16);
			sequence9.SetHasEvents(sequence9.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node33 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node33();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7.SetId(33);
			sequence9.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7);
			sequence9.SetHasEvents(sequence9.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node7.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | sequence9.HasEvents());
			Sequence sequence10 = new Sequence();
			sequence10.SetClassNameString("Sequence");
			sequence10.SetId(34);
			selector2.AddChild(sequence10);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node38 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node17 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node38();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node17.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node17.SetId(38);
			sequence10.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node17);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node17.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node42 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node18 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node42();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node18.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node18.SetId(42);
			sequence10.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node18);
			sequence10.SetHasEvents(sequence10.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node18.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node46 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node46();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8.SetId(46);
			sequence10.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8);
			sequence10.SetHasEvents(sequence10.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node8.HasEvents());
			selector2.SetHasEvents(selector2.HasEvents() | sequence10.HasEvents());
			sequence6.SetHasEvents(sequence6.HasEvents() | selector2.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.HasEvents() | sequence6.HasEvents());
			Sequence sequence11 = new Sequence();
			sequence11.SetClassNameString("Sequence");
			sequence11.SetId(2);
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.AddChild(sequence11);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node19 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node4();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node19.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node19.SetId(4);
			sequence11.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node19);
			sequence11.SetHasEvents(sequence11.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node19.HasEvents());
			Selector selector3 = new Selector();
			selector3.SetClassNameString("Selector");
			selector3.SetId(9);
			sequence11.AddChild(selector3);
			Sequence sequence12 = new Sequence();
			sequence12.SetClassNameString("Sequence");
			sequence12.SetId(35);
			selector3.AddChild(sequence12);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node36 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node20 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node36();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node20.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node20.SetId(36);
			sequence12.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node20);
			sequence12.SetHasEvents(sequence12.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node20.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node83 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node21 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node83();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node21.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node21.SetId(83);
			sequence12.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node21);
			sequence12.SetHasEvents(sequence12.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node21.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node37 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node37();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9.SetId(37);
			sequence12.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9);
			sequence12.SetHasEvents(sequence12.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node9.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence12.HasEvents());
			Sequence sequence13 = new Sequence();
			sequence13.SetClassNameString("Sequence");
			sequence13.SetId(39);
			selector3.AddChild(sequence13);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node40 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node22 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node40();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node22.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node22.SetId(40);
			sequence13.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node22);
			sequence13.SetHasEvents(sequence13.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node22.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node84 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node23 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node84();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node23.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node23.SetId(84);
			sequence13.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node23);
			sequence13.SetHasEvents(sequence13.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node23.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node41 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node41();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10.SetId(41);
			sequence13.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10);
			sequence13.SetHasEvents(sequence13.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node10.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence13.HasEvents());
			Sequence sequence14 = new Sequence();
			sequence14.SetClassNameString("Sequence");
			sequence14.SetId(43);
			selector3.AddChild(sequence14);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node44 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node24 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node44();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node24.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node24.SetId(44);
			sequence14.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node24);
			sequence14.SetHasEvents(sequence14.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node24.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node85 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node25 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node85();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node25.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node25.SetId(85);
			sequence14.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node25);
			sequence14.SetHasEvents(sequence14.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node25.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node45 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node45();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11.SetId(45);
			sequence14.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11);
			sequence14.SetHasEvents(sequence14.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node11.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence14.HasEvents());
			Sequence sequence15 = new Sequence();
			sequence15.SetClassNameString("Sequence");
			sequence15.SetId(47);
			selector3.AddChild(sequence15);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node48 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node26 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node48();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node26.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node26.SetId(48);
			sequence15.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node26);
			sequence15.SetHasEvents(sequence15.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node26.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node86 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node27 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node86();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node27.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node27.SetId(86);
			sequence15.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node27);
			sequence15.SetHasEvents(sequence15.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node27.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node49 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node49();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12.SetId(49);
			sequence15.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12);
			sequence15.SetHasEvents(sequence15.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node12.HasEvents());
			selector3.SetHasEvents(selector3.HasEvents() | sequence15.HasEvents());
			sequence11.SetHasEvents(sequence11.HasEvents() | selector3.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.HasEvents() | sequence11.HasEvents());
			Sequence sequence16 = new Sequence();
			sequence16.SetClassNameString("Sequence");
			sequence16.SetId(55);
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.AddChild(sequence16);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node56 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node28 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node56();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node28.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node28.SetId(56);
			sequence16.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node28);
			sequence16.SetHasEvents(sequence16.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node28.HasEvents());
			Selector selector4 = new Selector();
			selector4.SetClassNameString("Selector");
			selector4.SetId(50);
			sequence16.AddChild(selector4);
			Sequence sequence17 = new Sequence();
			sequence17.SetClassNameString("Sequence");
			sequence17.SetId(51);
			selector4.AddChild(sequence17);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node52 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node29 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node52();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node29.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node29.SetId(52);
			sequence17.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node29);
			sequence17.SetHasEvents(sequence17.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node29.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node53 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node30 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node53();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node30.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node30.SetId(53);
			sequence17.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node30);
			sequence17.SetHasEvents(sequence17.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node30.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node54 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node54();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13.SetId(54);
			sequence17.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13);
			sequence17.SetHasEvents(sequence17.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node13.HasEvents());
			selector4.SetHasEvents(selector4.HasEvents() | sequence17.HasEvents());
			Sequence sequence18 = new Sequence();
			sequence18.SetClassNameString("Sequence");
			sequence18.SetId(57);
			selector4.AddChild(sequence18);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node58 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node31 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node58();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node31.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node31.SetId(58);
			sequence18.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node31);
			sequence18.SetHasEvents(sequence18.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node31.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node59 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node32 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node59();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node32.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node32.SetId(59);
			sequence18.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node32);
			sequence18.SetHasEvents(sequence18.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node32.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node60 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node60();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14.SetId(60);
			sequence18.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14);
			sequence18.SetHasEvents(sequence18.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node14.HasEvents());
			selector4.SetHasEvents(selector4.HasEvents() | sequence18.HasEvents());
			Sequence sequence19 = new Sequence();
			sequence19.SetClassNameString("Sequence");
			sequence19.SetId(61);
			selector4.AddChild(sequence19);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node62 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node33 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node62();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node33.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node33.SetId(62);
			sequence19.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node33);
			sequence19.SetHasEvents(sequence19.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node33.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node63 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node34 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node63();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node34.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node34.SetId(63);
			sequence19.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node34);
			sequence19.SetHasEvents(sequence19.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node34.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node64 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node64();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15.SetId(64);
			sequence19.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15);
			sequence19.SetHasEvents(sequence19.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node15.HasEvents());
			selector4.SetHasEvents(selector4.HasEvents() | sequence19.HasEvents());
			Sequence sequence20 = new Sequence();
			sequence20.SetClassNameString("Sequence");
			sequence20.SetId(65);
			selector4.AddChild(sequence20);
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node66 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node35 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node66();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node35.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node35.SetId(66);
			sequence20.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node35);
			sequence20.SetHasEvents(sequence20.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node35.HasEvents());
			Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node67 condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node36 = new Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node67();
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node36.SetClassNameString("Condition");
			condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node36.SetId(67);
			sequence20.AddChild(condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node36);
			sequence20.SetHasEvents(sequence20.HasEvents() | condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node36.HasEvents());
			Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node68 action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16 = new Action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node68();
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16.SetClassNameString("Action");
			action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16.SetId(68);
			sequence20.AddChild(action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16);
			sequence20.SetHasEvents(sequence20.HasEvents() | action_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node16.HasEvents());
			selector4.SetHasEvents(selector4.HasEvents() | sequence20.HasEvents());
			sequence16.SetHasEvents(sequence16.HasEvents() | selector4.HasEvents());
			parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.SetHasEvents(parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.HasEvents() | sequence16.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node.HasEvents());
			return true;
		}
	}
}
